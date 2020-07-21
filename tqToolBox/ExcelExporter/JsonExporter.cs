using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using tqToolBox.Generator;

namespace tqToolBox.ExcelExporter
{
    class JsonExporter
    {
        private ArrayList RowList = new ArrayList();

        public JsonExporter(LoadExcel excel)
        {
            for (int sheet_index = 0; sheet_index < excel.Sheets.Count; sheet_index++)
            {
                //得到Excel文件的表Sheet
                var sheet = excel.Sheets[sheet_index];
                var name = sheet.TableName;
                ArrayList arr_name = GetNameList(sheet);

                int col_count = Math.Min(sheet.Columns.Count, arr_name.Count);  //sheet.Columns.Count的值 往往会大于实际值
                int data_begin_line = PublicModel.excel_date_bagin_line;//数据开始位置
                for (int row = data_begin_line; row < sheet.Rows.Count; ++row)
                {
                    Dictionary<string, object> dictRow = ConvertRowToDict(sheet.Rows[row], col_count, arr_name, row);
                    RowList.Add(dictRow);
                }
            }
        }

        //将一行数据封装成一个字典
        private Dictionary<string, object> ConvertRowToDict(System.Data.DataRow sheetRow, int col_count, ArrayList namelist, int row)
        {
            Dictionary<string, object> rowData = new Dictionary<string, object>();
            for (int col = 0; col < col_count; ++col)//Excel的表Sheet的列数
            {
                var data = sheetRow[col];
                if (data.GetType() == typeof(System.DBNull))
                {
                    //当没有配置数据时  需要做处理
                }
                else
                {
                    if (data.GetType() == typeof(double))
                    {
                        double num = (double)data;
                        if ((int)num == num)//去掉整数字段的“.0”
                            data = (int)num;
                    }
                    rowData[(string)namelist[col]] = data;
                }
            }
            return rowData;
        }

        private ArrayList GetNameList(System.Data.DataTable sheet)
        {
            ArrayList namrList = new ArrayList();
            Console.WriteLine("读取键名");
            //可以考虑改成配表指定行
            Console.Write("Key Name : ");
            for (int col = 0; col < sheet.Columns.Count; ++col)
            {
                var data = sheet.Rows[1][col];
                var p_type = data.GetType();
                if (data.GetType() == typeof(System.DBNull))
                {
                    break;
                }
                namrList.Add(data);
                Console.Write(data + ", ");
            }
            Console.WriteLine();
            return namrList;
        }

        public ArrayList SheetsList
        {
            get
            {
                return this.RowList;
            }
        }
    }
}
