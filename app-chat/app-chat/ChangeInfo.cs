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
    public partial class ChangeInfo : Form
    {
        ClientControls clientControls;
        public ChangeInfo(ClientControls clientControls)
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string note = txtNote.Text.Trim();
            DateTime dayofBirth = dtpDayOfBirth.Value;

            clientControls.SendChangeInfo(name, note, dayofBirth);

        }
    }
}
