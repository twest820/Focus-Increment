using System;
using System.Xml;

namespace FocusIncrement.Helicon
{
    internal class SourceFile : XmlParser
    {
        public bool Checked { get; set; }
        public string Name { get; set; }

        public SourceFile(XmlReader reader)
        {
            while (reader.EOF == false)
            {
                if (reader.IsStartElement())
                {
                    if (reader.IsStartElement(Constant.Helicon.Element.SourceFile))
                    {
                        this.Checked = Boolean.Parse(this.ReadAttribute(reader, Constant.Helicon.Attribute.Checked));
                        reader.MoveToElement();
                        this.Name = reader.ReadElementContentAsString();
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
    }
}
