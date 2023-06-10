
using System;

namespace UpdateXML
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl_excel = new System.Windows.Forms.Label();
            this.lbl_xml = new System.Windows.Forms.Label();
            this.txt_excel = new System.Windows.Forms.TextBox();
            this.txt_xml = new System.Windows.Forms.TextBox();
            this.btn_exel = new System.Windows.Forms.Button();
            this.btn_xml = new System.Windows.Forms.Button();
            this.btn_export = new System.Windows.Forms.Button();
            this.file_excel = new System.Windows.Forms.OpenFileDialog();
            this.file_xml = new System.Windows.Forms.OpenFileDialog();
            this.pbExport = new System.Windows.Forms.ProgressBar();
            this.lbl_progress = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_excel
            // 
            this.lbl_excel.AutoSize = true;
            this.lbl_excel.BackColor = System.Drawing.Color.Transparent;
            this.lbl_excel.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_excel.Location = new System.Drawing.Point(116, 157);
            this.lbl_excel.Name = "lbl_excel";
            this.lbl_excel.Size = new System.Drawing.Size(104, 18);
            this.lbl_excel.TabIndex = 0;
            this.lbl_excel.Text = "Select Excel File";
            // 
            // lbl_xml
            // 
            this.lbl_xml.AutoSize = true;
            this.lbl_xml.BackColor = System.Drawing.Color.Transparent;
            this.lbl_xml.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_xml.Location = new System.Drawing.Point(116, 206);
            this.lbl_xml.Name = "lbl_xml";
            this.lbl_xml.Size = new System.Drawing.Size(103, 18);
            this.lbl_xml.TabIndex = 1;
            this.lbl_xml.Text = "Select XML File";
            // 
            // txt_excel
            // 
            this.txt_excel.Location = new System.Drawing.Point(225, 156);
            this.txt_excel.Name = "txt_excel";
            this.txt_excel.Size = new System.Drawing.Size(276, 20);
            this.txt_excel.TabIndex = 2;
            this.txt_excel.TextChanged += new System.EventHandler(this.Txt_excel_TextChanged);
            // 
            // txt_xml
            // 
            this.txt_xml.Location = new System.Drawing.Point(225, 206);
            this.txt_xml.Name = "txt_xml";
            this.txt_xml.Size = new System.Drawing.Size(276, 20);
            this.txt_xml.TabIndex = 3;
            this.txt_xml.TextChanged += new System.EventHandler(this.Txt_xml_TextChanged);
            // 
            // btn_exel
            // 
            this.btn_exel.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exel.Location = new System.Drawing.Point(500, 156);
            this.btn_exel.Name = "btn_exel";
            this.btn_exel.Size = new System.Drawing.Size(28, 21);
            this.btn_exel.TabIndex = 4;
            this.btn_exel.Text = "...";
            this.btn_exel.UseVisualStyleBackColor = true;
            this.btn_exel.Click += new System.EventHandler(this.Btn_exel_Click);
            // 
            // btn_xml
            // 
            this.btn_xml.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xml.Location = new System.Drawing.Point(500, 206);
            this.btn_xml.Name = "btn_xml";
            this.btn_xml.Size = new System.Drawing.Size(28, 21);
            this.btn_xml.TabIndex = 5;
            this.btn_xml.Text = "...";
            this.btn_xml.UseVisualStyleBackColor = true;
            this.btn_xml.Click += new System.EventHandler(this.Btn_xml_Click);
            // 
            // btn_export
            // 
            this.btn_export.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_export.BackgroundImage")));
            this.btn_export.Font = new System.Drawing.Font("Rockwell Extra Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_export.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_export.Location = new System.Drawing.Point(308, 282);
            this.btn_export.Margin = new System.Windows.Forms.Padding(1);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(112, 54);
            this.btn_export.TabIndex = 6;
            this.btn_export.Text = "Export Data";
            this.btn_export.UseVisualStyleBackColor = true;
            this.btn_export.Click += new System.EventHandler(this.Btn_export_Click);
            // 
            // pbExport
            // 
            this.pbExport.Location = new System.Drawing.Point(216, 377);
            this.pbExport.Name = "pbExport";
            this.pbExport.Size = new System.Drawing.Size(312, 23);
            this.pbExport.Step = 5;
            this.pbExport.TabIndex = 7;
            this.pbExport.Value = 5;
            this.pbExport.Visible = false;
            // 
            // lbl_progress
            // 
            this.lbl_progress.AutoSize = true;
            this.lbl_progress.BackColor = System.Drawing.Color.Transparent;
            this.lbl_progress.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_progress.Location = new System.Drawing.Point(149, 378);
            this.lbl_progress.Name = "lbl_progress";
            this.lbl_progress.Size = new System.Drawing.Size(61, 18);
            this.lbl_progress.TabIndex = 8;
            this.lbl_progress.Text = "Progress";
            this.lbl_progress.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(288, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(679, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_progress);
            this.Controls.Add(this.pbExport);
            this.Controls.Add(this.btn_export);
            this.Controls.Add(this.btn_xml);
            this.Controls.Add(this.btn_exel);
            this.Controls.Add(this.txt_xml);
            this.Controls.Add(this.txt_excel);
            this.Controls.Add(this.lbl_xml);
            this.Controls.Add(this.lbl_excel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(695, 489);
            this.MinimumSize = new System.Drawing.Size(695, 489);
            this.Name = "Form1";
            this.Text = "Update XML";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label lbl_excel;
        private System.Windows.Forms.Label lbl_xml;
        private System.Windows.Forms.TextBox txt_excel;
        private System.Windows.Forms.TextBox txt_xml;
        private System.Windows.Forms.Button btn_exel;
        private System.Windows.Forms.Button btn_xml;
        private System.Windows.Forms.Button btn_export;
        private System.Windows.Forms.OpenFileDialog file_excel;
        private System.Windows.Forms.OpenFileDialog file_xml;
        private System.Windows.Forms.ProgressBar pbExport;
        private System.Windows.Forms.Label lbl_progress;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

