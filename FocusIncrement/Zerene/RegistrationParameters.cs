using System;
using System.Xml;

namespace FocusIncrement.Zerene
{
    internal class RegistrationParameters : ZereneXmlElement
    {
        public int LimitFlags { get; set; }
        public double Rotate { get; set; }
        public double Scale { get; set; }
        public double XOffset { get; set; }
        public double YOffset { get; set; }

        public RegistrationParameters()
        {
        }

        public RegistrationParameters(XmlReader reader)
        {
            while (reader.EOF == false)
            {
                if (reader.IsStartElement())
                {
                    if (reader.IsStartElement(Constant.Zerene.Element.LimitFlags))
                    {
                        this.LimitFlags = this.ReadValueAsInt(reader);
                    }
                    else if (reader.IsStartElement(Constant.Zerene.Element.RegistrationParameters))
                    {
                        reader.Read();
                    }
                    else if (reader.IsStartElement(Constant.Zerene.Element.Rotate))
                    {
                        this.Rotate = this.ReadValueAsDouble(reader);
                    }
                    else if (reader.IsStartElement(Constant.Zerene.Element.Scale))
                    {
                        this.Scale = this.ReadValueAsDouble(reader);
                    }
                    else if (reader.IsStartElement(Constant.Zerene.Element.XOffset))
                    {
                        this.XOffset = this.ReadValueAsDouble(reader);
                    }
                    else if (reader.IsStartElement(Constant.Zerene.Element.YOffset))
                    {
                        this.YOffset = this.ReadValueAsDouble(reader);
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
            writer.WriteStartElement(Constant.Zerene.Element.RegistrationParameters);
            this.WriteElementValue(writer, Constant.Zerene.Element.XOffset, this.XOffset);
            this.WriteElementValue(writer, Constant.Zerene.Element.YOffset, this.YOffset);
            this.WriteElementValue(writer, Constant.Zerene.Element.Scale, this.Scale);
            this.WriteElementValue(writer, Constant.Zerene.Element.Rotate, this.Rotate);
            this.WriteElementValue(writer, Constant.Zerene.Element.LimitFlags, this.LimitFlags);
            writer.WriteEndElement();
        }
    }
}