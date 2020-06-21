using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tqToolBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int[] s = { 0, 0 };//用来记录窗体是否打开过
        public string[] formStr = { "tqToolBox.fntTool", "" };//用来存储窗体名称(项目名称(一般都是固定死的).窗体名称)

        private void Form1_Load(object sender, EventArgs e)
        {
            string formClass = "tqToolBox.fntTool";
            GenerateForm(formClass, tabControl1);
        }

        public void GenerateForm(string form,object sender)
        {
            //反射生成窗体
            Form fm = (Form)Assembly.GetExecutingAssembly().CreateInstance(form);
            //设置窗体没有边框，加入到选项卡中(可以在设计时就设置，这里是防止忘记设置)
            fm.FormBorderStyle = FormBorderStyle.None;
            fm.TopLevel = false;
            fm.Parent = ((TabControl)sender).SelectedTab;
            fm.ControlBox = false;
            fm.Dock = DockStyle.Fill;
            fm.Show();
            s[((TabControl)sender).SelectedIndex] = 1;
        }

        private void fntControl_SelectedIndexChanged(object sender,EventArgs e)
        {
            if(s[tabControl1.SelectedIndex] == 0) //只生成一次 防止多次生成
            {
                btnX_Click(sender, e);
            }
        }

        /// <summary>
        /// 通用按钮点击选项卡 在选项卡上显示对应的窗体
        /// </summary>
        private void btnX_Click(object sender, EventArgs e)
        {
            string formClass = ((TabControl)sender).SelectedTab.Tag.ToString();

            //string form = tabControl1.SelectedTab.Tag.ToString();

            GenerateForm(formClass, sender);

        }

    }
}
