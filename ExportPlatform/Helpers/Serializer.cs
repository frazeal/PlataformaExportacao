using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace ExportPlatform.Helpers
{
    public static class Serializer
    {
        public static T Deserialize<T>(XmlReader reader) where T : class
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
            return (T)xmlSerializer.Deserialize(reader);
        }

        //public T Deserialize<T>(string input) where T : class
        //{
        //    XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));

        //    using (StringReader textReader = new StringReader(input))
        //    {
        //        return (T)xmlSerializer.Deserialize(textReader);
        //    }
        //}

        public static string Serialize<T>(T ObjectToSerialize)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(ObjectToSerialize.GetType());

            using (StringWriter textWriter = new StringWriter())
            {
                xmlSerializer.Serialize(textWriter, ObjectToSerialize);
                return textWriter.ToString();
            }
        }
    }
}
