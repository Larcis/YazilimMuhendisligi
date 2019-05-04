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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            login_warn.Focus();
            username.Text = "Username";
        }

        private void Exitb_Click(object sender, EventArgs e)
        {
            string message = "Do you want to exit?";
            string title = "Close App";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                Program.ses.exit();
                Application.Exit();
            }
        }

        private void Login_button_Click(object sender, EventArgs e)
        {
            String un = username.Text;
            String passw = password.Text;
            Image img;
            var qry = from r in Program.ctx.uuser
                      where r.userName == un && r.password == passw
                      select r;
            var isValid = qry.FirstOrDefault();

            //MessageBox.Show(isValid.type);
            if (isValid != null){
                img = new Bitmap(Properties.Resources.login_green);
                login_warn.Visible = false;
            }
            else
            {
                img = new Bitmap(Properties.Resources.login_red);
                login_warn.Visible = true;
            }
            this.BackgroundImage = img;
            if (isValid != null){
                //MessageBox.Show("username: " + un + "\npassword: " + passw, "aasd");
                System.Threading.Thread.Sleep(100);
                Hide();
                AG_Panel pn = new AG_Panel();
                pn.Show();

            }
        }
      
        private void Password_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter){
                Login_button_Click(this, new EventArgs());
            }
        }

        private void Username_Enter(object sender, EventArgs e)
        {
            username.Text = "";
        }

        private void Password_Enter(object sender, EventArgs e)
        {
            password.Text = "";
        }
    }
}
