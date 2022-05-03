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
    public partial class workAdd : Form
    {
        string num1;
        string num2;
        string id1;

        public workAdd(string fio, string st, string jid)
        {
            InitializeComponent();
            num1 = fio;
            num2 = st;
            id1 = jid;
            try
            {
                if (id1 != null)
                {
                    comboBox1.SelectedValue = id1;
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
            if (comboBox1.SelectedIndex < 0 || second.Text.Length == 0 || first.Text.Length == 0)
            {
                MessageBox.Show("Введите все данные.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            SqlCommand command;
            if (num1 != null && num2 != null) //
            {
                string sqlExpression = "UPDATE Работники " +
                    "SET Код_должности = @f, ФИО = @ff, Стаж_работы = @fff WHERE ФИО = @n and Код_должности = @nn";
                SqlParameter Param;
                command = new SqlCommand(sqlExpression, Program.MainForm.connect);
                string n = comboBox1.SelectedValue.ToString();
                Param = new SqlParameter("@f", comboBox1.SelectedValue.ToString());
                command.Parameters.Add(Param);
                Param = new SqlParameter("@ff", first.Text);
                command.Parameters.Add(Param);
                Param = new SqlParameter("@fff", second.Text);
                command.Parameters.Add(Param);
                Param = new SqlParameter("@n", num1);
                command.Parameters.Add(Param);
                Param = new SqlParameter("@nn", id1);
                command.Parameters.Add(Param);
            }
            else
            {
                string sqlExpression = "INSERT INTO Работники (Код_должности, ФИО, Стаж_работы)" +
                                        "VALUES (@f, @ff,@fff)";
                command = new SqlCommand(sqlExpression, Program.MainForm.connect);
                SqlParameter Param;
                string n = comboBox1.SelectedValue.ToString();
                Param = new SqlParameter("@f", comboBox1.SelectedValue.ToString());
                command.Parameters.Add(Param);
                Param = new SqlParameter("@ff", first.Text);
                command.Parameters.Add(Param);
                Param = new SqlParameter("@fff", second.Text);
                command.Parameters.Add(Param);
            }
            int number = command.ExecuteNonQuery();
            this.Close();
        }
    }
}
