namespace sportify
{
    partial class frmsupplieradd
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
            this.txtsname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rtbsaddress = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rdbfemale = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.rdbmale = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtsphone = new System.Windows.Forms.TextBox();
            this.txtsemail = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnupdate = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtid = new System.Windows.Forms.TextBox();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtsname);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.rtbsaddress);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.rdbfemale);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.rdbmale);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txtsphone);
            this.panel3.Controls.Add(this.txtsemail);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.panel3.Location = new System.Drawing.Point(29, 89);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(571, 293);
            this.panel3.TabIndex = 3;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // txtsname
            // 
            this.txtsname.Location = new System.Drawing.Point(29, 65);
            this.txtsname.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtsname.MaxLength = 40;
            this.txtsname.Name = "txtsname";
            this.txtsname.Size = new System.Drawing.Size(227, 28);
            this.txtsname.TabIndex = 1;
            this.txtsname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsname_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 24);
            this.label1.TabIndex = 44;
            this.label1.Text = "Name :";
            // 
            // rtbsaddress
            // 
            this.rtbsaddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbsaddress.Location = new System.Drawing.Point(323, 65);
            this.rtbsaddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbsaddress.MaxLength = 50;
            this.rtbsaddress.Name = "rtbsaddress";
            this.rtbsaddress.Size = new System.Drawing.Size(227, 96);
            this.rtbsaddress.TabIndex = 4;
            this.rtbsaddress.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 111);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 24);
            this.label3.TabIndex = 46;
            this.label3.Text = "Phone :";
            // 
            // rdbfemale
            // 
            this.rdbfemale.AutoSize = true;
            this.rdbfemale.Location = new System.Drawing.Point(425, 239);
            this.rdbfemale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbfemale.Name = "rdbfemale";
            this.rdbfemale.Size = new System.Drawing.Size(95, 28);
            this.rdbfemale.TabIndex = 6;
            this.rdbfemale.TabStop = true;
            this.rdbfemale.Text = "Female";
            this.rdbfemale.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 198);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 24);
            this.label4.TabIndex = 47;
            this.label4.Text = "Email :";
            // 
            // rdbmale
            // 
            this.rdbmale.AutoSize = true;
            this.rdbmale.Location = new System.Drawing.Point(323, 239);
            this.rdbmale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbmale.Name = "rdbmale";
            this.rdbmale.Size = new System.Drawing.Size(72, 28);
            this.rdbmale.TabIndex = 5;
            this.rdbmale.TabStop = true;
            this.rdbmale.Text = "Male";
            this.rdbmale.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(319, 25);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 24);
            this.label5.TabIndex = 48;
            this.label5.Text = "Address :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(319, 198);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 24);
            this.label2.TabIndex = 52;
            this.label2.Text = "Gender :";
            // 
            // txtsphone
            // 
            this.txtsphone.Location = new System.Drawing.Point(29, 153);
            this.txtsphone.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtsphone.MaxLength = 10;
            this.txtsphone.Name = "txtsphone";
            this.txtsphone.Size = new System.Drawing.Size(227, 28);
            this.txtsphone.TabIndex = 2;
            this.txtsphone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsphone_KeyPress);
            // 
            // txtsemail
            // 
            this.txtsemail.Location = new System.Drawing.Point(29, 239);
            this.txtsemail.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtsemail.MaxLength = 30;
            this.txtsemail.Name = "txtsemail";
            this.txtsemail.Size = new System.Drawing.Size(227, 28);
            this.txtsemail.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnupdate);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.btnsave);
            this.panel4.Location = new System.Drawing.Point(184, 391);
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
            this.btnupdate.TabIndex = 7;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Visible = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(141, 5);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 42);
            this.button1.TabIndex = 8;
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
            this.btnsave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnsave_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(151, 15);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(315, 46);
            this.label10.TabIndex = 10;
            this.label10.Text = "Supplier Details";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Wingdings 2", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.button2.Location = new System.Drawing.Point(564, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(59, 76);
            this.button2.TabIndex = 12;
            this.button2.Text = "Ñ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(623, 76);
            this.panel1.TabIndex = 64;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(17, 409);
            this.txtid.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtid.MaxLength = 40;
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(31, 22);
            this.txtid.TabIndex = 55;
            this.txtid.Visible = false;
            // 
            // frmsupplieradd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 459);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmsupplieradd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmsupplieradd";
            this.Load += new System.EventHandler(this.frmsupplieradd_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtsname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbsaddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdbfemale;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdbmale;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtsphone;
        private System.Windows.Forms.TextBox txtsemail;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button btnupdate;
        public System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtid;
    }
}