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
    public partial class ansAdd : Form
    {
        string num1;
        string num2;
        string id1;
        string id2;
        string id3;

        public ansAdd(string pro, string vre, string wid, string iid, string jid)
        {
            InitializeComponent();
            num1 = pro;
            num2 = vre;
            id1 = wid;
            id2 = iid;
            try
            {
                if (num1 != null && num2 != null)
                {
                    comboBox1.SelectedValue = id1;
                    comboBox2.SelectedValue = id2;
                    comboBox3.SelectedValue = id3;
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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testing_workersDataSet.Работники". При необходимости она может быть перемещена или удалена.
            this.работникиTableAdapter.Fill(this.testing_workersDataSet.Работники);
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
            if (comboBox1.SelectedIndex < 0 || comboBox2.SelectedIndex < 0 || comboBox3.SelectedIndex < 0 || second.Text.Length == 0 || first.Text.Length == 0)
            {
                MessageBox.Show("Введите все данные.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            SqlCommand command;
            if (num1 != null && num2 != null) //
            {
                string sqlExpression = "UPDATE Ответы " +
                    "SET Процент_правильных_ответов = @f, [Время_выполнения] = @ff" +
                    ", Номер_работника = @fff, Номер_испытателя = @ffff, Номер_испытания = @fffff WHERE Номер_работника = @n and Номер_испытателя = @nn and Номер_испытания = @nnn";
                SqlParameter Param;
                command = new SqlCommand(sqlExpression, Program.MainForm.connect);
                string n = comboBox1.SelectedValue.ToString();
                Param = new SqlParameter("@f", first.Text);
                command.Parameters.Add(Param);
                Param = new SqlParameter("@ff", second.Text);
                command.Parameters.Add(Param);
                Param = new SqlParameter("@fff", comboBox1.SelectedValue.ToString());
                command.Parameters.Add(Param);
                Param = new SqlParameter("@ffff", comboBox2.SelectedValue.ToString());
                command.Parameters.Add(Param);
                Param = new SqlParameter("@fffff", comboBox3.SelectedValue.ToString());
                command.Parameters.Add(Param);
                Param = new SqlParameter("@n", id1);
                command.Parameters.Add(Param);
                Param = new SqlParameter("@nn", id2);
                command.Parameters.Add(Param);
                Param = new SqlParameter("@nnn", id3);
                command.Parameters.Add(Param);
            }
            else
            {
                string sqlExpression = "INSERT INTO Ответы (Процент_правильных_ответов, Время_выполнения, Номер_работника, Номер_испытателя, Номер_испытания)" +
                                        "VALUES (@f, @ff, @fff, @ffff, @fffff)";
                SqlParameter Param;
                command = new SqlCommand(sqlExpression, Program.MainForm.connect);
                string n = comboBox1.SelectedValue.ToString();
                Param = new SqlParameter("@f", first.Text);
                command.Parameters.Add(Param);
                Param = new SqlParameter("@ff", second.Text);
                command.Parameters.Add(Param);
                Param = new SqlParameter("@fff", comboBox1.SelectedValue.ToString());
                command.Parameters.Add(Param);
                Param = new SqlParameter("@ffff", comboBox2.SelectedValue.ToString());
                command.Parameters.Add(Param);
                Param = new SqlParameter("@fffff", comboBox3.SelectedValue.ToString());
                command.Parameters.Add(Param);
            }
            int number = command.ExecuteNonQuery();
            this.Close();
        }
    }
}
