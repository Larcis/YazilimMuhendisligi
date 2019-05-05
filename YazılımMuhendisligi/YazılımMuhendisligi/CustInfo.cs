using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YazılımMuhendisligi
{
    public partial class CustInfo : Form
    {
        Label l_;
        public CustInfo(Label l)
        {
            InitializeComponent();
            l_ = l;
        }

  
        private void Button1_Click_1(object sender, EventArgs e)
        {
            l_.Text = textBox1.Text + " " + textBox2.Text + " " + textBox3.Text + " " + textBox4.Text;
            this.Close();
        }
    }
}
