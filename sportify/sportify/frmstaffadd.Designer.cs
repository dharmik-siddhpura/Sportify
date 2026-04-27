namespace sportify
{
    partial class frmstaffadd
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
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnupdate = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdbfemale = new System.Windows.Forms.RadioButton();
            this.txtsalary = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtdate = new System.Windows.Forms.DateTimePicker();
            this.rdbmale = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtaddress = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtstaffname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(401, 9);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 46);
            this.label10.TabIndex = 10;
            this.label10.Text = "Staff";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(915, 62);
            this.panel1.TabIndex = 67;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Wingdings 2", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.button2.Location = new System.Drawing.Point(871, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(44, 62);
            this.button2.TabIndex = 12;
            this.button2.Text = "Ñ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(125, 5);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 43);
            this.button1.TabIndex = 9;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.Green;
            this.btnsave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnsave.Location = new System.Drawing.Point(12, 5);
            this.btnsave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(100, 43);
            this.btnsave.TabIndex = 55;
            this.btnsave.Text = "Add";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnupdate);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.btnsave);
            this.panel4.Location = new System.Drawing.Point(338, 383);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(239, 56);
            this.panel4.TabIndex = 66;
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.CadetBlue;
            this.btnupdate.Enabled = false;
            this.btnupdate.ForeColor = System.Drawing.Color.Black;
            this.btnupdate.Location = new System.Drawing.Point(11, 7);
            this.btnupdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(100, 42);
            this.btnupdate.TabIndex = 56;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Visible = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rdbfemale);
            this.panel2.Controls.Add(this.txtsalary);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtdate);
            this.panel2.Controls.Add(this.rdbmale);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtaddress);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtemail);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtphone);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtstaffname);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.panel2.Location = new System.Drawing.Point(23, 88);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(872, 272);
            this.panel2.TabIndex = 70;
            // 
            // rdbfemale
            // 
            this.rdbfemale.AutoSize = true;
            this.rdbfemale.Location = new System.Drawing.Point(770, 140);
            this.rdbfemale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbfemale.Name = "rdbfemale";
            this.rdbfemale.Size = new System.Drawing.Size(95, 28);
            this.rdbfemale.TabIndex = 7;
            this.rdbfemale.TabStop = true;
            this.rdbfemale.Text = "Female";
            this.rdbfemale.UseVisualStyleBackColor = true;
            // 
            // txtsalary
            // 
            this.txtsalary.Location = new System.Drawing.Point(629, 60);
            this.txtsalary.Margin = new System.Windows.Forms.Padding(5);
            this.txtsalary.MaxLength = 7;
            this.txtsalary.Name = "txtsalary";
            this.txtsalary.Size = new System.Drawing.Size(216, 28);
            this.txtsalary.TabIndex = 5;
            this.txtsalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsalary_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(629, 23);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 24);
            this.label6.TabIndex = 59;
            this.label6.Text = "Salary : ";
            // 
            // txtdate
            // 
            this.txtdate.Location = new System.Drawing.Point(299, 60);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(273, 28);
            this.txtdate.TabIndex = 4;
            // 
            // rdbmale
            // 
            this.rdbmale.AutoSize = true;
            this.rdbmale.Location = new System.Drawing.Point(629, 139);
            this.rdbmale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbmale.Name = "rdbmale";
            this.rdbmale.Size = new System.Drawing.Size(72, 28);
            this.rdbmale.TabIndex = 6;
            this.rdbmale.TabStop = true;
            this.rdbmale.Text = "Male";
            this.rdbmale.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(299, 101);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 24);
            this.label4.TabIndex = 56;
            this.label4.Text = "Address : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(629, 102);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 24);
            this.label7.TabIndex = 65;
            this.label7.Text = "Gender:";
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(299, 138);
            this.txtaddress.MaxLength = 150;
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(273, 99);
            this.txtaddress.TabIndex = 8;
            this.txtaddress.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(299, 23);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 24);
            this.label5.TabIndex = 58;
            this.label5.Text = "Date : ";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(22, 217);
            this.txtemail.Margin = new System.Windows.Forms.Padding(5);
            this.txtemail.MaxLength = 30;
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(216, 28);
            this.txtemail.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 180);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 24);
            this.label3.TabIndex = 53;
            this.label3.Text = "E-mail : ";
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(22, 138);
            this.txtphone.Margin = new System.Windows.Forms.Padding(5);
            this.txtphone.MaxLength = 10;
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(216, 28);
            this.txtphone.TabIndex = 2;
            this.txtphone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtphone_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 101);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 24);
            this.label1.TabIndex = 51;
            this.label1.Text = "Phone : ";
            // 
            // txtstaffname
            // 
            this.txtstaffname.Location = new System.Drawing.Point(22, 59);
            this.txtstaffname.Margin = new System.Windows.Forms.Padding(5);
            this.txtstaffname.MaxLength = 20;
            this.txtstaffname.Name = "txtstaffname";
            this.txtstaffname.Size = new System.Drawing.Size(216, 28);
            this.txtstaffname.TabIndex = 1;
            this.txtstaffname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtstaffname_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 24);
            this.label2.TabIndex = 49;
            this.label2.Text = "Name : ";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(262, 415);
            this.txtid.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtid.MaxLength = 40;
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(52, 22);
            this.txtid.TabIndex = 71;
            this.txtid.Visible = false;
            // 
            // frmstaffadd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 462);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmstaffadd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmstaffadd";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rdbfemale;
        private System.Windows.Forms.TextBox txtsalary;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker txtdate;
        private System.Windows.Forms.RadioButton rdbmale;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox txtaddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtstaffname;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button btnupdate;
        public System.Windows.Forms.TextBox txtid;
    }
}