namespace final_project
{
    partial class Form18
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.loantypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loannumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loanamountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.branchnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bankSystemDataSet1 = new final_project.BankSystemDataSet1();
            this.loanTableAdapter = new final_project.BankSystemDataSet1TableAdapters.loanTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.bankSystemDataSet2 = new final_project.BankSystemDataSet2();
            this.loanBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.loanTableAdapter1 = new final_project.BankSystemDataSet2TableAdapters.loanTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankSystemDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankSystemDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loanBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(292, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Request Loan";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.loantypeDataGridViewTextBoxColumn,
            this.loannumberDataGridViewTextBoxColumn,
            this.loanamountDataGridViewTextBoxColumn,
            this.branchnumberDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.loanBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(445, 130);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(343, 208);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // loantypeDataGridViewTextBoxColumn
            // 
            this.loantypeDataGridViewTextBoxColumn.DataPropertyName = "loan_type";
            this.loantypeDataGridViewTextBoxColumn.HeaderText = "loan_type";
            this.loantypeDataGridViewTextBoxColumn.Name = "loantypeDataGridViewTextBoxColumn";
            // 
            // loannumberDataGridViewTextBoxColumn
            // 
            this.loannumberDataGridViewTextBoxColumn.DataPropertyName = "loan_number";
            this.loannumberDataGridViewTextBoxColumn.HeaderText = "loan_number";
            this.loannumberDataGridViewTextBoxColumn.Name = "loannumberDataGridViewTextBoxColumn";
            // 
            // loanamountDataGridViewTextBoxColumn
            // 
            this.loanamountDataGridViewTextBoxColumn.DataPropertyName = "loan_amount";
            this.loanamountDataGridViewTextBoxColumn.HeaderText = "loan_amount";
            this.loanamountDataGridViewTextBoxColumn.Name = "loanamountDataGridViewTextBoxColumn";
            // 
            // branchnumberDataGridViewTextBoxColumn
            // 
            this.branchnumberDataGridViewTextBoxColumn.DataPropertyName = "Branch_number";
            this.branchnumberDataGridViewTextBoxColumn.HeaderText = "Branch_number";
            this.branchnumberDataGridViewTextBoxColumn.Name = "branchnumberDataGridViewTextBoxColumn";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // loanBindingSource
            // 
            this.loanBindingSource.DataMember = "loan";
            this.loanBindingSource.DataSource = this.bankSystemDataSet1;
            // 
            // bankSystemDataSet1
            // 
            this.bankSystemDataSet1.DataSetName = "BankSystemDataSet1";
            this.bankSystemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loanTableAdapter
            // 
            this.loanTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label2.Location = new System.Drawing.Point(441, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "List to choose your loan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label3.Location = new System.Drawing.Point(74, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Loan number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label4.Location = new System.Drawing.Point(149, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "SSN";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(203, 160);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(141, 22);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(203, 268);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(141, 22);
            this.textBox2.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(339, 391);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 47);
            this.button2.TabIndex = 8;
            this.button2.Text = "Request";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bankSystemDataSet2
            // 
            this.bankSystemDataSet2.DataSetName = "BankSystemDataSet2";
            this.bankSystemDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loanBindingSource1
            // 
            this.loanBindingSource1.DataMember = "loan";
            this.loanBindingSource1.DataSource = this.bankSystemDataSet2;
            // 
            // loanTableAdapter1
            // 
            this.loanTableAdapter1.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(583, 367);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Refresh";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form18
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form18";
            this.Text = "Form18";
            this.Load += new System.EventHandler(this.Form18_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankSystemDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankSystemDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loanBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private BankSystemDataSet1 bankSystemDataSet1;
        private System.Windows.Forms.BindingSource loanBindingSource;
        private BankSystemDataSet1TableAdapters.loanTableAdapter loanTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn loantypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loannumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loanamountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn branchnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private BankSystemDataSet2 bankSystemDataSet2;
        private System.Windows.Forms.BindingSource loanBindingSource1;
        private BankSystemDataSet2TableAdapters.loanTableAdapter loanTableAdapter1;
        private System.Windows.Forms.Button button3;
    }
}