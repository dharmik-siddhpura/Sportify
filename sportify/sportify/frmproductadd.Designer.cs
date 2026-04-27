namespace sportify
{
    partial class frmproductadd
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
            this.txtid = new System.Windows.Forms.TextBox();
            this.cmbbrand = new System.Windows.Forms.ComboBox();
            this.cmbcolor = new System.Windows.Forms.ComboBox();
            this.cmbcategory = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtpname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtpmodel = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtpwarranty = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtpweight = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnupdate = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtid);
            this.panel3.Controls.Add(this.cmbbrand);
            this.panel3.Controls.Add(this.cmbcolor);
            this.panel3.Controls.Add(this.cmbcategory);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txtpname);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txtpmodel);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.txtpwarranty);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.txtpweight);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.panel3.Location = new System.Drawing.Point(77, 67);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(653, 325);
            this.panel3.TabIndex = 3;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(357, 269);
            this.txtid.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtid.MaxLength = 40;
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(52, 28);
            this.txtid.TabIndex = 66;
            this.txtid.Visible = false;
            // 
            // cmbbrand
            // 
            this.cmbbrand.FormattingEnabled = true;
            this.cmbbrand.Location = new System.Drawing.Point(58, 268);
            this.cmbbrand.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbbrand.Name = "cmbbrand";
            this.cmbbrand.Size = new System.Drawing.Size(244, 30);
            this.cmbbrand.TabIndex = 4;
            // 
            // cmbcolor
            // 
            this.cmbcolor.FormattingEnabled = true;
            this.cmbcolor.Location = new System.Drawing.Point(357, 62);
            this.cmbcolor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbcolor.Name = "cmbcolor";
            this.cmbcolor.Size = new System.Drawing.Size(244, 30);
            this.cmbcolor.TabIndex = 5;
            // 
            // cmbcategory
            // 
            this.cmbcategory.FormattingEnabled = true;
            this.cmbcategory.Location = new System.Drawing.Point(58, 62);
            this.cmbcategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbcategory.Name = "cmbcategory";
            this.cmbcategory.Size = new System.Drawing.Size(244, 30);
            this.cmbcategory.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(58, 31);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 24);
            this.label11.TabIndex = 48;
            this.label11.Text = "Category:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 101);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 24);
            this.label1.TabIndex = 24;
            this.label1.Text = "Name:";
            // 
            // txtpname
            // 
            this.txtpname.Location = new System.Drawing.Point(58, 132);
            this.txtpname.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtpname.Name = "txtpname";
            this.txtpname.Size = new System.Drawing.Size(244, 28);
            this.txtpname.TabIndex = 2;
            this.txtpname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpname_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 237);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 24);
            this.label2.TabIndex = 26;
            this.label2.Text = "Brand:";
            // 
            // txtpmodel
            // 
            this.txtpmodel.Location = new System.Drawing.Point(58, 200);
            this.txtpmodel.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtpmodel.Name = "txtpmodel";
            this.txtpmodel.Size = new System.Drawing.Size(244, 28);
            this.txtpmodel.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(58, 168);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 24);
            this.label9.TabIndex = 40;
            this.label9.Text = "Model:";
            // 
            // txtpwarranty
            // 
            this.txtpwarranty.Location = new System.Drawing.Point(357, 200);
            this.txtpwarranty.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtpwarranty.Name = "txtpwarranty";
            this.txtpwarranty.Size = new System.Drawing.Size(244, 28);
            this.txtpwarranty.TabIndex = 7;
            this.txtpwarranty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpwarranty_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(357, 168);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 24);
            this.label8.TabIndex = 38;
            this.label8.Text = "Warranty:";
            // 
            // txtpweight
            // 
            this.txtpweight.Location = new System.Drawing.Point(357, 132);
            this.txtpweight.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtpweight.Name = "txtpweight";
            this.txtpweight.Size = new System.Drawing.Size(244, 28);
            this.txtpweight.TabIndex = 6;
            this.txtpweight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpweight_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(357, 101);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 24);
            this.label7.TabIndex = 36;
            this.label7.Text = "Weight:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(357, 31);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 24);
            this.label6.TabIndex = 34;
            this.label6.Text = "Color:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnupdate);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.btnsave);
            this.panel4.Location = new System.Drawing.Point(283, 414);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(239, 56);
            this.panel4.TabIndex = 63;
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.CadetBlue;
            this.btnupdate.Enabled = false;
            this.btnupdate.ForeColor = System.Drawing.Color.Black;
            this.btnupdate.Location = new System.Drawing.Point(12, 7);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 62);
            this.panel1.TabIndex = 64;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Wingdings 2", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.button2.Location = new System.Drawing.Point(759, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(44, 62);
            this.button2.TabIndex = 12;
            this.button2.Text = "Ñ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(319, 12);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(307, 46);
            this.label10.TabIndex = 10;
            this.label10.Text = "Product Details";
            // 
            // frmproductadd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 496);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmproductadd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmproductadd";
            this.Load += new System.EventHandler(this.frmproductadd_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cmbcolor;
        private System.Windows.Forms.ComboBox cmbcategory;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtpname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtpmodel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtpwarranty;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtpweight;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.Button btnupdate;
        public System.Windows.Forms.Button btnsave;
        public System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.ComboBox cmbbrand;
    }
}