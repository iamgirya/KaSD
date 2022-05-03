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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        public System.Data.SqlClient.SqlConnection connect;
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

        private void работникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            workers t = new workers();
            t.Show();
        }

        private void испытанияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tests t = new tests();
            t.Show();
        }

        private void ответыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            answers t = new answers();
            t.Show();
        }

        private void вопросыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            questions t = new questions();
            t.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            String connectionString = "Data Source=DESKTOP-EKL39DM;Initial Catalog=Testing_workers;Integrated Security=True";
            connect = new System.Data.SqlClient.SqlConnection(connectionString);
            connect.Open();
        }

        private void экспортToolStripMenuItem_Click(object sender, EventArgs e)
        {
            export exportMoment = new export();
            exportMoment.Show();
        }

        private void аттестацииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            attestations t = new attestations();
            t.Show();
        }

        private void средняяУспеваемостьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            avgSuccess t = new avgSuccess();
            t.Show();
        }
    }
}
