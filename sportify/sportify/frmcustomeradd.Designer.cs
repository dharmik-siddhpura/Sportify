namespace sportify
{
    partial class frmcustomeradd
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtcname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rtbcaddress = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rdbfemale = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.rdbmale = new System.Windows.Forms.RadioButton();
            this.txtcphone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcemail = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnupdate = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtcname);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.rtbcaddress);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.rdbfemale);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.rdbmale);
            this.panel3.Controls.Add(this.txtcphone);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txtcemail);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.panel3.Location = new System.Drawing.Point(33, 80);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(563, 263);
            this.panel3.TabIndex = 3;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // txtcname
            // 
            this.txtcname.Location = new System.Drawing.Point(20, 55);
            this.txtcname.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtcname.MaxLength = 40;
            this.txtcname.Name = "txtcname";
            this.txtcname.Size = new System.Drawing.Size(227, 28);
            this.txtcname.TabIndex = 1;
            this.txtcname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcname_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 24);
            this.label1.TabIndex = 30;
            this.label1.Text = "Name:";
            // 
            // rtbcaddress
            // 
            this.rtbcaddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbcaddress.Location = new System.Drawing.Point(301, 55);
            this.rtbcaddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbcaddress.MaxLength = 50;
            this.rtbcaddress.Name = "rtbcaddress";
            this.rtbcaddress.Size = new System.Drawing.Size(227, 96);
            this.rtbcaddress.TabIndex = 4;
            this.rtbcaddress.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 96);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 24);
            this.label3.TabIndex = 33;
            this.label3.Text = "Phone:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 174);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 24);
            this.label4.TabIndex = 34;
            this.label4.Text = "Email:";
            // 
            // rdbfemale
            // 
            this.rdbfemale.AutoSize = true;
            this.rdbfemale.Location = new System.Drawing.Point(384, 210);
            this.rdbfemale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbfemale.Name = "rdbfemale";
            this.rdbfemale.Size = new System.Drawing.Size(95, 28);
            this.rdbfemale.TabIndex = 6;
            this.rdbfemale.TabStop = true;
            this.rdbfemale.Text = "Female";
            this.rdbfemale.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(299, 18);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 24);
            this.label5.TabIndex = 35;
            this.label5.Text = "Address:";
            // 
            // rdbmale
            // 
            this.rdbmale.AutoSize = true;
            this.rdbmale.Location = new System.Drawing.Point(301, 210);
            this.rdbmale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbmale.Name = "rdbmale";
            this.rdbmale.Size = new System.Drawing.Size(72, 28);
            this.rdbmale.TabIndex = 5;
            this.rdbmale.TabStop = true;
            this.rdbmale.Text = "Male";
            this.rdbmale.UseVisualStyleBackColor = true;
            // 
            // txtcphone
            // 
            this.txtcphone.Location = new System.Drawing.Point(20, 132);
            this.txtcphone.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtcphone.MaxLength = 10;
            this.txtcphone.Name = "txtcphone";
            this.txtcphone.Size = new System.Drawing.Size(227, 28);
            this.txtcphone.TabIndex = 2;
            this.txtcphone.TextChanged += new System.EventHandler(this.txtcphone_TextChanged);
            this.txtcphone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcphone_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(299, 174);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 24);
            this.label2.TabIndex = 40;
            this.label2.Text = "Gender:";
            // 
            // txtcemail
            // 
            this.txtcemail.Location = new System.Drawing.Point(20, 209);
            this.txtcemail.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtcemail.MaxLength = 30;
            this.txtcemail.Name = "txtcemail";
            this.txtcemail.Size = new System.Drawing.Size(227, 28);
            this.txtcemail.TabIndex = 3;
            this.txtcemail.TextChanged += new System.EventHandler(this.txtcemail_TextChanged);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnupdate);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.btnsave);
            this.panel4.Location = new System.Drawing.Point(179, 357);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(263, 52);
            this.panel4.TabIndex = 63;
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.CadetBlue;
            this.btnupdate.Enabled = false;
            this.btnupdate.ForeColor = System.Drawing.Color.Black;
            this.btnupdate.Location = new System.Drawing.Point(15, 7);
            this.btnupdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(100, 42);
            this.btnupdate.TabIndex = 61;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Visible = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(149, 5);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 42);
            this.button1.TabIndex = 7;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.Green;
            this.btnsave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnsave.Location = new System.Drawing.Point(15, 5);
            this.btnsave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(100, 42);
            this.btnsave.TabIndex = 55;
            this.btnsave.Text = "Add";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CadetBlue;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(625, 60);
            this.panel2.TabIndex = 64;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Wingdings 2", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.button2.Location = new System.Drawing.Point(566, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(59, 60);
            this.button2.TabIndex = 11;
            this.button2.Text = "Ñ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(235, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(201, 46);
            this.label6.TabIndex = 10;
            this.label6.Text = "Customer";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(33, 374);
            this.txtid.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtid.MaxLength = 40;
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(52, 22);
            this.txtid.TabIndex = 65;
            this.txtid.Visible = false;
            // 
            // frmcustomeradd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 426);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmcustomeradd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmcustomeradd";
            this.Load += new System.EventHandler(this.frmcustomeradd_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtcname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbcaddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdbfemale;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rdbmale;
        private System.Windows.Forms.TextBox txtcphone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcemail;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Button btnsave;
        public System.Windows.Forms.TextBox txtid;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        public System.Windows.Forms.Button btnupdate;
    }
}