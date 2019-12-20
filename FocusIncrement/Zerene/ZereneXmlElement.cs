using System;
using System.Globalization;
using System.Xml;

namespace FocusIncrement.Zerene
{
    internal class ZereneXmlElement
    {
        protected void WriteElementValue(XmlWriter writer, string elementName, bool value)
        {
            this.WriteElementValue(writer, elementName, value ? "true" : "false");
        }

        protected void WriteElementValue(XmlWriter writer, string elementName, byte[] value)
        {
            this.WriteElementValue(writer, elementName, String.Concat(value[0], ",", value[1], ",", value[2], ",", value[3]));
        }

        protected void WriteElementValue(XmlWriter writer, string elementName, double value)
        {
            // TODO: scientific notation for offset and rotation values close to zero
            this.WriteElementValue(writer, elementName, value.ToString("0.0###############", CultureInfo.InvariantCulture));
        }

        protected void WriteElementValue(XmlWriter writer, string elementName, int value)
        {
            this.WriteElementValue(writer, elementName, value.ToString());
        }

        protected void WriteElementValue(XmlWriter writer, string elementName, string value)
        {
            writer.WriteStartElement(elementName);
            writer.WriteAttributeString(Constant.Zerene.Attribute.Value, value);
            writer.WriteEndElement();
        }
    }
}
