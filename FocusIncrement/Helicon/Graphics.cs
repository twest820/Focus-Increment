using System;
using System.Xml;

namespace FocusIncrement.Helicon
{
    internal class Graphics
    {
        public string Scales { get; set; }
        public string Texts { get; set; }

        public Graphics(XmlReader reader)
        {
            while (reader.EOF == false)
            {
                if (reader.IsStartElement())
                {
                    if (reader.IsStartElement(Constant.Helicon.Element.Graphics))
                    {
                        reader.Read();
                    }
                    else if (reader.IsStartElement(Constant.Helicon.Element.Texts))
                    {
                        this.Texts = reader.ReadElementContentAsString();
                    }
                    else if (reader.IsStartElement(Constant.Helicon.Element.Scales))
                    {
                        this.Scales = reader.ReadElementContentAsString();
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
