namespace tqToolBox
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_fnt = new System.Windows.Forms.Button();
            this.btn_excelToJson = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btn_fnt
            // 
            this.btn_fnt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_fnt.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_fnt.Location = new System.Drawing.Point(9, 9);
            this.btn_fnt.Name = "btn_fnt";
            this.btn_fnt.Size = new System.Drawing.Size(230, 140);
            this.btn_fnt.TabIndex = 0;
            this.btn_fnt.Text = "fnt字体导出";
            this.btn_fnt.UseVisualStyleBackColor = true;
            this.btn_fnt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnClickHandler);
            // 
            // btn_excelToJson
            // 
            this.btn_excelToJson.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_excelToJson.Location = new System.Drawing.Point(254, 8);
            this.btn_excelToJson.Name = "btn_excelToJson";
            this.btn_excelToJson.Size = new System.Drawing.Size(230, 140);
            this.btn_excelToJson.TabIndex = 1;
            this.btn_excelToJson.Text = "ExcelToJson";
            this.btn_excelToJson.UseVisualStyleBackColor = true;
            this.btn_excelToJson.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnClickHandler);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(497, 156);
            this.Controls.Add(this.btn_excelToJson);
            this.Controls.Add(this.btn_fnt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_fnt;
        private System.Windows.Forms.Button btn_excelToJson;
        private System.Windows.Forms.Timer timer1;
    }
}

