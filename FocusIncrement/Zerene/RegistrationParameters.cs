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