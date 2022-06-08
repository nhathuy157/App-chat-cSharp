using app_chat.Controler;
using server;
using server.Model;
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
    public partial class ChatForm : Form
    {
        ClientControls clientControls = new ClientControls();
        LoginForm loginForm;
        List<String> listchat;
        public ChatForm()
        {
            clientControls.Connect();
            loginForm = new LoginForm(clientControls);
            loginForm.ShowDialog();
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            this.clientControls.callMessageBox = new ClientControls.CallMessageBox(callMessageBox);
            this.clientControls.ShowMessage = new ClientControls.ShowMessageBox(ShowMessage);
            this.clientControls.getUName = new ClientControls.GetUName(getUName);
            
        }

        private void callMessageBox(string message, bool check)
        {
            if (check)
            {
                MessageBox.Show(message);
               if( DialogResult == DialogResult.OK)
                {
                    this.Close();
                }
                
            }
            else
            {
                MessageBox.Show(message);
            }
        }

        void ShowMessage(string s, bool b)
        {
            if (b)
            {
                ListViewItem ivi = new ListViewItem("");
                ivi.SubItems.Add(s);
                listViewMessage.Items.Add(ivi);
            }
            else
            {
                ListViewItem ivi = new ListViewItem(s);
                ivi.SubItems.Add("");
                listViewMessage.Items.Add(ivi);
            }
        }
        
        void getUName(List<String> listchat)
        {
            
           
            this.UserLv.Items.Clear();
            foreach (var uname in listchat)
            {
                this.UserLv.Items.Add(uname);
            }
            
        }
        
        

        private void ChatForm_Load(object sender, EventArgs e)
        {
        }

      

        

        private void btnJoin_Click(object sender, EventArgs e)
        {
            string uname = txtNameChat.Text;
            if (btnJoin.Text == "Tham gia")
            {              
                clientControls.SendJoinChat(uname);
                btnJoin.Text = "Rời khỏi";
            }
            else
            {

                clientControls.SendOutChat(uname);
                btnJoin.Text = "Tham gia";
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string text = txtTyping.Text;
            string uName = txtNameChat.Text;

            if (text != "")
            {
                clientControls.SendChat(text, uName);
                ShowMessage(txtTyping.Text, true);
                txtTyping.Clear();
                txtTyping.Focus();
            }
            else
            {
                return;
            }
        }

        private void ChatForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            string uname = txtNameChat.Text; 
            DialogResult result = MessageBox.Show("Bạn chắc chắn muốn đăng xuất không", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                // Send("logout");
                clientControls.Send("logout");
                clientControls.SendOutChat(uname);
              //  getUName();
            }
            else
            {

            }
        }

        private void thayĐổiThôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeInfo changeInfo = new ChangeInfo(clientControls);
            changeInfo.ShowDialog();

        }

        private void thayĐổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePass changePass = new ChangePass(clientControls);
            changePass.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnReLoad_Click(object sender, EventArgs e)
        {
            this.clientControls.getUName = new ClientControls.GetUName(getUName);
           
        }
    }
}
