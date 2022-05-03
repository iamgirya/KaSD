
namespace WFforSQL
{
    partial class answers
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.viewответыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testing_workersDataSet = new WFforSQL.Testing_workersDataSet();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.тестируемыйDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.проверяющийDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.тестируемаяДолжностьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.процентправильныхответовDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.времявыполненияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.нРаботникаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.нИспытателяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.нИспытанияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кДолжностиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.view_ответыTableAdapter = new WFforSQL.Testing_workersDataSetTableAdapters.View_ответыTableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewответыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testing_workersDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(1203, 28);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выберите испытание:";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.viewответыBindingSource;
            this.comboBox1.DisplayMember = "Тестируемая должность";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(172, 31);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(154, 24);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.ValueMember = "Н_ испытания";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // viewответыBindingSource
            // 
            this.viewответыBindingSource.DataMember = "View_ответы";
            this.viewответыBindingSource.DataSource = this.testing_workersDataSet;
            // 
            // testing_workersDataSet
            // 
            this.testing_workersDataSet.DataSetName = "Testing_workersDataSet";
            this.testing_workersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.viewответыBindingSource;
            this.comboBox2.DisplayMember = "Тестируемый";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(490, 31);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(154, 24);
            this.comboBox2.TabIndex = 6;
            this.comboBox2.ValueMember = "Н_ работника";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(332, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Выберите работника:";
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.viewответыBindingSource;
            this.comboBox3.DisplayMember = "Проверяющий";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(817, 31);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(154, 24);
            this.comboBox3.TabIndex = 8;
            this.comboBox3.ValueMember = "Н_ испытателя";
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(650, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Выберите испытателя:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.тестируемыйDataGridViewTextBoxColumn,
            this.проверяющийDataGridViewTextBoxColumn,
            this.тестируемаяДолжностьDataGridViewTextBoxColumn,
            this.процентправильныхответовDataGridViewTextBoxColumn,
            this.времявыполненияDataGridViewTextBoxColumn,
            this.нРаботникаDataGridViewTextBoxColumn,
            this.нИспытателяDataGridViewTextBoxColumn,
            this.нИспытанияDataGridViewTextBoxColumn,
            this.кДолжностиDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.viewответыBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(15, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1176, 377);
            this.dataGridView1.TabIndex = 9;
            // 
            // тестируемыйDataGridViewTextBoxColumn
            // 
            this.тестируемыйDataGridViewTextBoxColumn.DataPropertyName = "Тестируемый";
            this.тестируемыйDataGridViewTextBoxColumn.HeaderText = "Тестируемый";
            this.тестируемыйDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.тестируемыйDataGridViewTextBoxColumn.Name = "тестируемыйDataGridViewTextBoxColumn";
            this.тестируемыйDataGridViewTextBoxColumn.ReadOnly = true;
            this.тестируемыйDataGridViewTextBoxColumn.Width = 125;
            // 
            // проверяющийDataGridViewTextBoxColumn
            // 
            this.проверяющийDataGridViewTextBoxColumn.DataPropertyName = "Проверяющий";
            this.проверяющийDataGridViewTextBoxColumn.HeaderText = "Проверяющий";
            this.проверяющийDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.проверяющийDataGridViewTextBoxColumn.Name = "проверяющийDataGridViewTextBoxColumn";
            this.проверяющийDataGridViewTextBoxColumn.ReadOnly = true;
            this.проверяющийDataGridViewTextBoxColumn.Width = 125;
            // 
            // тестируемаяДолжностьDataGridViewTextBoxColumn
            // 
            this.тестируемаяДолжностьDataGridViewTextBoxColumn.DataPropertyName = "Тестируемая должность";
            this.тестируемаяДолжностьDataGridViewTextBoxColumn.HeaderText = "Тестируемая должность";
            this.тестируемаяДолжностьDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.тестируемаяДолжностьDataGridViewTextBoxColumn.Name = "тестируемаяДолжностьDataGridViewTextBoxColumn";
            this.тестируемаяДолжностьDataGridViewTextBoxColumn.ReadOnly = true;
            this.тестируемаяДолжностьDataGridViewTextBoxColumn.Width = 125;
            // 
            // процентправильныхответовDataGridViewTextBoxColumn
            // 
            this.процентправильныхответовDataGridViewTextBoxColumn.DataPropertyName = "Процент_правильных_ответов";
            this.процентправильныхответовDataGridViewTextBoxColumn.HeaderText = "Процент_правильных_ответов";
            this.процентправильныхответовDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.процентправильныхответовDataGridViewTextBoxColumn.Name = "процентправильныхответовDataGridViewTextBoxColumn";
            this.процентправильныхответовDataGridViewTextBoxColumn.ReadOnly = true;
            this.процентправильныхответовDataGridViewTextBoxColumn.Width = 125;
            // 
            // времявыполненияDataGridViewTextBoxColumn
            // 
            this.времявыполненияDataGridViewTextBoxColumn.DataPropertyName = "Время_выполнения";
            this.времявыполненияDataGridViewTextBoxColumn.HeaderText = "Время_выполнения";
            this.времявыполненияDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.времявыполненияDataGridViewTextBoxColumn.Name = "времявыполненияDataGridViewTextBoxColumn";
            this.времявыполненияDataGridViewTextBoxColumn.ReadOnly = true;
            this.времявыполненияDataGridViewTextBoxColumn.Width = 125;
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
            // нИспытателяDataGridViewTextBoxColumn
            // 
            this.нИспытателяDataGridViewTextBoxColumn.DataPropertyName = "Н_ испытателя";
            this.нИспытателяDataGridViewTextBoxColumn.HeaderText = "Н_ испытателя";
            this.нИспытателяDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.нИспытателяDataGridViewTextBoxColumn.Name = "нИспытателяDataGridViewTextBoxColumn";
            this.нИспытателяDataGridViewTextBoxColumn.ReadOnly = true;
            this.нИспытателяDataGridViewTextBoxColumn.Width = 125;
            // 
            // нИспытанияDataGridViewTextBoxColumn
            // 
            this.нИспытанияDataGridViewTextBoxColumn.DataPropertyName = "Н_ испытания";
            this.нИспытанияDataGridViewTextBoxColumn.HeaderText = "Н_ испытания";
            this.нИспытанияDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.нИспытанияDataGridViewTextBoxColumn.Name = "нИспытанияDataGridViewTextBoxColumn";
            this.нИспытанияDataGridViewTextBoxColumn.ReadOnly = true;
            this.нИспытанияDataGridViewTextBoxColumn.Width = 125;
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
            // view_ответыTableAdapter
            // 
            this.view_ответыTableAdapter.ClearBeforeFill = true;
            // 
            // answers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "answers";
            this.Text = "answers";
            this.Load += new System.EventHandler(this.answers_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewответыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testing_workersDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Testing_workersDataSet testing_workersDataSet;
        private System.Windows.Forms.BindingSource viewответыBindingSource;
        private Testing_workersDataSetTableAdapters.View_ответыTableAdapter view_ответыTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn тестируемыйDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn проверяющийDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn тестируемаяДолжностьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn процентправильныхответовDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn времявыполненияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn нРаботникаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn нИспытателяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn нИспытанияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кДолжностиDataGridViewTextBoxColumn;
    }
}