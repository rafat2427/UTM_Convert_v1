using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace UpdateXML
{
	public partial class Form1 : Form
	{
		private Converter c1 = new Converter();

		string filename_excel, filename_xml;
		string ext_excel, ext_xml;

		public Form1()
		{
			InitializeComponent();
		}

		private void Btn_exel_Click(object sender, EventArgs e)
		{
			file_excel.Filter = "Excel Worksheets|*.xl*";
			if (file_excel.ShowDialog() == DialogResult.OK)
			{
				filename_excel = file_excel.FileName;
				txt_excel.Text = filename_excel;

				ext_excel = Path.GetExtension(filename_excel);
			}
		}

		private void Btn_exel_hover_out(object sender, EventArgs e)
		{
			btn_exel.BackColor = SystemColors.ButtonHighlight;
		}

		private void Btn_exel_hover_in(object sender, EventArgs e)
		{
			btn_exel.BackColor = SystemColors.ButtonFace;
		}


		private void Txt_excel_TextChanged(object sender, EventArgs e)
		{
			filename_excel = txt_excel.Text;
			ext_excel = Path.GetExtension(filename_excel);
		}

		private void Btn_xml_Click(object sender, EventArgs e)
		{
			file_xml.Filter = "XML|*.xml";
			if (file_xml.ShowDialog() == DialogResult.OK)
			{
				filename_xml = file_xml.FileName;
				txt_xml.Text = filename_xml;

				ext_xml = Path.GetExtension(filename_xml);
			}
		}

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void Txt_xml_TextChanged(object sender, EventArgs e)
		{
			filename_xml = txt_xml.Text;
			ext_xml = Path.GetExtension(filename_xml);
		}

		private void Btn_export_Click(object sender, EventArgs e)
		{
			bool check = true;

			if (!File.Exists(filename_excel) || !ext_excel.ToLower().Contains(".xl"))
			{
				MessageBox.Show("Select a valid Excel file", "Error");
				check = false;
			}
			if (!File.Exists(filename_xml) || !ext_xml.ToLower().Equals(".xml"))
			{
				MessageBox.Show("Select a valid XML file", "Error");
				check = false;
			}
			if (check)
			{
				pbExport.Visible = true; 
				lbl_progress.Visible = true;
				c1.UTMconvert(filename_excel, filename_xml, pbExport);
				//c1.UTMconvert(filename_excel, filename_xml);
			}
		}
	}
}
