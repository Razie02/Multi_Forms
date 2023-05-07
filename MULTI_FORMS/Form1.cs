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
    public partial class Form1 : Form
    {
        pay_form pf = new pay_form();
        search_form sf = new search_form();
        public Form1()
        { 
            InitializeComponent();
            pf.f = this;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            pf.Show(); 
        }
    }
}
