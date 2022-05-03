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
    public partial class questions : Form
    {
        SqlDataAdapter dataAdapter = null;
        public questions()
        {
            InitializeComponent();
        }

        private void answers_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testing_workersDataSet.View_вопр". При необходимости она может быть перемещена или удалена.
            this.view_вопрTableAdapter.Fill(this.testing_workersDataSet.View_вопр);
        }
        private void UpdateView()
        {
            dataAdapter = new SqlDataAdapter("SELECT [Тестируемая должность],[Содержание],[Ответ],[Сложность],[К. должности] as [К_ должности],[Н. испытания] as [Н_ испытания] FROM [View_вопр] WHERE [Н. испытания] = '" + comboBox2.SelectedValue + "'", Program.MainForm.connect);
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
            dataAdapter = new SqlDataAdapter("SELECT [Тестируемая должность],[Содержание],[Ответ],[Сложность],[К. должности] as [К_ должности],[Н. испытания] as [Н_ испытания] FROM [View_вопр] ", Program.MainForm.connect);
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
            g = new quesAdd(null, null, null, null).ShowDialog();
            this.view_вопрTableAdapter.Fill(this.testing_workersDataSet.View_вопр);
            if (dataAdapter != null) UpdateView1();
        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string f = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            string ff = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            string fff = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            string n = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            DialogResult g = new quesAdd(f, ff, fff, n).ShowDialog();
            this.view_вопрTableAdapter.Fill(this.testing_workersDataSet.View_вопр);
            if (dataAdapter != null) UpdateView1();
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string s = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            if (MessageBox.Show("Удалить текущую?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                string sqlExpression = "DELETE FROM Вопросы WHERE Содержание = '" + s + "'";
                SqlCommand command = new SqlCommand(sqlExpression, Program.MainForm.connect);
                int number = command.ExecuteNonQuery();
            }
            this.view_вопрTableAdapter.Fill(this.testing_workersDataSet.View_вопр);

            if (dataAdapter != null) UpdateView1();
        }
    }
}
