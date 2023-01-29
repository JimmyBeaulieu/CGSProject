using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CGS_DLL;

namespace CGS_Windows
{
    public partial class Login : Form
    {
        

        public Login()
        {
            InitializeComponent();
        }

        private void Submit_btn_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(@"C:\Users\gytim\source\repos\CGS\CGS_Windows\CGS_Windows\login.txt");
            //bool checker = false;
            string file = sr.ReadLine();
            sr.Close();
            if (file != null)
            {
                string[] users = file.Split('|');
                if (users[0] == loginBox.Text && users[1] == passwordBox.Text)
                {
                    MessageBox.Show("Allo :DDD");
                    mainForm form = new mainForm();
                    form.Visible = true;
                    this.Visible = false;
                }
            }
        }
        private void registerButton_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(@"C:\Users\gytim\source\repos\CGS\CGS_Windows\CGS_Windows\login.txt", true);
            sw.WriteLine(loginBox.Text + "|" + passwordBox.Text);
            sw.Close();
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
