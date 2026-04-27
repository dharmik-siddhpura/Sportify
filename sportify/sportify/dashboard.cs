using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sportify
{
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void close_child()
        {
            foreach (Form f in this.MdiChildren)
            {
                f.Hide();
                f.Close();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            close_child();
            frmcustomer c1 = new frmcustomer();
            c1.MdiParent = this;
            c1.Dock = DockStyle.Fill;
            c1.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            close_child();
            frmproduct pr = new frmproduct();
            pr.MdiParent = this;
            pr.Dock = DockStyle.Fill;
            pr.Show();
            
        }

        private void btnpurchase_Click(object sender, EventArgs e)
        {
            close_child();
            frmpurchase pur = new frmpurchase();
            pur.MdiParent = this;
            pur.Dock = DockStyle.Fill;
            pur.Show();
        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            
        }

        private void btnsales_Click(object sender, EventArgs e)
        {
            close_child();
            frmsales sales = new frmsales();
            sales.MdiParent = this;            
            sales.Dock = DockStyle.Fill;
            sales.Show();
        }

        private void btndealers_Click(object sender, EventArgs e)
        {
            close_child();
            frmsupplier supplier = new frmsupplier();
            supplier.MdiParent = this;
            supplier.Dock = DockStyle.Fill;
            supplier.Show();
        }

        private void btncustomization_Click(object sender, EventArgs e)
        {
            close_child();
            frmcustomization custo = new frmcustomization();
            custo.MdiParent = this;
            custo.Dock = DockStyle.Fill;
            custo.Show();
        }

        private void othersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void colorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            close_child();
            frmcolor color = new frmcolor();
            color.MdiParent = this;
            color.Dock = DockStyle.Fill;
            color.Show();

        }

        private void taxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            close_child();
            frmtax tax = new frmtax();
            tax.MdiParent = this;
            tax.Dock = DockStyle.Fill;
            tax.Show();
        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            close_child();
            frmcategory cat = new frmcategory();
            cat.MdiParent = this;
            cat.Dock = DockStyle.Fill;
            cat.Show();
        }

        private void discountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            close_child();
            frmdiscount dis = new frmdiscount();
            dis.MdiParent = this;
            dis.Dock = DockStyle.Fill;
            dis.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void paymentMethodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            close_child();
            frmpaymentmethod fpm = new frmpaymentmethod();
            fpm.MdiParent = this;
            fpm.Dock = DockStyle.Fill;
            fpm.Show();
        }

        private void brandToolStripMenuItem_Click(object sender, EventArgs e)
        {

            close_child();
            frmbrand fb = new frmbrand();
            fb.MdiParent = this;
            fb.Dock = DockStyle.Fill;
            fb.Show();
        }

        private void btnstaff_Click(object sender, EventArgs e)
        {
            close_child();
            frmstaff st = new frmstaff();
            st.MdiParent = this;
            st.Dock = DockStyle.Fill;
            st.Show();
        }
    }
}
