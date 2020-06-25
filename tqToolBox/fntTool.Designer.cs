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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            this.txtbox_exportpath = new System.Windows.Forms.TextBox();
            this.txtbox_name = new System.Windows.Forms.TextBox();
            this.btn_selectsite = new System.Windows.Forms.Button();
            this.btn_export = new System.Windows.Forms.Button();
            this.imglist = new System.Windows.Forms.ImageList(this.components);
            this.listView1 = new System.Windows.Forms.ListView();
            this.listhead_0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            label1.Location = new System.Drawing.Point(14, 28);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(72, 16);
            label1.TabIndex = 0;
            label1.Text = "导出路径";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            label2.Location = new System.Drawing.Point(30, 65);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(56, 16);
            label2.TabIndex = 1;
            label2.Text = "文件名";
            // 
            // txtbox_exportpath
            // 
            this.txtbox_exportpath.AllowDrop = true;
            this.txtbox_exportpath.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtbox_exportpath.Location = new System.Drawing.Point(90, 25);
            this.txtbox_exportpath.Multiline = true;
            this.txtbox_exportpath.Name = "txtbox_exportpath";
            this.txtbox_exportpath.Size = new System.Drawing.Size(479, 21);
            this.txtbox_exportpath.TabIndex = 2;
            this.txtbox_exportpath.WordWrap = false;
            this.txtbox_exportpath.DragDrop += new System.Windows.Forms.DragEventHandler(this.TxtboxExportPathSiteDragDrop);
            this.txtbox_exportpath.DragEnter += new System.Windows.Forms.DragEventHandler(this.FileDragEnter);
            // 
            // txtbox_name
            // 
            this.txtbox_name.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtbox_name.Location = new System.Drawing.Point(90, 62);
            this.txtbox_name.Multiline = true;
            this.txtbox_name.Name = "txtbox_name";
            this.txtbox_name.Size = new System.Drawing.Size(277, 21);
            this.txtbox_name.TabIndex = 3;
            // 
            // btn_selectsite
            // 
            this.btn_selectsite.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_selectsite.Location = new System.Drawing.Point(583, 25);
            this.btn_selectsite.Margin = new System.Windows.Forms.Padding(0);
            this.btn_selectsite.Name = "btn_selectsite";
            this.btn_selectsite.Size = new System.Drawing.Size(45, 23);
            this.btn_selectsite.TabIndex = 4;
            this.btn_selectsite.Text = "---";
            this.btn_selectsite.UseVisualStyleBackColor = true;
            this.btn_selectsite.Click += new System.EventHandler(this.BtnSelectSiteClickHandler);
            // 
            // btn_export
            // 
            this.btn_export.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_export.Location = new System.Drawing.Point(495, 55);
            this.btn_export.Margin = new System.Windows.Forms.Padding(0);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(74, 26);
            this.btn_export.TabIndex = 5;
            this.btn_export.Text = "导出";
            this.btn_export.UseVisualStyleBackColor = true;
            this.btn_export.Click += new System.EventHandler(this.btn_export_Click);
            // 
            // imglist
            // 
            this.imglist.ColorDepth = System.Windows.Forms.ColorDepth.Depth4Bit;
            this.imglist.ImageSize = new System.Drawing.Size(16, 16);
            this.imglist.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // listView1
            // 
            this.listView1.AllowDrop = true;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.listhead_0});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(17, 103);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(378, 317);
            this.listView1.SmallImageList = this.imglist;
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // listhead_0
            // 
            this.listhead_0.Text = "预览";
            // 
            // fntTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 432);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btn_export);
            this.Controls.Add(this.btn_selectsite);
            this.Controls.Add(this.txtbox_name);
            this.Controls.Add(this.txtbox_exportpath);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Name = "fntTool";
            this.Text = "fntTool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtbox_exportpath;
        private System.Windows.Forms.TextBox txtbox_name;
        private System.Windows.Forms.Button btn_selectsite;
        private System.Windows.Forms.Button btn_export;
        private System.Windows.Forms.ImageList imglist;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader listhead_0;
    }
}