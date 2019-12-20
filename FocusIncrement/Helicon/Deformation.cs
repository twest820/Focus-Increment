using System;
using System.Xml;

namespace FocusIncrement.Helicon
{
    internal class Deformation : XmlParser
    {
        public float CenterX { get; set; }
        public float CenterY { get; set; }
        public float GammaAdjustment { get; set; }
        public float GammaScale { get; set; }
        public float HalfX { get; set; }
        public float HalfY { get; set; }
        public float Rotation { get; set; }
        public float ScaleX { get; set; }
        public float ScaleY { get; set; }
        public string SourceFile { get; set; }

        public Deformation(XmlReader reader)
        {
            while (reader.EOF == false)
            {
                if (reader.IsStartElement())
                {
                    if (reader.IsStartElement(Constant.Helicon.Element.Deformation))
                    {
                        this.SourceFile = this.ReadAttribute(reader, Constant.Helicon.Attribute.SourceFile);
                        reader.MoveToElement();

                        byte[] packedFloats = Convert.FromBase64String(reader.ReadElementContentAsString());
                        if ((packedFloats == null) || (packedFloats.Length != 36))
                        {
                            throw new XmlException(String.Format("Deformation of file '{0}' does not contain a 36 byte array.", this.SourceFile));
                        }
                        this.HalfX = BitConverter.ToSingle(packedFloats, 0);
                        this.HalfY = BitConverter.ToSingle(packedFloats, 4);
                        this.CenterX = BitConverter.ToSingle(packedFloats, 8);
                        this.CenterY = BitConverter.ToSingle(packedFloats, 12);
                        this.Rotation = BitConverter.ToSingle(packedFloats, 16);
                        this.ScaleX = BitConverter.ToSingle(packedFloats, 20);
                        this.ScaleY = BitConverter.ToSingle(packedFloats, 24);
                        this.GammaAdjustment = BitConverter.ToSingle(packedFloats, 28);
                        this.GammaScale = BitConverter.ToSingle(packedFloats, 32);
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
