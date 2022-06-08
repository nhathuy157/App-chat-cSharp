using app_chat.Controler;
using server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace app_chat
{
    
    public partial class SignUp : Form
    {

        ClientControls clientControls;

        public SignUp(ClientControls clientControls)
        {
            InitializeComponent();
            this.clientControls = clientControls;
            CheckForIllegalCrossThreadCalls = false;
            this.clientControls.callMessageBox = new ClientControls.CallMessageBox(callMessageBox);

        }

        private void callMessageBox(string message, bool check)
        {
            if (check)
            {
                MessageBox.Show(message);
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show(message);
            }
        }

        private bool valid()
        {
            if (txtAcc.Text == "" || txtConfirmPass.Text == "" || txtPass.Text == "")
            {
                MessageBox.Show("Tên đăng nhập, mật khẩu không được để trống !!");

                return false;
            }

            if (txtPass.Text != txtConfirmPass.Text)
            {
                MessageBox.Show("Xác nhận mật khẩu không chính xác");

                return false;
            }

            return true;

        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbSignIn_Click(object sender, EventArgs e)
        {
          

        }

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            string user = txtAcc.Text;
            string pass = txtPass.Text;
            if (valid())
            {
                clientControls.SendRegister(user, pass);
            }
        }
    }
}
