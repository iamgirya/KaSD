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
    public partial class tesAdd : Form
    {
        string num1;
        string num2;
        string id1;
        string id2;

        public tesAdd(string npro, string mvr, string wid, string iid)
        {
            InitializeComponent();
            num1 = npro;
            num2 = mvr;
            id1 = wid;
            id2 = iid;
            try
            {
                if (num1 == null && num2 == null)
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "SELECT [Создатель],[Тестируемая должность],[Необходимый_процент_выполнения],[Максимальное_время_выполнения],[К. должности] as [К_ должности],[Н. испытания] as [Н_ испытания],[Н. испытателя] as [Н_ испытателя] FROM [View_test] WHERE [К. должности] = '" + id1 + "' and [Н. испытателя] = '" + id2 + "'";
                    cmd.Connection = Program.MainForm.connect;
                    SqlDataReader rd = cmd.ExecuteReader();
                    if (rd.Read())
                    {
                        comboBox1.SelectedValue = id1;
                        comboBox2.SelectedValue = id2;
                        first.Text = (rd.GetValue(0).ToString().Trim());
                        second.Text = (rd.GetValue(2).ToString().Trim());
                    }
                    rd.Close();
                }
                else
                {
                    comboBox1.SelectedValue = id1;
                    comboBox2.SelectedValue = id2;
                    first.Text = num1;
                    second.Text = num2;
                }
            }
            catch (System.Data.Common.DbException)
            {
                MessageBox.Show("Ошибка доступа к БД");
            }
        }

        private void workAdd_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testing_workersDataSet.Испытатели". При необходимости она может быть перемещена или удалена.
            this.испытателиTableAdapter.Fill(this.testing_workersDataSet.Испытатели);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testing_workersDataSet.Должности". При необходимости она может быть перемещена или удалена.
            this.должностиTableAdapter.Fill(this.testing_workersDataSet.Должности);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testing_workersDataSet.View_test". При необходимости она может быть перемещена или удалена.
            this.view_testTableAdapter.Fill(this.testing_workersDataSet.View_test);

        }

        private void noOkBT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void okBT_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex < 0 || comboBox2.SelectedIndex < 0 || second.Text.Length == 0 || first.Text.Length == 0)
            {
                MessageBox.Show("Введите все данные.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            SqlCommand command;
            if (num1 != null && num2 != null) //
            {
                string sqlExpression = "UPDATE Испытания " +
                    "SET Необходимый_процент_выполнения = @f, [Максимальное_время_выполнения] = @ff" +
                    ", Код_должности = @fff, Номер_испытателя = @ffff WHERE Код_должности = @n and Номер_испытателя = @nn";
                SqlParameter Param;
                command = new SqlCommand(sqlExpression, Program.MainForm.connect);
                string n = comboBox1.SelectedValue.ToString();
                Param = new SqlParameter("@fff", comboBox1.SelectedValue.ToString());
                command.Parameters.Add(Param);
                Param = new SqlParameter("@f", first.Text);
                command.Parameters.Add(Param);
                Param = new SqlParameter("@ff", second.Text);
                command.Parameters.Add(Param);
                Param = new SqlParameter("@ffff", comboBox2.SelectedValue.ToString());
                command.Parameters.Add(Param);
                Param = new SqlParameter("@n", id1);
                command.Parameters.Add(Param);
                Param = new SqlParameter("@nn", id2);
                command.Parameters.Add(Param);
            }
            else
            {
                string sqlExpression = "INSERT INTO Испытания (Код_должности, Номер_испытателя, Необходимый_процент_выполнения, Максимальное_время_выполнения)" +
                                        "VALUES (@fff, @ffff,@f, @ff)";
                command = new SqlCommand(sqlExpression, Program.MainForm.connect);
                SqlParameter Param;
                string n = comboBox1.SelectedValue.ToString();
                Param = new SqlParameter("@fff", comboBox1.SelectedValue.ToString());
                command.Parameters.Add(Param);
                Param = new SqlParameter("@f", first.Text);
                command.Parameters.Add(Param);
                Param = new SqlParameter("@ff", second.Text);
                command.Parameters.Add(Param);
                Param = new SqlParameter("@ffff", comboBox2.SelectedValue.ToString());
                command.Parameters.Add(Param);
            }
            int number = command.ExecuteNonQuery();
            this.Close();
        }
    }
}
