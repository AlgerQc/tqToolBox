using System;
using System.IO;
using System.Text;
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

        /// <summary>
        /// 保存文件
        /// </summary>
        public static void SaveJsonToFile(string filePath, string fileName, string data)
        {
            //如果不存在就创建file文件夹
            try
            {
                if (!Directory.Exists(filePath))//如果不存在就创建file文件夹　　             　　              
                    Directory.CreateDirectory(filePath);//创建该文件夹　　            
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return;
            }
            FileStream fileStream = new FileStream(filePath + fileName, FileMode.Create, FileAccess.Write);
            TextWriter writer = new StreamWriter(fileStream, Encoding.UTF8);
            writer.Write(data);
            writer.Flush();//清空缓冲区
            writer.Close();//关闭流
            fileStream.Close();
        }
    }
}
