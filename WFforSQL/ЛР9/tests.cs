using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WFforSQL
{
    public partial class tests : Form
    {
        SqlDataAdapter dataAdapter = null;
        public tests()
        {
            InitializeComponent();
        }

        private void answers_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testing_workersDataSet.View_test". При необходимости она может быть перемещена или удалена.
            this.view_testTableAdapter.Fill(this.testing_workersDataSet.View_test);
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox3.SelectionLength = 0;
            if (comboBox3.SelectedIndex >= 0)
                UpdateView();
        }

        private void UpdateView()
        {
            dataAdapter = new SqlDataAdapter("SELECT [Создатель],[Тестируемая должность],[Необходимый_процент_выполнения],[Максимальное_время_выполнения],[К. должности] as [К_ должности],[Н. испытания] as [Н_ испытания],[Н. испытателя] as [Н_ испытателя] FROM [View_test] WHERE [К. должности] = '" + comboBox2.SelectedValue + "' and [Н. испытателя] = '" + comboBox3.SelectedValue + "'", Program.MainForm.connect);
            try
            {
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
            catch
            {
                return;
            }
        }
        private void UpdateView1()
        {
            dataAdapter = new SqlDataAdapter("SELECT [Создатель],[Тестируемая должность],[Необходимый_процент_выполнения],[Максимальное_время_выполнения],[К. должности] as [К_ должности],[Н. испытания] as [Н_ испытания],[Н. испытателя] as [Н_ испытателя] FROM [View_test] ", Program.MainForm.connect);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.SelectionLength = 0;
            if (comboBox2.SelectedIndex >= 0)
                UpdateView();
        }

        private void вернутьсяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.MainForm.Activate();
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult g;
            g = new tesAdd(null, null, null, null).ShowDialog();
            this.view_testTableAdapter.Fill(this.testing_workersDataSet.View_test);
            if (dataAdapter != null) UpdateView1();
        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string f = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            string ff = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            string n = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            string nn = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            DialogResult g = new tesAdd(f, ff, n, nn).ShowDialog();
            this.view_testTableAdapter.Fill(this.testing_workersDataSet.View_test);
            if (dataAdapter != null) UpdateView1();
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string s = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            if (MessageBox.Show("Удалить текущую запись с ID " + s + "?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                string sqlExpression = "DELETE FROM Испытания WHERE Номер = " + s;
                SqlCommand command = new SqlCommand(sqlExpression, Program.MainForm.connect);
                int number = command.ExecuteNonQuery();
            }
            this.view_testTableAdapter.Fill(this.testing_workersDataSet.View_test);

            if (dataAdapter != null) UpdateView1();
        }
    }
}
