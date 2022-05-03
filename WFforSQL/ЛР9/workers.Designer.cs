
namespace WFforSQL
{
    partial class workers
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
            this.операцииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вернутьсяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.testing_workersDataSet = new WFforSQL.Testing_workersDataSet();
            this.viewРДBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_РДTableAdapter = new WFforSQL.Testing_workersDataSetTableAdapters.View_РДTableAdapter();
            this.работникDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.должностьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.стажработыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.размерокладаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.нРаботникаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кДолжностиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testing_workersDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewРДBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.операцииToolStripMenuItem,
            this.вернутьсяToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(828, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // операцииToolStripMenuItem
            // 
            this.операцииToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.изменитьToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.операцииToolStripMenuItem.Name = "операцииToolStripMenuItem";
            this.операцииToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
            this.операцииToolStripMenuItem.Text = "Операции";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // изменитьToolStripMenuItem
            // 
            this.изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            this.изменитьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.изменитьToolStripMenuItem.Text = "Изменить";
            this.изменитьToolStripMenuItem.Click += new System.EventHandler(this.изменитьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // вернутьсяToolStripMenuItem
            // 
            this.вернутьсяToolStripMenuItem.Name = "вернутьсяToolStripMenuItem";
            this.вернутьсяToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.вернутьсяToolStripMenuItem.Text = "Вернуться";
            this.вернутьсяToolStripMenuItem.Click += new System.EventHandler(this.вернутьсяToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.viewРДBindingSource;
            this.comboBox2.DisplayMember = "Должность";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(170, 31);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(154, 24);
            this.comboBox2.TabIndex = 6;
            this.comboBox2.ValueMember = "К_ должности";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Выберите должность:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.работникDataGridViewTextBoxColumn,
            this.должностьDataGridViewTextBoxColumn,
            this.стажработыDataGridViewTextBoxColumn,
            this.размерокладаDataGridViewTextBoxColumn,
            this.нРаботникаDataGridViewTextBoxColumn,
            this.кДолжностиDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.viewРДBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(15, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(801, 377);
            this.dataGridView1.TabIndex = 7;
            // 
            // testing_workersDataSet
            // 
            this.testing_workersDataSet.DataSetName = "Testing_workersDataSet";
            this.testing_workersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewРДBindingSource
            // 
            this.viewРДBindingSource.DataMember = "View_РД";
            this.viewРДBindingSource.DataSource = this.testing_workersDataSet;
            // 
            // view_РДTableAdapter
            // 
            this.view_РДTableAdapter.ClearBeforeFill = true;
            // 
            // работникDataGridViewTextBoxColumn
            // 
            this.работникDataGridViewTextBoxColumn.DataPropertyName = "Работник";
            this.работникDataGridViewTextBoxColumn.HeaderText = "Работник";
            this.работникDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.работникDataGridViewTextBoxColumn.Name = "работникDataGridViewTextBoxColumn";
            this.работникDataGridViewTextBoxColumn.ReadOnly = true;
            this.работникDataGridViewTextBoxColumn.Width = 125;
            // 
            // должностьDataGridViewTextBoxColumn
            // 
            this.должностьDataGridViewTextBoxColumn.DataPropertyName = "Должность";
            this.должностьDataGridViewTextBoxColumn.HeaderText = "Должность";
            this.должностьDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.должностьDataGridViewTextBoxColumn.Name = "должностьDataGridViewTextBoxColumn";
            this.должностьDataGridViewTextBoxColumn.ReadOnly = true;
            this.должностьDataGridViewTextBoxColumn.Width = 125;
            // 
            // стажработыDataGridViewTextBoxColumn
            // 
            this.стажработыDataGridViewTextBoxColumn.DataPropertyName = "Стаж_работы";
            this.стажработыDataGridViewTextBoxColumn.HeaderText = "Стаж_работы";
            this.стажработыDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.стажработыDataGridViewTextBoxColumn.Name = "стажработыDataGridViewTextBoxColumn";
            this.стажработыDataGridViewTextBoxColumn.ReadOnly = true;
            this.стажработыDataGridViewTextBoxColumn.Width = 125;
            // 
            // размерокладаDataGridViewTextBoxColumn
            // 
            this.размерокладаDataGridViewTextBoxColumn.DataPropertyName = "Размер_оклада";
            this.размерокладаDataGridViewTextBoxColumn.HeaderText = "Размер_оклада";
            this.размерокладаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.размерокладаDataGridViewTextBoxColumn.Name = "размерокладаDataGridViewTextBoxColumn";
            this.размерокладаDataGridViewTextBoxColumn.ReadOnly = true;
            this.размерокладаDataGridViewTextBoxColumn.Width = 125;
            // 
            // нРаботникаDataGridViewTextBoxColumn
            // 
            this.нРаботникаDataGridViewTextBoxColumn.DataPropertyName = "Н_ работника";
            this.нРаботникаDataGridViewTextBoxColumn.HeaderText = "Н_ работника";
            this.нРаботникаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.нРаботникаDataGridViewTextBoxColumn.Name = "нРаботникаDataGridViewTextBoxColumn";
            this.нРаботникаDataGridViewTextBoxColumn.ReadOnly = true;
            this.нРаботникаDataGridViewTextBoxColumn.Width = 125;
            // 
            // кДолжностиDataGridViewTextBoxColumn
            // 
            this.кДолжностиDataGridViewTextBoxColumn.DataPropertyName = "К_ должности";
            this.кДолжностиDataGridViewTextBoxColumn.HeaderText = "К_ должности";
            this.кДолжностиDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кДолжностиDataGridViewTextBoxColumn.Name = "кДолжностиDataGridViewTextBoxColumn";
            this.кДолжностиDataGridViewTextBoxColumn.ReadOnly = true;
            this.кДолжностиDataGridViewTextBoxColumn.Width = 125;
            // 
            // workers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "workers";
            this.Text = "Работники";
            this.Load += new System.EventHandler(this.answers_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testing_workersDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewРДBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem операцииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вернутьсяToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Testing_workersDataSet testing_workersDataSet;
        private System.Windows.Forms.BindingSource viewРДBindingSource;
        private Testing_workersDataSetTableAdapters.View_РДTableAdapter view_РДTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn работникDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn должностьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn стажработыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn размерокладаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn нРаботникаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кДолжностиDataGridViewTextBoxColumn;
    }
}