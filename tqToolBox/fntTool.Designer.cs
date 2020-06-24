namespace tqToolBox
{
    partial class fntTool
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbox_exportpath = new System.Windows.Forms.TextBox();
            this.txtbox_name = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_export = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(40, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "导出路径";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(43, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "文件名";
            // 
            // txtbox_exportpath
            // 
            this.txtbox_exportpath.AllowDrop = true;
            this.txtbox_exportpath.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtbox_exportpath.Location = new System.Drawing.Point(118, 25);
            this.txtbox_exportpath.Multiline = true;
            this.txtbox_exportpath.Name = "txtbox_exportpath";
            this.txtbox_exportpath.Size = new System.Drawing.Size(655, 21);
            this.txtbox_exportpath.TabIndex = 2;
            this.txtbox_exportpath.WordWrap = false;
            // 
            // txtbox_name
            // 
            this.txtbox_name.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtbox_name.Location = new System.Drawing.Point(118, 62);
            this.txtbox_name.Multiline = true;
            this.txtbox_name.Name = "txtbox_name";
            this.txtbox_name.Size = new System.Drawing.Size(521, 21);
            this.txtbox_name.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(779, 24);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "---";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_export
            // 
            this.btn_export.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_export.Location = new System.Drawing.Point(676, 60);
            this.btn_export.Margin = new System.Windows.Forms.Padding(0);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(74, 26);
            this.btn_export.TabIndex = 5;
            this.btn_export.Text = "导出";
            this.btn_export.UseVisualStyleBackColor = true;
            // 
            // fntTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 535);
            this.Controls.Add(this.btn_export);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtbox_name);
            this.Controls.Add(this.txtbox_exportpath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "fntTool";
            this.Text = "fntTool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbox_exportpath;
        private System.Windows.Forms.TextBox txtbox_name;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_export;
    }
}