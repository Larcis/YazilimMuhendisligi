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
                System.Windows.Forms.Application.Exit();
            }
        }

        private void Login_button_Click(object sender, EventArgs e)
        {
            String un = username.Text;
            String passw = password.Text;
            Image img;
            Boolean isValid = un.Equals("uygar");
            if (isValid){
                img = new Bitmap(Properties.Resources.login_green);
                login_warn.Visible = false;
            }
            else
            {
                img = new Bitmap(Properties.Resources.login_red);
                login_warn.Visible = true;
            }
            this.BackgroundImage = img;
            if (isValid){
                //MessageBox.Show("username: " + un + "\npassword: " + passw, "aasd");
                System.Threading.Thread.Sleep(100);

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
