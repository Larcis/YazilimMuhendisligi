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
    public partial class AG_Panel : Form
    {
        public AG_Panel()
        {
            InitializeComponent();
            //dataGridView1.DataSource = Program.ctx.campaign.ToList<campaign>();
            foreach(var i in Program.ctx.campaign.ToList<campaign>())
            {
                if(!comboBox1.Items.Contains(i.originCity))
                    comboBox1.Items.Add(i.originCity);
               /* if (!comboBox2.Items.Contains(i.destinationCity))
                    comboBox2.Items.Add(i.destinationCity);*/
            }
        }
 
        private void Button1_Click(object sender, EventArgs e)
        {
            Program.ses.exit();
            Application.Exit();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dateTimePicker1.Value.CompareTo(0).ToString());
            dataGridView1.DataSource = Program.ctx.campaign
                .Where(x => x.originCity == comboBox1.Text && x.destinationCity == comboBox2.Text && x.date >= dateTimePicker1.Value.Date).Select(x => x)
                .ToList<campaign>();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var list = Program.ctx.campaign.Where(x => x.originCity == comboBox1.Text).Select(x => x).ToList();
            foreach(var i in list)
            {
                if (!comboBox2.Items.Contains(i.destinationCity))
                {
                    comboBox2.Items.Add(i.destinationCity);
                }
            }
        }
    }
}
