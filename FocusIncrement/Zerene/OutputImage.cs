using System.Xml;

namespace FocusIncrement.Zerene
{
    internal class OutputImage : ZereneXmlElement
    {
        public string Description { get; set; }
        public string FileName { get; set; }

        public void Write(XmlWriter writer)
        {
            writer.WriteStartElement(Constant.Zerene.Element.OutputImage);
            this.WriteElementValue(writer, Constant.Zerene.Element.Description, this.Description);
            this.WriteElementValue(writer, Constant.Zerene.Element.FileName, this.FileName);
            writer.WriteEndElement();
        }
    }
}
