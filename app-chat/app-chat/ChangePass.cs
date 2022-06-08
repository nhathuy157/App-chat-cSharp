using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app_chat
{
    public partial class ChangePass : Form
    {
        ClientControls clientControls;
        public ChangePass(ClientControls clientControls)
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
                this.Close();
                
            }
            else
            {
                MessageBox.Show(message);
            }
        }

        private bool valid()
        {
            if (txtOldPass.Text == "" || txtNewPass.Text == "" || txtConfirmNewPass.Text == "")
            {
                MessageBox.Show("Mật khẩu không được để trống !!");

                return false;
            }

            if (txtOldPass.Text != clientControls.ms.user.Password)
            {
                MessageBox.Show("Mật khẩu cũ không chính xác");

                return false;
            }

            if (txtNewPass.Text != txtConfirmNewPass.Text)
            {
                MessageBox.Show("Xác nhận mật khẩu không chính xác");

                return false;
            }

            return true;

        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            string newPass = txtNewPass.Text;
            
            if (valid())
            {
                clientControls.SendChangePass(newPass);
            }
        }
    }
}
