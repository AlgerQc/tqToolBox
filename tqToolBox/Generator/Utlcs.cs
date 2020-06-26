using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace tqToolBox.Generator
{
    class Utlcs
    {
        public static T Clone<T>(T obj)
        {
            T ret = default(T);
            if (obj != null)
            {
                XmlSerializer cloner = new XmlSerializer(typeof(T));
                MemoryStream stream = new MemoryStream();
                cloner.Serialize(stream, obj);
                stream.Seek(0, SeekOrigin.Begin);
                ret = (T)cloner.Deserialize(stream);
            }
            return ret;
        }
    }
}
