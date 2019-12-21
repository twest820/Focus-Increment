using System;
using System.Xml;

namespace FocusIncrement.Zerene
{
    internal class BrightnessCorrectionParameters : ZereneXmlElement
    {
        public double GammaAdjustment { get; set; }
        public double Scale { get; set; }

        public BrightnessCorrectionParameters()
        {
        }

        public BrightnessCorrectionParameters(XmlReader reader)
        {
            while (reader.EOF == false)
            {
                if (reader.IsStartElement())
                {
                    if (reader.IsStartElement(Constant.Zerene.Element.BrightnessCorrectionParameters))
                    {
                        reader.Read();
                    }
                    else if (reader.IsStartElement(Constant.Zerene.Element.GammaAdjustment))
                    {
                        this.GammaAdjustment = this.ReadValueAsDouble(reader);
                    }
                    else if (reader.IsStartElement(Constant.Zerene.Element.Scale))
                    {
                        this.Scale = this.ReadValueAsDouble(reader);
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
            writer.WriteStartElement(Constant.Zerene.Element.BrightnessCorrectionParameters);
            this.WriteElementValue(writer, Constant.Zerene.Element.GammaAdjustment, this.GammaAdjustment);
            this.WriteElementValue(writer, Constant.Zerene.Element.Scale, this.Scale);
            writer.WriteEndElement();
        }
    }
}
