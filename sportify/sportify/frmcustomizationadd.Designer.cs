namespace sportify
{
    partial class frmcustomizationadd
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.rtb = new System.Windows.Forms.RichTextBox();
            this.cmbcategory = new System.Windows.Forms.ComboBox();
            this.cmbdiscount = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbtax = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txttp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtqty = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnupdate = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rtb);
            this.panel2.Controls.Add(this.cmbcategory);
            this.panel2.Controls.Add(this.cmbdiscount);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cmbtax);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txttp);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtprice);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtqty);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtname);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.panel2.Location = new System.Drawing.Point(28, 94);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(605, 374);
            this.panel2.TabIndex = 46;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // rtb
            // 
            this.rtb.Location = new System.Drawing.Point(37, 222);
            this.rtb.Margin = new System.Windows.Forms.Padding(4);
            this.rtb.MaxLength = 200;
            this.rtb.Name = "rtb";
            this.rtb.Size = new System.Drawing.Size(228, 52);
            this.rtb.TabIndex = 3;
            this.rtb.Text = "";
            // 
            // cmbcategory
            // 
            this.cmbcategory.FormattingEnabled = true;
            this.cmbcategory.Location = new System.Drawing.Point(37, 65);
            this.cmbcategory.Margin = new System.Windows.Forms.Padding(4);
            this.cmbcategory.Name = "cmbcategory";
            this.cmbcategory.Size = new System.Drawing.Size(228, 30);
            this.cmbcategory.TabIndex = 1;
            // 
            // cmbdiscount
            // 
            this.cmbdiscount.FormattingEnabled = true;
            this.cmbdiscount.Location = new System.Drawing.Point(331, 241);
            this.cmbdiscount.Margin = new System.Windows.Forms.Padding(4);
            this.cmbdiscount.Name = "cmbdiscount";
            this.cmbdiscount.Size = new System.Drawing.Size(228, 30);
            this.cmbdiscount.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 24);
            this.label1.TabIndex = 26;
            this.label1.Text = "Category : ";
            // 
            // cmbtax
            // 
            this.cmbtax.FormattingEnabled = true;
            this.cmbtax.Location = new System.Drawing.Point(331, 154);
            this.cmbtax.Margin = new System.Windows.Forms.Padding(4);
            this.cmbtax.Name = "cmbtax";
            this.cmbtax.Size = new System.Drawing.Size(228, 30);
            this.cmbtax.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 24);
            this.label2.TabIndex = 27;
            this.label2.Text = "Name : ";
            // 
            // txttp
            // 
            this.txttp.Location = new System.Drawing.Point(331, 327);
            this.txttp.Margin = new System.Windows.Forms.Padding(4);
            this.txttp.Name = "txttp";
            this.txttp.ReadOnly = true;
            this.txttp.Size = new System.Drawing.Size(228, 28);
            this.txttp.TabIndex = 41;
            this.txttp.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 185);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 24);
            this.label3.TabIndex = 28;
            this.label3.Text = "Details : ";
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(331, 69);
            this.txtprice.Margin = new System.Windows.Forms.Padding(4);
            this.txtprice.MaxLength = 7;
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(228, 28);
            this.txtprice.TabIndex = 5;
            this.txtprice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtprice_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 292);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 24);
            this.label4.TabIndex = 29;
            this.label4.Text = "Quantity : ";
            // 
            // txtqty
            // 
            this.txtqty.Location = new System.Drawing.Point(37, 327);
            this.txtqty.Margin = new System.Windows.Forms.Padding(4);
            this.txtqty.MaxLength = 3;
            this.txtqty.Name = "txtqty";
            this.txtqty.Size = new System.Drawing.Size(228, 28);
            this.txtqty.TabIndex = 4;
            this.txtqty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtqty_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(331, 30);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 24);
            this.label5.TabIndex = 30;
            this.label5.Text = "Price : ";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(37, 144);
            this.txtname.Margin = new System.Windows.Forms.Padding(4);
            this.txtname.MaxLength = 30;
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(228, 28);
            this.txtname.TabIndex = 2;
            this.txtname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtname_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(331, 114);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 24);
            this.label6.TabIndex = 31;
            this.label6.Text = "Tax : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(331, 201);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 24);
            this.label7.TabIndex = 32;
            this.label7.Text = "Discount : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(331, 288);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 24);
            this.label8.TabIndex = 33;
            this.label8.Text = "Total Price : ";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnupdate);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.btnsave);
            this.panel4.Location = new System.Drawing.Point(192, 470);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(272, 50);
            this.panel4.TabIndex = 62;
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.CadetBlue;
            this.btnupdate.Enabled = false;
            this.btnupdate.ForeColor = System.Drawing.Color.Black;
            this.btnupdate.Location = new System.Drawing.Point(15, 6);
            this.btnupdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(100, 42);
            this.btnupdate.TabIndex = 8;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Visible = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(155, 5);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 42);
            this.button1.TabIndex = 9;
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.CadetBlue;
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(660, 76);
            this.panel3.TabIndex = 63;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Wingdings 2", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.button2.Location = new System.Drawing.Point(601, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(59, 76);
            this.button2.TabIndex = 12;
            this.button2.Text = "Ñ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(199, 15);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(287, 46);
            this.label9.TabIndex = 10;
            this.label9.Text = "Customization";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(13, 508);
            this.txtid.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtid.MaxLength = 40;
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(52, 22);
            this.txtid.TabIndex = 66;
            this.txtid.Visible = false;
            // 
            // frmcustomizationadd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 545);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmcustomizationadd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmcustomizationadd";
            this.Load += new System.EventHandler(this.frmcustomizationadd_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox rtb;
        private System.Windows.Forms.ComboBox cmbcategory;
        private System.Windows.Forms.ComboBox cmbdiscount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbtax;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtqty;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button btnupdate;
        public System.Windows.Forms.Button btnsave;
        public System.Windows.Forms.TextBox txtid;
    }
}