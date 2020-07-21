using System;
using System.Data;
using System.IO;
using ExcelDataReader;

namespace tqToolBox.ExcelExporter
{
    class LoadExcel
    {
        private DataSet mData;
        public LoadExcel(string filePath)
        {
            using (FileStream stream = File.Open(filePath, FileMode.Open, FileAccess.Read))
            {
                //得到文件reader（需要NuGet包ExcelDataReader）
                //CreateReader会自动检测文件类型
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    //通过reader得到数据（需要NuGet包ExcelDataReader.DataSet ）
                    var result = reader.AsDataSet();
                    this.mData = result;
                }
            }
            if (this.Sheets.Count < 1)
            {
                Console.WriteLine("Excel file is empty: " + filePath);
            }
        }

        public DataTableCollection Sheets
        {
            get
            {
                return this.mData.Tables;
            }
        }

    }
}
