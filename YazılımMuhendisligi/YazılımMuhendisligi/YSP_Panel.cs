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
    public partial class YSP_Panel : Form
    {
        public YSP_Panel()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Program.ses.exit();
            Application.Exit();
        }

        private void Add_user_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length > 0 && textBox2.Text.Length > 0 && comboBox1.Text.Length > 0)
            {
                var usr = new uuser()
                {
                    userName = textBox1.Text,
                    password = textBox2.Text,
                    type = comboBox1.Text
                };
               try
                {
                    Program.ctx.uuser.Add(usr);
                    Program.ctx.SaveChanges();
                    MessageBox.Show("User added succesfully!");
                }catch(Exception ex)
                {
                    Program.ctx.uuser.Remove(usr);
                    MessageBox.Show("User not added because "+ex.Message + "! You should try another username!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please fill all info about user!", "Warning!" , MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Program.ctx.uuser
            .Select(x => x)
            .ToList<uuser>();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            var row = dataGridView1.SelectedRows;
            if (row.Count != 0)
            {
                String id = row[0].Cells["userName"].Value.ToString();
                var usr= Program.ctx.uuser.SingleOrDefault(x => x.userName.ToString() == id);
                if (usr != null)
                {
                    Program.ctx.uuser.Remove(usr);
                    try
                    {
                        Program.ctx.SaveChanges();
                    }catch(Exception ex)
                    {
                        MessageBox.Show("An error occured while changing database! "+ex.Message, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    MessageBox.Show("User deleted succesfully!");
                    Update_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Entry not found!");
                }

            }
            else
            {
                MessageBox.Show("You must select a user first!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private void AddCompany_Click(object sender, EventArgs e)
        {
            var _1 = textBox3.Text;
            var _2 = textBox4.Text;
            if(_1.Length > 0 && _2.Length > 0)
            {
                var comp = new travelcompany()
                {
                    name = _1,
                    pointCoefficient = Convert.ToDouble(_2)
                };
                try
                {
                    Program.ctx.travelcompany.Add(comp);
                    Program.ctx.SaveChanges();
                    MessageBox.Show("User added succesfully!");
                }
                catch (Exception ex)
                {
                    Program.ctx.travelcompany.Remove(comp);
                    MessageBox.Show("Company not added because " + ex.Message + "! You should try another company name!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please fill all info about company!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Update_company_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = Program.ctx.travelcompany
           .Select(x => x)
           .ToList<travelcompany>();
        }

        private void Delete_company_Click(object sender, EventArgs e)
        {
            var row = dataGridView2.SelectedRows;
            if (row.Count != 0)
            {
                String id = row[0].Cells["name"].Value.ToString();
                var comp = Program.ctx.travelcompany.SingleOrDefault(x => x.name.ToString() == id);
                if (comp != null)
                {
                    Program.ctx.travelcompany.Remove(comp);
                    try
                    {
                        Program.ctx.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occured while changing database! " + ex.Message, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    MessageBox.Show("Company deleted succesfully!");
                    Update_company_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Entry not found!");
                }

            }
            else
            {
                MessageBox.Show("You must select a Company first!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
