using app_chat.Controler;
using server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app_chat
{
    public partial class LoginForm : Form
    {
        //convert cvt = new convert();
        //Messages ms = new Messages();


        //IPEndPoint IP;
        //Socket client;

        ClientControls clientControls;

        public LoginForm(ClientControls clientControls )
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

        

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbSignUp_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp(clientControls);
            signUp.ShowDialog();
           
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string userName = txtAccount.Text.Trim();
            string password = txtPassword.Text.Trim();

            clientControls.SendLogin(userName, password);
        }
    }
}
