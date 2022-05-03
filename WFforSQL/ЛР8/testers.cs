using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFforSQL
{
    public partial class testers : Form
    {
        public testers()
        {
            InitializeComponent();
        }

        private void назадToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.MainForm.Activate();
        }
        private void testers_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testing_workersDataSet.Испытатели". При необходимости она может быть перемещена или удалена.
            this.испытателиTableAdapter.Fill(this.testing_workersDataSet.Испытатели);
        }
        private void удалитьВыбранноеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrencyManager CurMan = (CurrencyManager)dataGridView1.BindingContext[dataGridView1.DataSource];// в буферную таблицу записывается
                                                                                                             // текущая таблица из DataGrid
            if (CurMan.Count > 0) // если таблица не пустая
            {
                CurMan.RemoveAt(CurMan.Position);
                испытателиTableAdapter.Update(testing_workersDataSet);
            }
        }
        private void сохранитьИзмененияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = testing_workersDataSet.Должности;
                испытателиTableAdapter.Update(testing_workersDataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error");
            }
        }
    }
}
