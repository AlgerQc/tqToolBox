using System;
using System.Collections;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using tqToolBox.ImageUtlcs;

namespace tqToolBox
{
    public partial class fntTool : Form
    {
        private static ArrayList fntFontList = new ArrayList();
        private static ArrayList filesList = new ArrayList();
        private static int select_index = 0;
        public fntTool()
        {
            InitializeComponent();
        }
        //导出按钮
        private void btn_export_Click(object sender, EventArgs e)
        {
            string str_path = txtbox_exportpath.Text;
            string str_fileName = txtbox_name.Text;

            if(lab_preview.Text == "字符重复")
            {
                MessageBox.Show("字符重复");
                return;
            }

            if (string.IsNullOrEmpty(str_path) || string.IsNullOrEmpty(str_fileName))
                MessageBox.Show("请填写必要信息");
            else
                ImageUtilcs.SaveFntFont(str_fileName, str_path); //保存信息
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

        //禁止用户编辑Columns的宽度
        private void ListColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;  //取消掉正在调整的事件
            // 把新宽度恢复到之前的宽度
            e.NewWidth = this.listView_image.Columns[e.ColumnIndex].Width;
        }

        private void init()
        {
            listView_image.Items.Clear();
            p_imglist.Images.Clear();//清空之前的图片
            GC.Collect();
            GC.WaitForPendingFinalizers();
            listView_image.LargeImageList = p_imglist;
            listView_image.SmallImageList = p_imglist;
            listView_image.StateImageList = p_imglist;
            fntFontList.Clear();
            filesList.Clear();
        }
        //更新预览合图
        private void UpdatePictureBox(ArrayList files, ArrayList fntFont)
        {
            lab_preview.Text = "合图预览";
            Bitmap bitmap = ImageUtilcs.CombinImage(files, fntFont); //获取合图
            Image img = Image.FromHbitmap(bitmap.GetHbitmap());
            pictureBox.Image = img;
            pictureBox.Show();
            pictureBox.Refresh();
        }

        private void ListViweDragDrop(object sender, DragEventArgs e)
        {
            init();
            try
            {
                p_imglist.ImageSize = new Size(40, 40);//设定图片预览大小
                listView_image.BeginUpdate();
                string[] files = e.Data.GetData(DataFormats.FileDrop, false) as string[];
                //遍历鼠标选择的文件
                foreach (string srcfile in files)
                {
                    if (File.Exists(srcfile))
                    {
                        Image image = Image.FromFile(srcfile);
                        p_imglist.Images.Add(image);

                        ListViewItem viewItem = new ListViewItem();
                        viewItem.ImageIndex = p_imglist.Images.Count - 1;//通过与imageList绑定，显示imageList中第i项图标  
                        string strExt = System.IO.Path.GetExtension(srcfile);//获取文件后缀
                        viewItem.SubItems.Add(strExt);//文件类型
                        viewItem.SubItems.Add(image.Width + "*" + image.Height);//文件宽高
                        string strFileName = System.IO.Path.GetFileName(srcfile);//获取文件名
                        viewItem.SubItems.Add(strFileName.Substring(0, 1));
                        listView_image.Items.Add(viewItem);
                        fntFontList.Add(strFileName.Substring(0, 1));
                        filesList.Add(srcfile);
                        image.Dispose();
                    }
                }
                listView_image.EndUpdate(); //结束数据处理，UI界面一次性绘制。
                if (arrListHaveEqualFont(fntFontList))
                    lab_preview.Text = "字符重复";
                else
                    UpdatePictureBox(filesList, fntFontList);

            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message, " Error ",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //list item选中事件
        private void ListViweItemSelectChangeHandler(object sender, EventArgs e)
        {
            if (listView_image.SelectedItems.Count == 0) return;
            textBox_font.Text = listView_image.SelectedItems[0].SubItems[3].Text;
            select_index = listView_image.SelectedItems[0].Index;
        }
        //输入完成事件
        private void TextBoxValidated(object sender, EventArgs e)
        {
            listView_image.Items[select_index].SubItems[3].Text = textBox_font.Text;
            fntFontList[select_index] = textBox_font.Text;
            if (arrListHaveEqualFont(fntFontList) == false)
                UpdatePictureBox(filesList, fntFontList);
            else
                lab_preview.Text = "字符重复";
        }
        //判断是否有导出相同的字体
        private bool arrListHaveEqualFont(ArrayList arrayList)
        {
            for (int j = 0; j < arrayList.Count; j++)
            {
                string str1 = arrayList[j].ToString();
                for (int i = j+1; i< arrayList.Count;i++)
                {
                    string str2 = arrayList[i].ToString();
                    if (String.Compare(str1, str2) == 0)
                        return true;
                }
            }
            return false;
        }
    }
}
