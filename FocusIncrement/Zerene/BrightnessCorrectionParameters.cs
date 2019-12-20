using System.Xml;

namespace FocusIncrement.Zerene
{
    internal class BrightnessCorrectionParameters : ZereneXmlElement
    {
        public double GammaAdjustment { get; set; }
        public double Scale { get; set; }

        public void Write(XmlWriter writer)
        {
            writer.WriteStartElement(Constant.Zerene.Element.BrightnessCorrectionParameters);
            this.WriteElementValue(writer, Constant.Zerene.Element.GammaAdjustment, this.GammaAdjustment);
            this.WriteElementValue(writer, Constant.Zerene.Element.Scale, this.Scale);
            writer.WriteEndElement();
        }
    }
}
