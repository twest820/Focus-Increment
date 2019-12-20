using System;
using System.Xml;

namespace FocusIncrement
{
    internal class XmlParser
    {
        protected string ReadAttribute(XmlReader reader, string attributeName)
        {
            bool success = reader.MoveToAttribute(attributeName);
            if (success == false)
            {
                throw new XmlException(String.Format("Attribute '{0}' not found on element '{1}'.", attributeName, reader.Name));
            }
            return reader.Value;
        }
    }
}
