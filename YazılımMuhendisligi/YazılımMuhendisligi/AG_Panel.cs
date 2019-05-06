using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IronPdf;
namespace YazılımMuhendisligi
{
    public partial class AG_Panel : Form
    {
        private campaign cur_camp;
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
            //MessageBox.Show(dateTimePicker1.Value.ToString());
           /* var qry = from st in Program.ctx.campaign
                      where st.originCity == "asd"
                      select st;
            var res = qry.FirstOrDefault();*/
            //TODO: date kucuktur, verei tabanı duzgun doldurulduktan sonra buyuktur ile degistirilecek
            dataGridView1.DataSource = Program.ctx.campaign
                .Where(x => x.originCity == comboBox1.Text && 
                            x.destinationCity == comboBox2.Text && 
                            x.date >= dateTimePicker1.Value.Date&&
                            x.capacity > 0) 
                .Select(x => x)
                .ToList<campaign>();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            var list = Program.ctx.campaign.Where(x => x.originCity == comboBox1.Text).Select(x => x).ToList();
           
            comboBox2.Items.Clear();
            foreach (var i in list)
            {
                if (!comboBox2.Items.Contains(i.destinationCity))
                {
                    comboBox2.Items.Add(i.destinationCity);
                }
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            var row = dataGridView1.SelectedRows;
            if (row.Count != 0)
            {
                String id = row[0].Cells["campaignID"].Value.ToString();
                cur_camp = Program.ctx.campaign.SingleOrDefault(x => x.campaignID.ToString() == id);
                if (cur_camp != null)
                {
                    this.Enabled = false;
                    CustInfo frm = new CustInfo(label4);
                    frm.Show();
                }
                
            }
            else
            {
                MessageBox.Show("You must select a ticket first!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
            }
        }
        private void printPdf(string[] cust)
        {
            System.IO.Directory.CreateDirectory("tickets");
            String fname = "tickets\\"+cust[0] + "_" + cust[1] + ".pdf";
            String template = @"<html><head></head><body><table><caption><b>Ticket Information</b></caption><tr><td><b>Name:</b></td><td>{0}</td></tr><tr><td><b>Surname:</b></td><td>{1}</td></tr><tr><td><b>Tel. No:</b></td><td>{2}</td></tr><tr><td><b>Email:</b></td><td>{3}</td></tr><tr><td><b>Date:</b></td><td>{4}</td></tr><tr><td><b>Origin City:</b></td><td>{5}</td></tr><tr><td><b>Destination City:</b></td><td>{6}</td></tr><tr><td><b>Price:</b></td><td>{7}</td></tr></table></body></html>";
            IronPdf.HtmlToPdf Renderer = new IronPdf.HtmlToPdf();
            
            Renderer.RenderHtmlAsPdf(String.Format(template, cust[0], cust[1], cust[3], cust[2], 
                                    cur_camp.date.Date.ToString(),cur_camp.originCity.ToString(), cur_camp.destinationCity.ToString()
                                    ,cur_camp.price.ToString())).SaveAs(fname);
            try
            {
                Process.Start(fname);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.ToString());
            }
            this.CenterToScreen();
            
        }
        private void Label4_TextChanged(object sender, EventArgs e)
        {
            this.Enabled = true;
            var lst = label4.Text.Split(" ".ToCharArray());

            label4.TextChanged -= Label4_TextChanged;
            label4.Text = "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx";
            label4.TextChanged += Label4_TextChanged;
            foreach (var i in lst)
            {
                if (i.Length == 0)
                {
                    MessageBox.Show("Every Customer info must be filled!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            cur_camp.capacity -= 1;
            Program.ctx.SaveChanges();

            //BUG: formun resolutionu değişiyor
            printPdf(lst);
            //MessageBox.Show("Ticket sold to "+lst[0]+" "+ lst[1]+ "!");

        }
    }
}
