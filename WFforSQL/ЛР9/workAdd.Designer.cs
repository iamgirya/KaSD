
namespace WFforSQL
{
    partial class workAdd
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
            this.noOkBT = new System.Windows.Forms.Button();
            this.okBT = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.viewРДBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testing_workersDataSet = new WFforSQL.Testing_workersDataSet();
            this.second = new System.Windows.Forms.TextBox();
            this.first = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.view_РДTableAdapter = new WFforSQL.Testing_workersDataSetTableAdapters.View_РДTableAdapter();
            this.должностиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.должностиTableAdapter = new WFforSQL.Testing_workersDataSetTableAdapters.ДолжностиTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.viewРДBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testing_workersDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.должностиBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // noOkBT
            // 
            this.noOkBT.Location = new System.Drawing.Point(287, 244);
            this.noOkBT.Name = "noOkBT";
            this.noOkBT.Size = new System.Drawing.Size(106, 40);
            this.noOkBT.TabIndex = 19;
            this.noOkBT.Text = "отмена";
            this.noOkBT.UseVisualStyleBackColor = true;
            this.noOkBT.Click += new System.EventHandler(this.noOkBT_Click);
            // 
            // okBT
            // 
            this.okBT.Location = new System.Drawing.Point(47, 244);
            this.okBT.Name = "okBT";
            this.okBT.Size = new System.Drawing.Size(94, 40);
            this.okBT.TabIndex = 18;
            this.okBT.Text = "ок";
            this.okBT.UseVisualStyleBackColor = true;
            this.okBT.Click += new System.EventHandler(this.okBT_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.должностиBindingSource;
            this.comboBox1.DisplayMember = "Название";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(201, 112);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(192, 24);
            this.comboBox1.TabIndex = 17;
            this.comboBox1.ValueMember = "Код";
            // 
            // viewРДBindingSource
            // 
            this.viewРДBindingSource.DataMember = "View_РД";
            this.viewРДBindingSource.DataSource = this.testing_workersDataSet;
            // 
            // testing_workersDataSet
            // 
            this.testing_workersDataSet.DataSetName = "Testing_workersDataSet";
            this.testing_workersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // second
            // 
            this.second.Location = new System.Drawing.Point(201, 73);
            this.second.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.second.Name = "second";
            this.second.Size = new System.Drawing.Size(192, 22);
            this.second.TabIndex = 15;
            // 
            // first
            // 
            this.first.Location = new System.Drawing.Point(201, 36);
            this.first.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.first.Name = "first";
            this.first.Size = new System.Drawing.Size(192, 22);
            this.first.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Должность";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Стаж работы";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "ФИО";
            // 
            // view_РДTableAdapter
            // 
            this.view_РДTableAdapter.ClearBeforeFill = true;
            // 
            // должностиBindingSource
            // 
            this.должностиBindingSource.DataMember = "Должности";
            this.должностиBindingSource.DataSource = this.testing_workersDataSet;
            // 
            // должностиTableAdapter
            // 
            this.должностиTableAdapter.ClearBeforeFill = true;
            // 
            // workAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 317);
            this.Controls.Add(this.noOkBT);
            this.Controls.Add(this.okBT);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.second);
            this.Controls.Add(this.first);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "workAdd";
            this.Text = "workAdd";
            this.Load += new System.EventHandler(this.workAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewРДBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testing_workersDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.должностиBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button noOkBT;
        private System.Windows.Forms.Button okBT;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox second;
        private System.Windows.Forms.TextBox first;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Testing_workersDataSet testing_workersDataSet;
        private System.Windows.Forms.BindingSource viewРДBindingSource;
        private Testing_workersDataSetTableAdapters.View_РДTableAdapter view_РДTableAdapter;
        private System.Windows.Forms.BindingSource должностиBindingSource;
        private Testing_workersDataSetTableAdapters.ДолжностиTableAdapter должностиTableAdapter;
    }
}