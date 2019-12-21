using System;
using System.Xml;

namespace FocusIncrement.Zerene
{
    internal class StackFrame : ZereneXmlElement
    {
        public BrightnessCorrectionParameters BrightnessCorrectionParameters { get; set; }
        public string CachedRegScreenImage { get; set; }
        public string CachedUnregScreenImage { get; set; }
        public string ImageSource { get; set; }
        public RegistrationParameters RegistrationParameters { get; private set; }

        public StackFrame()
        {
            this.BrightnessCorrectionParameters = new BrightnessCorrectionParameters();
            this.CachedRegScreenImage = null;
            this.CachedUnregScreenImage = null;
            this.ImageSource = null;
            this.RegistrationParameters = new RegistrationParameters();
        }

        public StackFrame(XmlReader reader)
            : this()
        {
            while (reader.EOF == false)
            {
                if (reader.IsStartElement())
                {
                    if (reader.IsStartElement(Constant.Zerene.Element.BrightnessCorrectionParameters))
                    {
                        this.BrightnessCorrectionParameters = new BrightnessCorrectionParameters(reader.ReadSubtree());
                    }
                    else if (reader.IsStartElement(Constant.Zerene.Element.CachedRegScreenImage))
                    {
                        this.CachedRegScreenImage = this.ReadValueAsString(reader);
                    }
                    else if (reader.IsStartElement(Constant.Zerene.Element.CachedUnregScreenImage))
                    {
                        this.CachedUnregScreenImage = this.ReadValueAsString(reader);
                    }
                    else if (reader.IsStartElement(Constant.Zerene.Element.ImageSource))
                    {
                        reader.Read();
                    }
                    else if (reader.IsStartElement(Constant.Zerene.Element.RegistrationParameters))
                    {
                        this.RegistrationParameters = new RegistrationParameters(reader.ReadSubtree());
                    }
                    else if (reader.IsStartElement(Constant.Zerene.Element.Source))
                    {
                        this.ImageSource = this.ReadValueAsString(reader);
                    }
                    else if (reader.IsStartElement(Constant.Zerene.Element.StackFrame))
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

        public void Write(XmlWriter writer)
        {
            writer.WriteStartElement(Constant.Zerene.Element.StackFrame);
            writer.WriteStartElement(Constant.Zerene.Element.ImageSource);
            writer.WriteStartElement(Constant.Zerene.Element.Source);
            writer.WriteAttributeString(Constant.Zerene.Attribute.Value, this.ImageSource);
            writer.WriteEndElement();
            writer.WriteEndElement();

            this.RegistrationParameters.Write(writer);
            this.BrightnessCorrectionParameters.Write(writer);

            if (this.CachedUnregScreenImage != null)
            {
                this.WriteElementValue(writer, Constant.Zerene.Element.CachedUnregScreenImage, this.CachedUnregScreenImage);
            }
            if (this.CachedRegScreenImage != null)
            {
                this.WriteElementValue(writer, Constant.Zerene.Element.CachedRegScreenImage, this.CachedRegScreenImage);
            }

            writer.WriteEndElement(); // StackFrame
        }
    }
}
