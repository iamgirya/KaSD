using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFforSQL
{
    public partial class quesAdd : Form
    {
        string num1;
        string num2;
        string num3;
        string id1;

        public quesAdd(string sod, string otv, string sloj, string idis)
        {
            InitializeComponent();
            num1 = sod;
            num2 = otv;
            num3 = sloj;
            id1 = idis;
            try
            {
                if (id1 != null)
                {
                    comboBox1.SelectedValue = id1;
                    first.Text = num1;
                    second.Text = num2;
                    textBox1.Text = num3;
                }
                    
            }
            catch (System.Data.Common.DbException)
            {
                MessageBox.Show("Ошибка доступа к БД");
            }
        }

        private void workAdd_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testing_workersDataSet.View_вопр". При необходимости она может быть перемещена или удалена.
            this.view_вопрTableAdapter.Fill(this.testing_workersDataSet.View_вопр);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testing_workersDataSet.Испытания". При необходимости она может быть перемещена или удалена.
            this.испытанияTableAdapter.Fill(this.testing_workersDataSet.Испытания);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testing_workersDataSet.Должности". При необходимости она может быть перемещена или удалена.
            this.должностиTableAdapter.Fill(this.testing_workersDataSet.Должности);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testing_workersDataSet.View_РД". При необходимости она может быть перемещена или удалена.
            this.view_РДTableAdapter.Fill(this.testing_workersDataSet.View_РД);

        }

        private void noOkBT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void okBT_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex < 0 || second.Text.Length == 0 || label3.Text.Length == 0 || first.Text.Length == 0)
            {
                MessageBox.Show("Введите все данные.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            SqlCommand command;
            if (num1 != null && num2 != null && num3 != null) //
            {
                string sqlExpression = "UPDATE Вопросы " +
                    "SET Номер_испытания = @f, Содержание = @ff, Ответ = @fff, Сложность = @ffff  WHERE Номер_испытания = @n";
                SqlParameter Param;
                command = new SqlCommand(sqlExpression, Program.MainForm.connect);
                string n = comboBox1.SelectedValue.ToString();
                Param = new SqlParameter("@f", comboBox1.SelectedValue.ToString());
                command.Parameters.Add(Param);
                Param = new SqlParameter("@ff", first.Text);
                command.Parameters.Add(Param);
                Param = new SqlParameter("@fff", second.Text);
                command.Parameters.Add(Param);
                Param = new SqlParameter("@ffff", Convert.ToInt32(textBox1.Text));
                command.Parameters.Add(Param);
                Param = new SqlParameter("@n", id1);
                command.Parameters.Add(Param);
            }
            else
            {
                string sqlExpression = "INSERT INTO Вопросы (Номер_испытания, Содержание, Ответ, Сложность)" +
                                        "VALUES (@f, @ff,@fff,@ffff)";
                SqlParameter Param;
                command = new SqlCommand(sqlExpression, Program.MainForm.connect);
                string n = comboBox1.SelectedValue.ToString();
                Param = new SqlParameter("@f", comboBox1.SelectedValue.ToString());
                command.Parameters.Add(Param);
                Param = new SqlParameter("@ff", first.Text);
                command.Parameters.Add(Param);
                Param = new SqlParameter("@fff", second.Text);
                command.Parameters.Add(Param);
                Param = new SqlParameter("@ffff", Convert.ToInt32(textBox1.Text));
                command.Parameters.Add(Param);
            }
            int number = command.ExecuteNonQuery();
            this.Close();
        }
    }
}
