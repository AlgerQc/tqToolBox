using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace tqToolBox.Forms
{
    public partial class ExcelToJson : Form
    {
        public ExcelToJson()
        {
            InitializeComponent();
        }

        private void BtnSelectSiteClickHandler(object sender, EventArgs e)
        {
            FolderBrowserDialog path = new FolderBrowserDialog();
            path.ShowDialog();
            Button btn = (Button)sender;
            if(btn == btn_getfilepath)
            {
                txt_excelpath.Text = path.SelectedPath;
            }else if (btn == btn_getfilepath2)
            {
                txt_exportpath.Text = path.SelectedPath;
            }
        }

        private void btn_export_Click(object sender, EventArgs e)
        {
            //TODO  导出json
            if (string.IsNullOrEmpty(txt_excelpath.Text) || string.IsNullOrEmpty(txt_exportpath.Text))
            {
                MessageBox.Show("请填写必要的路径信息");
            }
            tqToolBox.ExcelExporter.ExportJson.Init(txt_excelpath.Text, txt_exportpath.Text);
        }

        private void ExcelToJson_Load(object sender, EventArgs e)
        {
            string path = System.Environment.CurrentDirectory;//获取程序所在目录
            txt_excelpath.Text = path + @"\Excel";
            txt_exportpath.Text = path + @"\Json";
        }
    }
}
