using System;
using System.Collections.Generic;
using System.Xml;

namespace FocusIncrement.Helicon
{
    internal class Retouching
    {
        public List<Deformation> Deformations { get; private set; }
        public string RetouchingSteps { get; private set; }

        public Retouching(XmlReader reader)
        {
            this.Deformations = new List<Deformation>();

            while (reader.EOF == false)
            {
                if (reader.IsStartElement())
                {
                    if (reader.IsStartElement(Constant.Helicon.Element.Deformation))
                    {
                        this.Deformations.Add(new Deformation(reader.ReadSubtree()));
                    }
                    else if (reader.IsStartElement(Constant.Helicon.Element.Deformations) ||
                             reader.IsStartElement(Constant.Helicon.Element.Retouching))
                    {
                        reader.Read();
                    }
                    else if (reader.IsStartElement(Constant.Helicon.Element.RetouchingSteps))
                    {
                        this.RetouchingSteps = reader.ReadElementContentAsString();
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
