using FocusIncrement.Helicon;
using FocusIncrement.Zerene;
using System;
using System.Globalization;
using System.IO;
using System.Management.Automation;
using Debug = System.Diagnostics.Debug;

namespace FocusIncrement
{
    [Cmdlet(VerbsCommon.Get, "Alignment")]
    public class GetAlignment : Cmdlet
    {
        [Parameter(Mandatory = true)]
        public string Project;

        private void GetHeliconAlignment()
        {
            Project heliconProject = new Project(this.Project);

            string csvFilePath = Path.Combine(Path.GetDirectoryName(this.Project), Path.GetFileNameWithoutExtension(this.Project) + "Alignment.csv");
            using FileStream stream = new FileStream(csvFilePath, FileMode.Create, FileAccess.Write, FileShare.Read);
            using StreamWriter writer = new StreamWriter(stream);
            writer.WriteLine("file,shift X,shift Y,scale,rotation,gamma,gamma scale");
            foreach (Deformation deformation in heliconProject.Retouching.Deformations)
            {
                Debug.Assert(deformation.ScaleX == deformation.ScaleY);

                writer.Write(deformation.SourceFile);
                writer.Write(",");
                writer.Write((deformation.CenterX - deformation.HalfX).ToString("0.0########", CultureInfo.InvariantCulture));
                writer.Write(",");
                writer.Write((deformation.CenterY - deformation.HalfY).ToString("0.0########", CultureInfo.InvariantCulture));
                writer.Write(",");
                writer.Write(deformation.ScaleX.ToString("0.0########", CultureInfo.InvariantCulture));
                writer.Write(",");
                writer.Write(deformation.Rotation.ToString("0.0########", CultureInfo.InvariantCulture));
                writer.Write(",");
                writer.Write(deformation.GammaAdjustment.ToString("0.0########", CultureInfo.InvariantCulture));
                writer.Write(",");
                writer.WriteLine(deformation.GammaScale.ToString("0.0########", CultureInfo.InvariantCulture));
            }
        }

        private void GetZereneAlignment()
        {
            StackerProject zereneProject = new StackerProject(this.Project);

            string csvFilePath = Path.Combine(Path.GetDirectoryName(this.Project), Path.GetFileNameWithoutExtension(this.Project) + "Alignment.csv");
            using FileStream stream = new FileStream(csvFilePath, FileMode.Create, FileAccess.Write, FileShare.Read);
            using StreamWriter writer = new StreamWriter(stream);
            writer.WriteLine("file,shift X,shift Y,scale,rotation,gamma,gamma scale");
            foreach (StackFrame frame in zereneProject.StackFrames)
            {
                writer.Write(frame.ImageSource);
                writer.Write(",");
                writer.Write(frame.RegistrationParameters.XOffset.ToString("0.0###############", CultureInfo.InvariantCulture));
                writer.Write(",");
                writer.Write(frame.RegistrationParameters.YOffset.ToString("0.0###############", CultureInfo.InvariantCulture));
                writer.Write(",");
                writer.Write(frame.RegistrationParameters.Scale.ToString("0.0###############", CultureInfo.InvariantCulture));
                writer.Write(",");
                writer.Write(frame.RegistrationParameters.Rotate.ToString("0.0###############", CultureInfo.InvariantCulture));
                writer.Write(",");
                writer.Write(frame.BrightnessCorrectionParameters.GammaAdjustment.ToString("0.0###############", CultureInfo.InvariantCulture));
                writer.Write(",");
                writer.WriteLine(frame.BrightnessCorrectionParameters.Scale.ToString("0.0###############", CultureInfo.InvariantCulture));
            }
        }

        protected override void ProcessRecord()
        {
            string extension = Path.GetExtension(this.Project);
            switch (extension)
            {
                case ".hproj":
                    this.GetHeliconAlignment();
                    break;
                case ".zsj":
                    this.GetZereneAlignment();
                    break;
                default:
                    throw new NotSupportedException(String.Format("Unhandled project type {0}.", extension));
            }
        }
    }
}
