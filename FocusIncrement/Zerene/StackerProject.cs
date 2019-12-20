using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;

namespace FocusIncrement.Zerene
{
    internal class StackerProject
    {
        public List<OutputImage> OutputImages { get; private set; }
        public int OutputSequenceNumber { get; set; }
        public Preferences Preferences { get; set; }
        public string StackerVersion { get; set; }
        public List<StackFrame> StackFrames { get; private set; }

        public StackerProject()
        {
            this.OutputImages = new List<OutputImage>();
            this.Preferences = new Preferences();
            this.StackerVersion = "1.04 Build T2019-10-07-1410";
            this.StackFrames = new List<StackFrame>();
        }

        public void WriteAndCopyOutputs(string directoryPath, List<string> outputFileSourcePaths)
        {
            if (outputFileSourcePaths.Count != this.OutputImages.Count)
            {
                throw new ArgumentOutOfRangeException(nameof(outputFileSourcePaths));
            }

            string projectDirectoryPath = Path.Combine(directoryPath, "ZSHProject");
            if (Directory.Exists(projectDirectoryPath) == false)
            {
                Directory.CreateDirectory(projectDirectoryPath);
            }
            string generatedImagesPath = Path.Combine(projectDirectoryPath, "generatedimages");
            if (Directory.Exists(generatedImagesPath) == false)
            {
                Directory.CreateDirectory(generatedImagesPath);
            }
            string previewImagesPath = Path.Combine(projectDirectoryPath, "previewimages");
            if (Directory.Exists(previewImagesPath) == false)
            {
                Directory.CreateDirectory(previewImagesPath);
            }

            string projectFilePath = Path.Combine(projectDirectoryPath, "ZSHProject.zsj");
            using FileStream stream = new FileStream(projectFilePath, FileMode.Create, FileAccess.Write, FileShare.None);
            using XmlWriter writer = XmlTextWriter.Create(stream);
            writer.WriteStartElement(Constant.Zerene.Element.ZereneStacker);
            writer.WriteStartElement(Constant.Zerene.Element.StackerProject);
            writer.WriteStartElement(Constant.Zerene.Element.StackerVersion);
            writer.WriteAttributeString(Constant.Zerene.Attribute.Value, this.StackerVersion);
            writer.WriteEndElement();

            if (this.Preferences != null)
            {
                this.Preferences.Write(writer);
            }

            writer.WriteStartElement(Constant.Zerene.Element.StackFrames);
            writer.WriteAttributeString(Constant.Zerene.Attribute.Length, this.StackFrames.Count.ToString());
            foreach (StackFrame frame in this.StackFrames)
            {
                frame.Write(writer);
            }
            writer.WriteEndElement();

            writer.WriteStartElement(Constant.Zerene.Element.OutputSequenceNumber);
            writer.WriteAttributeString(Constant.Zerene.Attribute.Value, this.OutputImages.Count.ToString());
            writer.WriteEndElement();

            writer.WriteStartElement(Constant.Zerene.Element.OutputImages);
            writer.WriteAttributeString(Constant.Zerene.Attribute.Length, this.OutputImages.Count.ToString());
            foreach (OutputImage image in this.OutputImages)
            {
                image.Write(writer);
            }
            writer.WriteEndElement();

            writer.WriteEndElement(); // StackerProject
            writer.WriteEndElement(); // ZereneStacker

            for (int output = 0; output < outputFileSourcePaths.Count; ++output)
            {
                string sourcePath = outputFileSourcePaths[output];
                string outputImageName = this.OutputImages[output].FileName;
                string destinationPath = Path.Combine(generatedImagesPath, outputImageName);
                if (File.Exists(destinationPath) == false)
                {
                    // TODO: check timestamp
                    File.Copy(sourcePath, destinationPath);
                }
            }
        }
    }
}
