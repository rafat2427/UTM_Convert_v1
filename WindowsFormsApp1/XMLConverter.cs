using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace UpdateXML
{
    public class Converter
    {
        internal void UTMconvert(string fname_excel, string xml, ProgressBar pb_export)
        {

            XElement root = XElement.Load(xml);

            Microsoft.Office.Interop.Excel.Application app_excel = new Microsoft.Office.Interop.Excel.Application();
            Workbook wb_xl = app_excel.Workbooks.Open(fname_excel); ;
            _Worksheet ws_xl = wb_xl.Sheets[1];
            Range range_xl = ws_xl.UsedRange;

            int row_count = range_xl.Rows.Count;
            int colm_count = range_xl.Columns.Count;

            int name_col = 0;
            int utm_col = 0;


            //find the hedaing locations
            string cell_val;
            for (int j = 1; j <= colm_count; j++)
            {
                if (range_xl.Cells[1, j] != null && range_xl.Cells[1, j].Value2 != null)
                {
                    cell_val = range_xl.Cells[1, j].Value2.ToString();

                    if (name_col != 0 && utm_col != 0)
                        continue;

                    //Find the location of Name Header
                    if (cell_val == "Unit Name")
                    {
                        name_col = j;
                    }

                    //Find the location of MGRS Header
                    if (cell_val == "UTM MGRS")
                    {
                        utm_col = j;
                    }
                }
            }

            //Pass the value of name and mgrs to xml functionin each row iteration
            string name_val = null;
            string mgrs_val = null;
            for (int i = 2; i <= row_count; i++)
            {
                if (range_xl.Cells[i, name_col] != null && range_xl.Cells[i, name_col].Value2 != null)
                {
                    name_val = range_xl.Cells[i, name_col].Value2.ToString();
                }

                if (range_xl.Cells[i, utm_col] != null && range_xl.Cells[i, utm_col].Value2 != null)
                {
                    mgrs_val = range_xl.Cells[i, utm_col].Value2.ToString();
                }
                if (name_val != null && mgrs_val != null)
                    Updt_xml(xml, root, name_val, mgrs_val);


                pb_export.Value = i * 100 / row_count;

                name_val = null;
                mgrs_val = null;
            }

            //cleanup
            GC.Collect();
            GC.WaitForPendingFinalizers();

            //release com objects to fully kill excel process from running in the background
            Marshal.ReleaseComObject(range_xl);
            Marshal.ReleaseComObject(ws_xl);

            //close and release
            wb_xl.Close();
            Marshal.ReleaseComObject(wb_xl);

            //quit and release
            app_excel.Quit();
            Marshal.ReleaseComObject(app_excel);

            if (pb_export.Value == 100)
            {
                MessageBox.Show("XML File Updated", "Done");
            }
        }

        private void Updt_xml(string xml, XElement root, string name, string mgrs)
        {
            IEnumerable<XElement> elm_name =
                from el in root.Descendants("unit")
                where (string)el.Attribute("name") == name
                select el;
            foreach (XElement el in elm_name)
            {
                IEnumerable<XElement> desc_name =
                    from desc in el.Descendants("position")
                    select desc;
                foreach (XElement desc in desc_name)
                {
                    desc.Value = mgrs;
                }
            }
            Write_xml(xml, root);
        }

        private void Write_xml(string xml, XElement root)
        {
            XmlTextWriter textWriter = new XmlTextWriter(xml, null);
            root.Save(textWriter);

            // close writer
            textWriter.Close();
        }
    }
}
