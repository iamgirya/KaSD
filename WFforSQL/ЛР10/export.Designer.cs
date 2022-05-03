
namespace WFforSQL
{
    partial class export
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
            this.назадToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.avg = new System.Windows.Forms.CheckBox();
            this.att = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.excel = new System.Windows.Forms.CheckBox();
            this.html = new System.Windows.Forms.CheckBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.отчёт_о_средней_успеваемостиTableAdapter1 = new WFforSQL.Testing_workersDataSetTableAdapters.Отчёт_о_средней_успеваемостиTableAdapter();
            this.отчёт_о_тестированииTableAdapter1 = new WFforSQL.Testing_workersDataSetTableAdapters.Отчёт_о_тестированииTableAdapter();
            this.testing_workersDataSet1 = new WFforSQL.Testing_workersDataSet();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testing_workersDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.назадToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(317, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // назадToolStripMenuItem
            // 
            this.назадToolStripMenuItem.Name = "назадToolStripMenuItem";
            this.назадToolStripMenuItem.Size = new System.Drawing.Size(65, 26);
            this.назадToolStripMenuItem.Text = "Назад";
            this.назадToolStripMenuItem.Click += new System.EventHandler(this.назадToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // avg
            // 
            this.avg.AutoSize = true;
            this.avg.Location = new System.Drawing.Point(12, 54);
            this.avg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.avg.Name = "avg";
            this.avg.Size = new System.Drawing.Size(242, 21);
            this.avg.TabIndex = 8;
            this.avg.Text = "Отчёт о средней квалификации";
            this.avg.UseVisualStyleBackColor = true;
            // 
            // att
            // 
            this.att.AutoSize = true;
            this.att.Location = new System.Drawing.Point(12, 30);
            this.att.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.att.Name = "att";
            this.att.Size = new System.Drawing.Size(171, 21);
            this.att.TabIndex = 7;
            this.att.Text = "Отчёт об аттестации";
            this.att.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(196, 122);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 42);
            this.button2.TabIndex = 6;
            this.button2.Text = "экспорт";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.excel);
            this.groupBox1.Controls.Add(this.html);
            this.groupBox1.Location = new System.Drawing.Point(12, 79);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(178, 85);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Экспорт";
            // 
            // excel
            // 
            this.excel.AutoSize = true;
            this.excel.Location = new System.Drawing.Point(6, 43);
            this.excel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.excel.Name = "excel";
            this.excel.Size = new System.Drawing.Size(74, 21);
            this.excel.TabIndex = 6;
            this.excel.Text = "эксель";
            this.excel.UseVisualStyleBackColor = true;
            // 
            // html
            // 
            this.html.AutoSize = true;
            this.html.Location = new System.Drawing.Point(5, 20);
            this.html.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.html.Name = "html";
            this.html.Size = new System.Drawing.Size(60, 21);
            this.html.TabIndex = 5;
            this.html.Text = "хтмл";
            this.html.UseVisualStyleBackColor = true;
            // 
            // отчёт_о_средней_успеваемостиTableAdapter1
            // 
            this.отчёт_о_средней_успеваемостиTableAdapter1.ClearBeforeFill = true;
            // 
            // отчёт_о_тестированииTableAdapter1
            // 
            this.отчёт_о_тестированииTableAdapter1.ClearBeforeFill = true;
            // 
            // testing_workersDataSet1
            // 
            this.testing_workersDataSet1.DataSetName = "Testing_workersDataSet";
            this.testing_workersDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // export
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 175);
            this.Controls.Add(this.avg);
            this.Controls.Add(this.att);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "export";
            this.Text = "export";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testing_workersDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem назадToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.CheckBox avg;
        private System.Windows.Forms.CheckBox att;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox excel;
        private System.Windows.Forms.CheckBox html;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private Testing_workersDataSetTableAdapters.Отчёт_о_средней_успеваемостиTableAdapter отчёт_о_средней_успеваемостиTableAdapter1;
        private Testing_workersDataSetTableAdapters.Отчёт_о_тестированииTableAdapter отчёт_о_тестированииTableAdapter1;
        private Testing_workersDataSet testing_workersDataSet1;
    }
}