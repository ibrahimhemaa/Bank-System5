namespace final_project
{
    partial class Form12
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.accountBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bankSystemDataSet1 = new final_project.BankSystemDataSet1();
            this.button1 = new System.Windows.Forms.Button();
            this.bankSystemDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bankSystemDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.accountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.branchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.accountTableAdapter1 = new final_project.BankSystemDataSet1TableAdapters.accountTableAdapter();
            this.accountBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankSystemDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankSystemDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankSystemDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(171, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(608, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "List Of Loans , Customer Name , Employee Name";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-41, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1113, 452);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // accountBindingSource1
            // 
            this.accountBindingSource1.DataMember = "account";
            this.accountBindingSource1.DataSource = this.bankSystemDataSet1;
            // 
            // bankSystemDataSet1
            // 
            this.bankSystemDataSet1.DataSetName = "BankSystemDataSet1";
            this.bankSystemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(420, 530);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(213, 44);
            this.button1.TabIndex = 5;
            this.button1.Text = "Show List of Loan";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // accountBindingSource
            // 
            this.accountBindingSource.DataMember = "account";
            this.accountBindingSource.DataSource = this.bankSystemDataSetBindingSource1;
            // 
            // branchBindingSource
            // 
            this.branchBindingSource.DataMember = "Branch";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // accountTableAdapter1
            // 
            this.accountTableAdapter1.ClearBeforeFill = true;
            // 
            // accountBindingSource2
            // 
            this.accountBindingSource2.DataMember = "account";
            this.accountBindingSource2.DataSource = this.bankSystemDataSet1;
            // 
            // Form12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 641);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form12";
            this.Text = "Form12";
            this.Load += new System.EventHandler(this.Form12_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankSystemDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankSystemDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankSystemDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource bankSystemDataSetBindingSource;
        private BankSystemDataSet bankSystemDataSet;
        private System.Windows.Forms.BindingSource bankSystemDataSetBindingSource1;
        private System.Windows.Forms.BindingSource accountBindingSource;
        private BankSystemDataSetTableAdapters.accountTableAdapter accountTableAdapter;
        private System.Windows.Forms.BindingSource branchBindingSource;
        private BankSystemDataSetTableAdapters.BranchTableAdapter branchTableAdapter;
        private System.Windows.Forms.Button button2;
        private BankSystemDataSet1 bankSystemDataSet1;
        private System.Windows.Forms.BindingSource accountBindingSource1;
        private BankSystemDataSet1TableAdapters.accountTableAdapter accountTableAdapter1;
        private System.Windows.Forms.BindingSource accountBindingSource2;
    }
}