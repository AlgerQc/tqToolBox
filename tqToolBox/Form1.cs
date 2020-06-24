using System;
using System.Reflection;
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
            //string formClass = "tqToolBox.fntTool";
            //GenerateForm(formClass, tabControl1);
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

        /// <summary>
        /// 通用按钮点击选项卡 在选项卡上显示对应的窗体
        /// </summary>
        private void btnX_Click(object sender, EventArgs e)
        {
            string formClass = ((TabControl)sender).SelectedTab.Tag.ToString();
            GenerateForm(formClass, sender);
        }

        private void btnClickHandler(object serder,EventArgs e)
        {
            Button btn = (Button)serder;
            if (btn == btn_fnt)
            {
                Form myform = new fntTool();
                myform.ShowDialog();//对话框模式 不能再操作父窗口
            }
        }

    }
}
