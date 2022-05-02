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
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }
        public System.Data.SqlClient.SqlConnection connect;
        private void SBEU_Load(object sender, EventArgs e)
        {
            String connectionString = "Data Source=SultanGG505;Initial Catalog=SQL_Storage;Integrated Security=True";
            connect = new System.Data.SqlClient.SqlConnection(connectionString);
            connect.Open();
        }
        private void выход(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void about(object sender, EventArgs e)
        {
            aboutMe ab = new aboutMe();
            ab.Show();
        }
        private void должностиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            jobs job = new jobs();
            job.Show();
        }

        private void испытателиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            testers t = new testers();
            t.Show();
        }
    }
}
