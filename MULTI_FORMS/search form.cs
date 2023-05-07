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
    public partial class search_form : Form
    {
        public pay_form pf;

        public search_form()
        {
            InitializeComponent();
        }

        private void search_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains("راضیه ترسه"))
            {
                pf.textBox1.Text = "140112028";
                this.Hide();
            }
            else
            {
                MessageBox.Show("کد دانشجویی با این اسم یافت نشد");
            }
        }
    }
}
