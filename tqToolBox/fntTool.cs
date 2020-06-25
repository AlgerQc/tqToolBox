using System;
using System.Windows.Forms;

namespace tqToolBox
{
    public partial class fntTool : Form
    {
        public fntTool()
        {
            InitializeComponent();
        }
        //导出按钮
        private void btn_export_Click(object sender, EventArgs e)
        {
            string str_path = txtbox_exportpath.Text;
            string str_fileName = txtbox_name.Text;
            if (string.IsNullOrEmpty(str_path) || string.IsNullOrEmpty(str_fileName))
            {
                MessageBox.Show("请填写必要信息");
            }
            else
            {
                //TODO 保存信息

            }
        }

        private void FileDragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;  //表明是所有类型的数据，比如文件路径
            else
                e.Effect = DragDropEffects.None;
        }

        private void TxtboxExportPathSiteDragDrop(object sender, DragEventArgs e)
        {
            string path = ((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();//获得路径
            txtbox_exportpath.Text = path;
        }
        //选择保存文件夹
        private void BtnSelectSiteClickHandler(object sender, EventArgs e)
        {
            FolderBrowserDialog path = new FolderBrowserDialog();
            path.ShowDialog();
            txtbox_exportpath.Text = path.SelectedPath;
        }
    }
}
