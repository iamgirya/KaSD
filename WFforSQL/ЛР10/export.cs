using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace WFforSQL
{
    public partial class export : Form
    {
        public export()
        {
            InitializeComponent();
        }

        public void ExportToExcel(DataTable table)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileStream Stream1 = new FileStream(saveFileDialog1.FileName, FileMode.Create);
                try
                {
                    StreamWriter StreamWriterStream1 = new StreamWriter(Stream1, Encoding.Unicode);

                    foreach (DataColumn Column in table.Columns)
                        StreamWriterStream1.Write(Column.Caption + "\t");

                    StreamWriterStream1.WriteLine();
                    foreach (DataRow Row in table.Rows)
                    {
                        foreach (object Entity in Row.ItemArray)
                        {
                            StreamWriterStream1.Write(Entity.ToString() + "\t");
                        }
                        StreamWriterStream1.WriteLine();
                    }
                    StreamWriterStream1.Flush();
                }
                catch
                {
                    MessageBox.Show("При передаче данных возникла ошибка!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Stream1.Close();
                //Process.Start(Stream1.Name);
            }
        }
        void ExportToHTML(DataTable table, string ThisTitle)
        {
            int i, j;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileStream Stream1 = new FileStream(saveFileDialog1.FileName, FileMode.Create);
                try
                {
                    StreamWriter StreamWriter1 = new StreamWriter(Stream1);

                    StreamWriter1.WriteLine("<html>");
                    StreamWriter1.WriteLine("<head>");
                    StreamWriter1.WriteLine("<meta content=\"text/html; charset=utf-8\" http-equiv=\"Content-Type\">");
                    StreamWriter1.WriteLine("<title>" + ThisTitle + "</title>");
                    StreamWriter1.WriteLine("</head>");
                    StreamWriter1.WriteLine("<body bgcolor=\"#888888\">");
                    StreamWriter1.WriteLine("<table align=\"center\" cols =0 cellspacing =0>");
                    StreamWriter1.WriteLine("<tr>");
                    StreamWriter1.WriteLine("</td>");
                    StreamWriter1.WriteLine("</tr>");
                    StreamWriter1.WriteLine("<tr>");
                    for (j = 0; j < table.Columns.Count; j++)
                    {
                        StreamWriter1.WriteLine("<td><font face=\"Verdana\"size=\"2\" color=\"#ffffff\"><p align=\"center\"><b>");
                        StreamWriter1.WriteLine("" + table.Columns[j].ColumnName);
                        StreamWriter1.WriteLine("</b></font></td>");
                    }
                    StreamWriter1.WriteLine("</tr>");
                    for (i = 0; i < table.Rows.Count; i++)
                    {
                        if (i % 2 == 0)
                        {
                            StreamWriter1.WriteLine("<tr bgcolor=\"#888888\">");
                            for (j = 0; j < table.Columns.Count; j++)
                            {
                                StreamWriter1.WriteLine("<td><font face=\"Verdana\"size=\"2\" color=\"#000000\"><p align=\"center\">");
                                StreamWriter1.WriteLine("" + table.Rows[i][j]);
                                StreamWriter1.WriteLine("</font></td>");
                            }
                            StreamWriter1.WriteLine("</tr>");
                        }
                        else
                        {
                            StreamWriter1.WriteLine("<tr>");
                            for (j = 0; j < table.Columns.Count; j++)
                            {
                                StreamWriter1.WriteLine("<td><font face=\"Verdana\"size=\"2\" color=\"#ffffff\"><p align=\"center\">");
                                StreamWriter1.WriteLine("" + table.Rows[i][j]);
                                StreamWriter1.WriteLine("</font></td>");
                            }
                            StreamWriter1.WriteLine("</tr>");
                        }
                    }
                    StreamWriter1.WriteLine("</table></center></body></html>");
                    StreamWriter1.Flush();
                }
                catch
                {
                    MessageBox.Show("При передаче данных возникла ошибка!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Stream1.Close();
                //Process.Start(Stream1.Name);
            }
        }

        private void назадToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.MainForm.Activate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (excel.Checked == true)
            {
                saveFileDialog1.DefaultExt = "xls";
                saveFileDialog1.Filter = "Excel files(*.xls)|*.xls";
                saveFileDialog1.Title = "Экспорт: Excel";
                if (att.Checked == true)
                {
                    отчёт_о_тестированииTableAdapter1.Fill(testing_workersDataSet1.Отчёт_о_тестировании);
                    ExportToExcel(testing_workersDataSet1.Отчёт_о_тестировании);
                    saveFileDialog1.FileName = "";
                }
                if (avg.Checked == true)
                {
                    отчёт_о_средней_успеваемостиTableAdapter1.Fill(testing_workersDataSet1.Отчёт_о_средней_успеваемости);
                    ExportToExcel(testing_workersDataSet1.Отчёт_о_средней_успеваемости);
                    saveFileDialog1.FileName = "";
                }
            }
            if (html.Checked == true)
            {
                saveFileDialog1.DefaultExt = "html";
                saveFileDialog1.Filter = "EHTML files(*.html)|*.html";
                saveFileDialog1.Title = "Экспорт: HTML";
                if (att.Checked == true)
                {
                    отчёт_о_тестированииTableAdapter1.Fill(testing_workersDataSet1.Отчёт_о_тестировании);
                    ExportToHTML(testing_workersDataSet1.Отчёт_о_тестировании, att.Text);
                    saveFileDialog1.FileName = "";
                }
                if (avg.Checked == true)
                {
                    отчёт_о_средней_успеваемостиTableAdapter1.Fill(testing_workersDataSet1.Отчёт_о_средней_успеваемости);
                    ExportToHTML(testing_workersDataSet1.Отчёт_о_средней_успеваемости, avg.Text);
                    saveFileDialog1.FileName = "";
                }
            }
        }
    }
}
