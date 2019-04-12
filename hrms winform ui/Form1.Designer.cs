namespace hrms_winform_ui
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEcode = new System.Windows.Forms.TextBox();
            this.txtEname = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.txtDeptid = new System.Windows.Forms.TextBox();
            this.btnAddemp = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnFindEmp = new System.Windows.Forms.Button();
            this.dgvEmp = new System.Windows.Forms.DataGridView();
            this.btnCallSp = new System.Windows.Forms.Button();
            this.btnGetBonus = new System.Windows.Forms.Button();
            this.btnTransaction = new System.Windows.Forms.Button();
            this.btnDisaplayAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmp)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Ecode";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Ename";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Salary";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "DeptID";
            // 
            // txtEcode
            // 
            this.txtEcode.Location = new System.Drawing.Point(175, 40);
            this.txtEcode.Name = "txtEcode";
            this.txtEcode.Size = new System.Drawing.Size(100, 20);
            this.txtEcode.TabIndex = 4;
           // this.txtEcode.TextChanged += new System.EventHandler(this.txtEcode_TextChanged);
            // 
            // txtEname
            // 
            this.txtEname.Location = new System.Drawing.Point(175, 83);
            this.txtEname.Name = "txtEname";
            this.txtEname.Size = new System.Drawing.Size(100, 20);
            this.txtEname.TabIndex = 5;
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(175, 126);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(100, 20);
            this.txtSalary.TabIndex = 6;
            // 
            // txtDeptid
            // 
            this.txtDeptid.Location = new System.Drawing.Point(175, 169);
            this.txtDeptid.Name = "txtDeptid";
            this.txtDeptid.Size = new System.Drawing.Size(100, 20);
            this.txtDeptid.TabIndex = 7;
            // 
            // btnAddemp
            // 
            this.btnAddemp.Location = new System.Drawing.Point(70, 222);
            this.btnAddemp.Name = "btnAddemp";
            this.btnAddemp.Size = new System.Drawing.Size(75, 25);
            this.btnAddemp.TabIndex = 8;
            this.btnAddemp.Text = "AddEmployee";
            this.btnAddemp.UseVisualStyleBackColor = true;
            this.btnAddemp.Click += new System.EventHandler(this.btnAddemp_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(175, 222);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(87, 25);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(280, 222);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 25);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(172, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Employee Form";
            // 
            // btnFindEmp
            // 
            this.btnFindEmp.Location = new System.Drawing.Point(281, 38);
            this.btnFindEmp.Name = "btnFindEmp";
            this.btnFindEmp.Size = new System.Drawing.Size(75, 23);
            this.btnFindEmp.TabIndex = 12;
            this.btnFindEmp.Text = "Find By Id";
            this.btnFindEmp.UseVisualStyleBackColor = true;
            this.btnFindEmp.Click += new System.EventHandler(this.btnFindEmp_Click);
            // 
            // dgvEmp
            // 
            this.dgvEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmp.Location = new System.Drawing.Point(70, 253);
            this.dgvEmp.Name = "dgvEmp";
            this.dgvEmp.Size = new System.Drawing.Size(286, 166);
            this.dgvEmp.TabIndex = 13;
            // 
            // btnCallSp
            // 
            this.btnCallSp.Location = new System.Drawing.Point(281, 83);
            this.btnCallSp.Name = "btnCallSp";
            this.btnCallSp.Size = new System.Drawing.Size(75, 23);
            this.btnCallSp.TabIndex = 14;
            this.btnCallSp.Text = "CallSP";
            this.btnCallSp.UseVisualStyleBackColor = true;
            this.btnCallSp.Click += new System.EventHandler(this.btnCallSp_Click);
            // 
            // btnGetBonus
            // 
            this.btnGetBonus.Location = new System.Drawing.Point(281, 126);
            this.btnGetBonus.Name = "btnGetBonus";
            this.btnGetBonus.Size = new System.Drawing.Size(75, 23);
            this.btnGetBonus.TabIndex = 15;
            this.btnGetBonus.Text = "GetBonus";
            this.btnGetBonus.UseVisualStyleBackColor = true;
            this.btnGetBonus.Click += new System.EventHandler(this.btnGetBonus_Click);
            // 
            // btnTransaction
            // 
            this.btnTransaction.Location = new System.Drawing.Point(281, 169);
            this.btnTransaction.Name = "btnTransaction";
            this.btnTransaction.Size = new System.Drawing.Size(75, 23);
            this.btnTransaction.TabIndex = 16;
            this.btnTransaction.Text = "DoTransaction";
            this.btnTransaction.UseVisualStyleBackColor = true;
            this.btnTransaction.Click += new System.EventHandler(this.btnTransaction_Click);
            // 
            // btnDisaplayAll
            // 
            this.btnDisaplayAll.Location = new System.Drawing.Point(362, 40);
            this.btnDisaplayAll.Name = "btnDisaplayAll";
            this.btnDisaplayAll.Size = new System.Drawing.Size(75, 23);
            this.btnDisaplayAll.TabIndex = 17;
            this.btnDisaplayAll.Text = "DisplayAll";
            this.btnDisaplayAll.UseVisualStyleBackColor = true;
            this.btnDisaplayAll.Click += new System.EventHandler(this.btnDisaplayAll_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 431);
            this.Controls.Add(this.btnDisaplayAll);
            this.Controls.Add(this.btnTransaction);
            this.Controls.Add(this.btnGetBonus);
            this.Controls.Add(this.btnCallSp);
            this.Controls.Add(this.dgvEmp);
            this.Controls.Add(this.btnFindEmp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddemp);
            this.Controls.Add(this.txtDeptid);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.txtEname);
            this.Controls.Add(this.txtEcode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "HRMS";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEcode;
        private System.Windows.Forms.TextBox txtEname;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.TextBox txtDeptid;
        private System.Windows.Forms.Button btnAddemp;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnFindEmp;
        private System.Windows.Forms.DataGridView dgvEmp;
        private System.Windows.Forms.Button btnCallSp;
        private System.Windows.Forms.Button btnGetBonus;
        private System.Windows.Forms.Button btnTransaction;
        private System.Windows.Forms.Button btnDisaplayAll;
    }
}

