namespace tqToolBox.Forms
{
    partial class ExcelToJson
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            this.txt_excelpath = new System.Windows.Forms.TextBox();
            this.txt_exportpath = new System.Windows.Forms.TextBox();
            this.btn_getfilepath = new System.Windows.Forms.Button();
            this.btn_getfilepath2 = new System.Windows.Forms.Button();
            this.btn_export = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            label1.Location = new System.Drawing.Point(12, 19);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(128, 16);
            label1.TabIndex = 0;
            label1.Text = "Excel所在文件夹";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            label2.Location = new System.Drawing.Point(68, 55);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(72, 16);
            label2.TabIndex = 1;
            label2.Text = "导出位置";
            // 
            // txt_excelpath
            // 
            this.txt_excelpath.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_excelpath.Location = new System.Drawing.Point(144, 16);
            this.txt_excelpath.Name = "txt_excelpath";
            this.txt_excelpath.Size = new System.Drawing.Size(329, 26);
            this.txt_excelpath.TabIndex = 2;
            // 
            // txt_exportpath
            // 
            this.txt_exportpath.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_exportpath.Location = new System.Drawing.Point(146, 49);
            this.txt_exportpath.Name = "txt_exportpath";
            this.txt_exportpath.Size = new System.Drawing.Size(327, 26);
            this.txt_exportpath.TabIndex = 3;
            // 
            // btn_getfilepath
            // 
            this.btn_getfilepath.Location = new System.Drawing.Point(486, 15);
            this.btn_getfilepath.Name = "btn_getfilepath";
            this.btn_getfilepath.Size = new System.Drawing.Size(31, 29);
            this.btn_getfilepath.TabIndex = 4;
            this.btn_getfilepath.Text = "....";
            this.btn_getfilepath.UseVisualStyleBackColor = true;
            this.btn_getfilepath.Click += new System.EventHandler(this.BtnSelectSiteClickHandler);
            // 
            // btn_getfilepath2
            // 
            this.btn_getfilepath2.Location = new System.Drawing.Point(486, 48);
            this.btn_getfilepath2.Name = "btn_getfilepath2";
            this.btn_getfilepath2.Size = new System.Drawing.Size(31, 26);
            this.btn_getfilepath2.TabIndex = 5;
            this.btn_getfilepath2.Text = "....";
            this.btn_getfilepath2.UseVisualStyleBackColor = true;
            this.btn_getfilepath2.Click += new System.EventHandler(this.BtnSelectSiteClickHandler);
            // 
            // btn_export
            // 
            this.btn_export.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_export.Location = new System.Drawing.Point(238, 216);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(75, 33);
            this.btn_export.TabIndex = 6;
            this.btn_export.Text = "导出";
            this.btn_export.UseVisualStyleBackColor = true;
            this.btn_export.Click += new System.EventHandler(this.btn_export_Click);
            // 
            // ExcelToJson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 270);
            this.Controls.Add(this.btn_export);
            this.Controls.Add(this.btn_getfilepath2);
            this.Controls.Add(this.btn_getfilepath);
            this.Controls.Add(this.txt_exportpath);
            this.Controls.Add(this.txt_excelpath);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ExcelToJson";
            this.Text = "ExcelToJson";
            this.Load += new System.EventHandler(this.ExcelToJson_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_excelpath;
        private System.Windows.Forms.TextBox txt_exportpath;
        private System.Windows.Forms.Button btn_getfilepath;
        private System.Windows.Forms.Button btn_getfilepath2;
        private System.Windows.Forms.Button btn_export;
    }
}