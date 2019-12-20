using FocusIncrement.Helicon;
using FocusIncrement.Zerene;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Management.Automation;
using Debug = System.Diagnostics.Debug;

namespace FocusIncrement
{
    [Cmdlet(VerbsData.Convert, "Helicon")]
    public class ConvertHelicon : Cmdlet
    {
        [Parameter(Mandatory = true)]
        public string StackDirectory { get; set; }

        private OutputImage GetZereneOutputImage(Project heliconProject)
        {
            string timestamp = heliconProject.CompiledAt.ToString("yyyy-MM-dd HH-mm-ss");
            string outputFileName = heliconProject.Method switch
            {
                "B" => timestamp + " (B,Radius" + heliconProject.Radius + ",Smoothing" + heliconProject.Smoothing + ").tiff",
                "C" => timestamp + " (C,Smoothing" + heliconProject.Smoothing + ").tiff",
                _ => throw new NotSupportedException(String.Format("Unhandled Helicon stacking method '{0}'.", heliconProject.Method))
            };
            return new OutputImage()
            {
                Description = Path.GetFileNameWithoutExtension(outputFileName),
                FileName = outputFileName
            };
        }

        protected override void ProcessRecord()
        {
            string[] heliconProjectPaths = Directory.GetFiles(this.StackDirectory, "*.hproj");
            if ((heliconProjectPaths == null) || (heliconProjectPaths.Length < 1))
            {
                this.WriteError(new ErrorRecord(new FileNotFoundException(String.Format("No Helicon project files found in directory '{0}'.", this.StackDirectory)), string.Empty, ErrorCategory.InvalidArgument, this));
                return;
            }

            // load Helicon projects
            List<Project> heliconProjects = new List<Project>();
            foreach (string projectPath in heliconProjectPaths)
            {
                heliconProjects.Add(new Project(projectPath));
                // TODO: check input images match
                // TODO: check deformations match
            }
            Project defaultHeliconProject = heliconProjects.FirstOrDefault(project => project.Method == "B");
            if (defaultHeliconProject == null)
            {
                defaultHeliconProject = heliconProjects[0];
            }
            heliconProjects.Remove(defaultHeliconProject);

            // initialize Zerene from default Helicon project
            // TODO: read default preferences from Environment.ApplicationData\ZereneStacker\zerenstk.cfg
            StackerProject zereneProject = new StackerProject();
            zereneProject.Preferences.BatchFileChooserLastDirectory = this.StackDirectory;
            zereneProject.Preferences.SaveImageFolderPathLastUsed = this.StackDirectory;
            foreach (Deformation deformation in defaultHeliconProject.Retouching.Deformations)
            {
                Debug.Assert(deformation.ScaleX == deformation.ScaleY);

                StackFrame frame = new StackFrame
                {
                    ImageSource = Path.Combine(this.StackDirectory, deformation.SourceFile)
                };
                frame.BrightnessCorrectionParameters.GammaAdjustment = deformation.GammaAdjustment;
                frame.BrightnessCorrectionParameters.Scale = 1.0F + deformation.GammaScale;
                frame.RegistrationParameters.Rotate = deformation.Rotation;
                frame.RegistrationParameters.Scale = 1.0F / deformation.ScaleX;
                frame.RegistrationParameters.XOffset = (deformation.HalfX - deformation.CenterX) / (2.0F * deformation.HalfX);
                frame.RegistrationParameters.YOffset = (deformation.HalfY - deformation.CenterY) / (2.0F * deformation.HalfY);
                zereneProject.StackFrames.Add(frame);
            }
            zereneProject.OutputImages.Add(this.GetZereneOutputImage(defaultHeliconProject));
            List<string> outputFilePaths = new List<string>()
            {
                Path.Combine(this.StackDirectory, defaultHeliconProject.GetOutputFilePath())
            };

            // add outputs from other Helicon projects
            foreach (Project heliconProject in heliconProjects)
            {
                zereneProject.OutputImages.Add(this.GetZereneOutputImage(heliconProject));
                outputFilePaths.Add(Path.Combine(this.StackDirectory, heliconProject.GetOutputFilePath()));
            }
            zereneProject.OutputSequenceNumber = heliconProjects.Count;

            // construct Zerene project on disk
            // TODO: check for overwrite and -Force switch
            zereneProject.WriteAndCopyOutputs(this.StackDirectory, outputFilePaths);
        }
    }
}
