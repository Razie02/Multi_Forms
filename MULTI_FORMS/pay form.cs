using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MULTI_FORMS
{
    public partial class pay_form : Form
    {
        search_form sf = new search_form();
        public Form1 f;
        
        public pay_form()
        {
            InitializeComponent();
            sf.pf = this;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            sf.Show();
            sf.textBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                MessageBox.Show("اطلاعات وارد نشده است");
            }
            else if (textBox1.Text == "")
            {
                MessageBox.Show("اطلاعات وارد نشده است");
            }
            else
            {
                f.listBox1.Items.Add(" مقدار شهریه:" + textBox2.Text + "  کد دانشجو:" + textBox1.Text);
                textBox1.Text = "";
                textBox2.Text = "";
                this.Hide();
            }
        }

        private void pay_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }
    }
}
