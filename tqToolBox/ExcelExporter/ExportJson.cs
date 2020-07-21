using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tqToolBox.ExcelExporter
{
    class ExportJson
    {
        private static string str_excel_path = "";
        private static string str_json_path = "";
        private static Dictionary<string, object> dict = new Dictionary<string, object>();
        public static void Init(string excel_path,string json_path)
        {
            str_excel_path = excel_path;
            str_json_path = json_path;
            dict.Clear();
            BeginExportJson();
        }

        private static void BeginExportJson()
        {
            System.IO.DirectoryInfo folder = new System.IO.DirectoryInfo(str_excel_path);
            int index = 0; //TODO
            foreach (System.IO.FileInfo file in folder.GetFiles("*.xlsx"))  //获取夹下所有的xlsx文件  TODO 此处可改造
            {
                //防止读取到excel自身产生的临时文件
                bool isTrue = false;
                foreach (System.Text.RegularExpressions.Match match in System.Text.RegularExpressions.Regex.Matches(file.FullName, @"[~$%*]"))
                {
                    isTrue = true;
                }
                if (isTrue) continue;
                //加载excel文件
                LoadExcel excel = new LoadExcel(file.FullName);
                //将excel数据转Json
                JsonExporter json = new JsonExporter(excel);

                //string jsonStr = json.GetJsonString();  //不能提前序列化  否则会吧'\'当作纯字符
                index++;  //TODO
                dict["excel_" + index] = json.SheetsList;  //TODO  暂时替代方案
                //Console.WriteLine(file.FullName);
            }
            //全部读取完毕   开始写入本地文件
            Console.WriteLine("数据获取完毕，开始导出json");
        }

    }
}
