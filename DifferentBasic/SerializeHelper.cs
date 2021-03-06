using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace DifferentBasic
{
    public class SerializeHelper
    {
        #region Serialize / Deserialize

        public static string SerializeIntoXML(Object YourClassObject)
        {
            XmlDocument xmlDoc = new XmlDocument();         
            XmlSerializer xmlSerializer = new XmlSerializer(YourClassObject.GetType());

            using (TextWriter xmlStream = new StreamWriter(@"C:\tmp\Basic.xml"))
            {
                xmlSerializer.Serialize(xmlStream, YourClassObject);
                return xmlDoc.InnerXml;
            }
        }

        public static Object DeserializeIntoXML(string XMLString, Object YourClassObject)
        {
            XmlSerializer oXmlSerializer = new XmlSerializer(YourClassObject.GetType());
            //The StringReader will be the stream holder for the existing XML file 
            YourClassObject = oXmlSerializer.Deserialize(new StringReader(XMLString));
            //initially deserialized, the data is represented by an object without a defined type 
            return YourClassObject;
        }

        #endregion}
    }
}