using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Xml;

namespace FocusIncrement.Helicon
{
    internal class Project : XmlParser
    {
        private readonly string projectFilePath;

        public DateTime CompiledAt { get; set; }
        public int[] CropRect { get; private set; }
        public Graphics Graphics { get; private set; }
        public string Method { get; set; }
        public int Radius { get; set; }
        public RawLoadOptions RawLoadOptions { get; set; }
        public Retouching Retouching { get; set; }
        public int ResultColorSpace { get; set; }
        public int Smoothing { get; set; }
        public List<SourceFile> SourceFiles { get; private set; }
        public string Type { get; set; }
        public Version Version { get; set; }

        public Project(string projectFilePath)
        {
            this.projectFilePath = projectFilePath;

            this.CropRect = new int[4];
            this.RawLoadOptions = new RawLoadOptions();
            this.SourceFiles = new List<SourceFile>();

            using XmlReader reader = XmlTextReader.Create(projectFilePath);
            reader.MoveToContent();
            while (reader.EOF == false)
            {
                if (reader.IsStartElement())
                {
                    // most common cases first
                    if (reader.IsStartElement(Constant.Helicon.Element.SourceFile))
                    {
                        this.SourceFiles.Add(new SourceFile(reader.ReadSubtree()));
                    }
                    else if (reader.IsStartElement(Constant.Helicon.Element.Graphics))
                    {
                        this.Graphics = new Graphics(reader.ReadSubtree());
                    }
                    else if (reader.IsStartElement(Constant.Helicon.Element.Project))
                    {
                        this.Type = this.ReadAttribute(reader, Constant.Helicon.Attribute.Type);

                        string[] cropCorners = this.ReadAttribute(reader, Constant.Helicon.Attribute.CropRect).Split(',');
                        if ((cropCorners == null) || (cropCorners.Length != 4))
                        {
                            throw new XmlException(String.Format("{0} attribute on {1} element does not list four corners.", Constant.Helicon.Attribute.CropRect, Constant.Helicon.Element.Project));
                        }
                        for (int corner = 0; corner < 4; ++corner)
                        {
                            this.CropRect[corner] = Int32.Parse(cropCorners[corner]);
                        }

                        this.Smoothing = Int32.Parse(this.ReadAttribute(reader, Constant.Helicon.Attribute.Smoothing));
                        this.Version = Version.Parse(this.ReadAttribute(reader, Constant.Helicon.Attribute.Version));
                        this.ResultColorSpace = Int32.Parse(this.ReadAttribute(reader, Constant.Helicon.Attribute.ResultColorSpace));
                        this.Radius = Int32.Parse(this.ReadAttribute(reader, Constant.Helicon.Attribute.Radius));
                        this.CompiledAt = DateTime.ParseExact(this.ReadAttribute(reader, Constant.Helicon.Attribute.CompiledAt), Constant.UtcFormat, CultureInfo.InvariantCulture);
                        this.Method = this.ReadAttribute(reader, Constant.Helicon.Attribute.Method);

                        reader.Read();
                    }
                    else if (reader.IsStartElement(Constant.Helicon.Element.RawLoadOptions))
                    {
                        this.RawLoadOptions.Loader = this.ReadAttribute(reader, Constant.Helicon.Attribute.Loader);
                        this.RawLoadOptions.ColorSpace = Int32.Parse(this.ReadAttribute(reader, Constant.Helicon.Attribute.ColorSpace));

                        reader.Read();
                    }
                    else if (reader.IsStartElement(Constant.Helicon.Element.Retouching))
                    {
                        this.Retouching = new Retouching(reader.ReadSubtree());
                    }
                    else if (reader.IsStartElement(Constant.Helicon.Element.SourceFiles))
                    {
                        reader.Read();
                    }
                    else
                    {
                        throw new XmlException(String.Format("Unhandled element '{0}'.", reader.Name));
                    }
                }
                else
                {
                    reader.Read();
                }
            }
        }

        public string GetOutputFilePath()
        {
            return Path.Combine(Path.GetFileNameWithoutExtension(this.projectFilePath) + "_files", "result.tiff");
        }
    }
}
