using System;
using System.Xml;

namespace FocusIncrement.Zerene
{
    internal class OutputImage : ZereneXmlElement
    {
        public string Description { get; set; }
        public string FileName { get; set; }

        public OutputImage()
        {
        }

        public OutputImage(XmlReader reader)
        {
            while (reader.EOF == false)
            {
                if (reader.IsStartElement())
                {
                    if (reader.IsStartElement(Constant.Zerene.Element.Description))
                    {
                        this.Description = this.ReadValueAsString(reader);
                    }
                    else if (reader.IsStartElement(Constant.Zerene.Element.FileName))
                    {
                        this.FileName = this.ReadValueAsString(reader);
                    }
                    else if (reader.IsStartElement(Constant.Zerene.Element.OutputImage))
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
            writer.WriteStartElement(Constant.Zerene.Element.OutputImage);
            this.WriteElementValue(writer, Constant.Zerene.Element.Description, this.Description);
            this.WriteElementValue(writer, Constant.Zerene.Element.FileName, this.FileName);
            writer.WriteEndElement();
        }
    }
}
