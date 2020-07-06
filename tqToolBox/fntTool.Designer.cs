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
            System.Windows.Forms.Label label_font;
            this.txtbox_exportpath = new System.Windows.Forms.TextBox();
            this.txtbox_name = new System.Windows.Forms.TextBox();
            this.btn_selectsite = new System.Windows.Forms.Button();
            this.btn_export = new System.Windows.Forms.Button();
            this.p_imglist = new System.Windows.Forms.ImageList(this.components);
            this.listView_image = new System.Windows.Forms.ListView();
            this.listhead_1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listhead_2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listhead_3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listhead_4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.textBox_font = new System.Windows.Forms.TextBox();
            this.lab_preview = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label_font = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
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
            // label_font
            // 
            label_font.AutoSize = true;
            label_font.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            label_font.Location = new System.Drawing.Point(483, 370);
            label_font.Name = "label_font";
            label_font.Size = new System.Drawing.Size(72, 16);
            label_font.TabIndex = 9;
            label_font.Text = "导出字符";
            // 
            // txtbox_exportpath
            // 
            this.txtbox_exportpath.AllowDrop = true;
            this.txtbox_exportpath.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtbox_exportpath.Location = new System.Drawing.Point(90, 25);
            this.txtbox_exportpath.Multiline = true;
            this.txtbox_exportpath.Name = "txtbox_exportpath";
            this.txtbox_exportpath.Size = new System.Drawing.Size(479, 25);
            this.txtbox_exportpath.TabIndex = 2;
            this.txtbox_exportpath.WordWrap = false;
            this.txtbox_exportpath.DragDrop += new System.Windows.Forms.DragEventHandler(this.TxtboxExportPathSiteDragDrop);
            this.txtbox_exportpath.DragEnter += new System.Windows.Forms.DragEventHandler(this.FileDragEnter);
            // 
            // txtbox_name
            // 
            this.txtbox_name.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtbox_name.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtbox_name.Location = new System.Drawing.Point(90, 62);
            this.txtbox_name.Multiline = true;
            this.txtbox_name.Name = "txtbox_name";
            this.txtbox_name.Size = new System.Drawing.Size(277, 25);
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
            // p_imglist
            // 
            this.p_imglist.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.p_imglist.ImageSize = new System.Drawing.Size(16, 16);
            this.p_imglist.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // listView_image
            // 
            this.listView_image.AllowDrop = true;
            this.listView_image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView_image.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.listhead_1,
            this.listhead_2,
            this.listhead_3,
            this.listhead_4});
            this.listView_image.FullRowSelect = true;
            this.listView_image.HideSelection = false;
            this.listView_image.Location = new System.Drawing.Point(17, 103);
            this.listView_image.MultiSelect = false;
            this.listView_image.Name = "listView_image";
            this.listView_image.Size = new System.Drawing.Size(378, 317);
            this.listView_image.SmallImageList = this.p_imglist;
            this.listView_image.TabIndex = 6;
            this.listView_image.UseCompatibleStateImageBehavior = false;
            this.listView_image.View = System.Windows.Forms.View.Details;
            this.listView_image.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.ListColumnWidthChanging);
            this.listView_image.SelectedIndexChanged += new System.EventHandler(this.ListViweItemSelectChangeHandler);
            this.listView_image.DragDrop += new System.Windows.Forms.DragEventHandler(this.ListViweDragDrop);
            this.listView_image.DragEnter += new System.Windows.Forms.DragEventHandler(this.FileDragEnter);
            // 
            // listhead_1
            // 
            this.listhead_1.Text = "原图预览";
            this.listhead_1.Width = 90;
            // 
            // listhead_2
            // 
            this.listhead_2.Text = "类型";
            this.listhead_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // listhead_3
            // 
            this.listhead_3.Text = "大小";
            this.listhead_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // listhead_4
            // 
            this.listhead_4.Text = "字符(默认第一个字符)";
            this.listhead_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.listhead_4.Width = 150;
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(428, 135);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(200, 200);
            this.pictureBox.TabIndex = 7;
            this.pictureBox.TabStop = false;
            // 
            // textBox_font
            // 
            this.textBox_font.Location = new System.Drawing.Point(469, 395);
            this.textBox_font.MaxLength = 1;
            this.textBox_font.Multiline = true;
            this.textBox_font.Name = "textBox_font";
            this.textBox_font.Size = new System.Drawing.Size(100, 25);
            this.textBox_font.TabIndex = 8;
            this.textBox_font.Validated += new System.EventHandler(this.TextBoxValidated);
            // 
            // lab_preview
            // 
            this.lab_preview.AutoSize = true;
            this.lab_preview.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_preview.Location = new System.Drawing.Point(483, 103);
            this.lab_preview.Name = "lab_preview";
            this.lab_preview.Size = new System.Drawing.Size(72, 16);
            this.lab_preview.TabIndex = 10;
            this.lab_preview.Text = "合图预览";
            // 
            // fntTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 432);
            this.Controls.Add(this.lab_preview);
            this.Controls.Add(label_font);
            this.Controls.Add(this.textBox_font);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.listView_image);
            this.Controls.Add(this.btn_export);
            this.Controls.Add(this.btn_selectsite);
            this.Controls.Add(this.txtbox_name);
            this.Controls.Add(this.txtbox_exportpath);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "fntTool";
            this.Text = "fntTool";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PanelCloseHandler);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtbox_exportpath;
        private System.Windows.Forms.TextBox txtbox_name;
        private System.Windows.Forms.Button btn_selectsite;
        private System.Windows.Forms.Button btn_export;
        private System.Windows.Forms.ImageList p_imglist;
        private System.Windows.Forms.ListView listView_image;
        private System.Windows.Forms.ColumnHeader listhead_1;
        private System.Windows.Forms.ColumnHeader listhead_2;
        private System.Windows.Forms.ColumnHeader listhead_3;
        private System.Windows.Forms.ColumnHeader listhead_4;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TextBox textBox_font;
        private System.Windows.Forms.Label lab_preview;
    }
}