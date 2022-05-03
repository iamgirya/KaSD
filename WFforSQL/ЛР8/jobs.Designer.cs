
namespace WFforSQL
{
    partial class jobs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.сохранитьИзмененияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьВыбранноеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.назадToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testing_workersDataSet = new WFforSQL.Testing_workersDataSet();
            this.testingworkersDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.должностиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.должностиTableAdapter = new WFforSQL.Testing_workersDataSetTableAdapters.ДолжностиTableAdapter();
            this.кодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.размерокладаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testing_workersDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testingworkersDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.должностиBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьИзмененияToolStripMenuItem,
            this.удалитьВыбранноеToolStripMenuItem,
            this.назадToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // сохранитьИзмененияToolStripMenuItem
            // 
            this.сохранитьИзмененияToolStripMenuItem.Name = "сохранитьИзмененияToolStripMenuItem";
            this.сохранитьИзмененияToolStripMenuItem.Size = new System.Drawing.Size(179, 24);
            this.сохранитьИзмененияToolStripMenuItem.Text = "Сохранить изменения";
            this.сохранитьИзмененияToolStripMenuItem.Click += new System.EventHandler(this.сохранитьИзмененияToolStripMenuItem_Click);
            // 
            // удалитьВыбранноеToolStripMenuItem
            // 
            this.удалитьВыбранноеToolStripMenuItem.Name = "удалитьВыбранноеToolStripMenuItem";
            this.удалитьВыбранноеToolStripMenuItem.Size = new System.Drawing.Size(163, 24);
            this.удалитьВыбранноеToolStripMenuItem.Text = "Удалить выбранное";
            this.удалитьВыбранноеToolStripMenuItem.Click += new System.EventHandler(this.удалитьВыбранноеToolStripMenuItem_Click);
            // 
            // назадToolStripMenuItem
            // 
            this.назадToolStripMenuItem.Name = "назадToolStripMenuItem";
            this.назадToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.назадToolStripMenuItem.Text = "Назад";
            this.назадToolStripMenuItem.Click += new System.EventHandler(this.назадToolStripMenuItem_Click);
            // 
            // testing_workersDataSet
            // 
            this.testing_workersDataSet.DataSetName = "Testing_workersDataSet";
            this.testing_workersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // testingworkersDataSetBindingSource
            // 
            this.testingworkersDataSetBindingSource.DataSource = this.testing_workersDataSet;
            this.testingworkersDataSetBindingSource.Position = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодDataGridViewTextBoxColumn,
            this.названиеDataGridViewTextBoxColumn,
            this.размерокладаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.должностиBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // должностиBindingSource
            // 
            this.должностиBindingSource.DataMember = "Должности";
            this.должностиBindingSource.DataSource = this.testingworkersDataSetBindingSource;
            // 
            // должностиTableAdapter
            // 
            this.должностиTableAdapter.ClearBeforeFill = true;
            // 
            // кодDataGridViewTextBoxColumn
            // 
            this.кодDataGridViewTextBoxColumn.DataPropertyName = "Код";
            this.кодDataGridViewTextBoxColumn.HeaderText = "Код";
            this.кодDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодDataGridViewTextBoxColumn.Name = "кодDataGridViewTextBoxColumn";
            this.кодDataGridViewTextBoxColumn.ReadOnly = true;
            this.кодDataGridViewTextBoxColumn.Width = 125;
            // 
            // названиеDataGridViewTextBoxColumn
            // 
            this.названиеDataGridViewTextBoxColumn.DataPropertyName = "Название";
            this.названиеDataGridViewTextBoxColumn.HeaderText = "Название";
            this.названиеDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.названиеDataGridViewTextBoxColumn.Name = "названиеDataGridViewTextBoxColumn";
            this.названиеDataGridViewTextBoxColumn.Width = 125;
            // 
            // размерокладаDataGridViewTextBoxColumn
            // 
            this.размерокладаDataGridViewTextBoxColumn.DataPropertyName = "Размер_оклада";
            this.размерокладаDataGridViewTextBoxColumn.HeaderText = "Размер_оклада";
            this.размерокладаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.размерокладаDataGridViewTextBoxColumn.Name = "размерокладаDataGridViewTextBoxColumn";
            this.размерокладаDataGridViewTextBoxColumn.Width = 125;
            // 
            // jobs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "jobs";
            this.Text = "jobs";
            this.Load += new System.EventHandler(this.jobs_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testing_workersDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testingworkersDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.должностиBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem сохранитьИзмененияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьВыбранноеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem назадToolStripMenuItem;
        private Testing_workersDataSet testing_workersDataSet;
        private System.Windows.Forms.BindingSource testingworkersDataSetBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource должностиBindingSource;
        private Testing_workersDataSetTableAdapters.ДолжностиTableAdapter должностиTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn размерокладаDataGridViewTextBoxColumn;
    }
}