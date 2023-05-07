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
    public partial class log_in : Form
    {
        public log_in()
        {
            InitializeComponent();
        }
        Form1 f = new Form1();
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains("admin") && textBox2.Text.Contains("admin"))
            {
                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("رمز وارد شده نادرست است");
            }
            
        }
    }
}
