using System;
using System.Globalization;
using System.Xml;

namespace FocusIncrement.Zerene
{
    internal class ZereneXmlElement
    {
        protected bool ReadValueAsBoolean(XmlReader reader)
        {
            return Boolean.Parse(this.ReadValueAsString(reader));
        }

        protected byte[] ReadValueAsByteQuad(XmlReader reader)
        {
            string[] bytesAsStrings = this.ReadValueAsString(reader).Split(',');
            if ((bytesAsStrings == null) || (bytesAsStrings.Length != 4))
            {
                throw new XmlException("Expected four comma separated byte values.");
            }
            byte[] bytes = new byte[4];
            for (int index = 0; index < 4; ++index)
            {
                bytes[index] = Byte.Parse(bytesAsStrings[index]);
            }
            return bytes;
        }

        protected double ReadValueAsDouble(XmlReader reader)
        {
            return Double.Parse(this.ReadValueAsString(reader));
        }

        protected int ReadValueAsInt(XmlReader reader)
        {
            return Int32.Parse(this.ReadValueAsString(reader));
        }

        protected string ReadValueAsString(XmlReader reader)
        {
            reader.MoveToAttribute(Constant.Zerene.Attribute.Value);
            string value = reader.Value;
            reader.Read();
            return value;
        }

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
