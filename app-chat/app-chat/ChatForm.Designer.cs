namespace app_chat
{
    partial class ChatForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatForm));
            this.gunaPanel5 = new Guna.UI.WinForms.GunaPanel();
            this.txtTyping = new Guna.UI.WinForms.GunaTextBox();
            this.listViewMessage = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gunaPanel4 = new Guna.UI.WinForms.GunaPanel();
            this.UserLv = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.lbSignIn = new System.Windows.Forms.Label();
            this.txtNameChat = new Guna.UI.WinForms.GunaTextBox();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.thayĐổiThôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thayĐổiMậtKhẩuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSend = new Guna.UI.WinForms.GunaImageButton();
            this.gunaImageButton6 = new Guna.UI.WinForms.GunaImageButton();
            this.gunaImageButton5 = new Guna.UI.WinForms.GunaImageButton();
            this.btnReLoad = new Guna.UI.WinForms.GunaImageButton();
            this.btnJoin = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaImageButton4 = new Guna.UI.WinForms.GunaImageButton();
            this.gunaImageButton3 = new Guna.UI.WinForms.GunaImageButton();
            this.gunaImageButton2 = new Guna.UI.WinForms.GunaImageButton();
            this.gunaImageButton1 = new Guna.UI.WinForms.GunaImageButton();
            this.gunaCirclePictureBox1 = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.gunaPanel5.SuspendLayout();
            this.gunaPanel4.SuspendLayout();
            this.gunaPanel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaPanel5
            // 
            this.gunaPanel5.BackColor = System.Drawing.Color.White;
            this.gunaPanel5.Controls.Add(this.txtTyping);
            this.gunaPanel5.Controls.Add(this.btnSend);
            this.gunaPanel5.Controls.Add(this.gunaImageButton6);
            this.gunaPanel5.Controls.Add(this.gunaImageButton5);
            this.gunaPanel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gunaPanel5.Location = new System.Drawing.Point(373, 661);
            this.gunaPanel5.Name = "gunaPanel5";
            this.gunaPanel5.Size = new System.Drawing.Size(867, 67);
            this.gunaPanel5.TabIndex = 23;
            // 
            // txtTyping
            // 
            this.txtTyping.BackColor = System.Drawing.Color.Transparent;
            this.txtTyping.BaseColor = System.Drawing.Color.White;
            this.txtTyping.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(149)))), ((int)(((byte)(255)))));
            this.txtTyping.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTyping.FocusedBaseColor = System.Drawing.Color.White;
            this.txtTyping.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtTyping.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTyping.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTyping.Location = new System.Drawing.Point(118, 10);
            this.txtTyping.Name = "txtTyping";
            this.txtTyping.PasswordChar = '\0';
            this.txtTyping.Radius = 10;
            this.txtTyping.SelectedText = "";
            this.txtTyping.Size = new System.Drawing.Size(681, 47);
            this.txtTyping.TabIndex = 5;
            // 
            // listViewMessage
            // 
            this.listViewMessage.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listViewMessage.Dock = System.Windows.Forms.DockStyle.Top;
            this.listViewMessage.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(152)))), ((int)(((byte)(255)))));
            this.listViewMessage.HideSelection = false;
            this.listViewMessage.Location = new System.Drawing.Point(373, 0);
            this.listViewMessage.Margin = new System.Windows.Forms.Padding(1);
            this.listViewMessage.Name = "listViewMessage";
            this.listViewMessage.Size = new System.Drawing.Size(867, 665);
            this.listViewMessage.TabIndex = 24;
            this.listViewMessage.UseCompatibleStateImageBehavior = false;
            this.listViewMessage.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            this.columnHeader1.Width = 235;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader2.Width = 240;
            // 
            // gunaPanel4
            // 
            this.gunaPanel4.BackColor = System.Drawing.Color.White;
            this.gunaPanel4.Controls.Add(this.btnReLoad);
            this.gunaPanel4.Controls.Add(this.UserLv);
            this.gunaPanel4.Controls.Add(this.label1);
            this.gunaPanel4.Controls.Add(this.btnJoin);
            this.gunaPanel4.Controls.Add(this.lbSignIn);
            this.gunaPanel4.Controls.Add(this.txtNameChat);
            this.gunaPanel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.gunaPanel4.Location = new System.Drawing.Point(71, 0);
            this.gunaPanel4.Name = "gunaPanel4";
            this.gunaPanel4.Size = new System.Drawing.Size(302, 728);
            this.gunaPanel4.TabIndex = 22;
            // 
            // UserLv
            // 
            this.UserLv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.UserLv.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserLv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(152)))), ((int)(((byte)(255)))));
            this.UserLv.HideSelection = false;
            this.UserLv.Location = new System.Drawing.Point(0, 183);
            this.UserLv.Margin = new System.Windows.Forms.Padding(1);
            this.UserLv.Name = "UserLv";
            this.UserLv.Size = new System.Drawing.Size(301, 544);
            this.UserLv.TabIndex = 15;
            this.UserLv.UseCompatibleStateImageBehavior = false;
            this.UserLv.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "";
            this.columnHeader3.Width = 235;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader4.Width = 240;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(152)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(6, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 21);
            this.label1.TabIndex = 27;
            this.label1.Text = "Thành viên";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbSignIn
            // 
            this.lbSignIn.AutoSize = true;
            this.lbSignIn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSignIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(152)))), ((int)(((byte)(255)))));
            this.lbSignIn.Location = new System.Drawing.Point(6, 28);
            this.lbSignIn.Name = "lbSignIn";
            this.lbSignIn.Size = new System.Drawing.Size(44, 18);
            this.lbSignIn.TabIndex = 25;
            this.lbSignIn.Text = "Tên :";
            // 
            // txtNameChat
            // 
            this.txtNameChat.BackColor = System.Drawing.Color.Transparent;
            this.txtNameChat.BaseColor = System.Drawing.Color.White;
            this.txtNameChat.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(149)))), ((int)(((byte)(255)))));
            this.txtNameChat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNameChat.FocusedBaseColor = System.Drawing.Color.White;
            this.txtNameChat.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtNameChat.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNameChat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNameChat.Location = new System.Drawing.Point(56, 19);
            this.txtNameChat.Name = "txtNameChat";
            this.txtNameChat.PasswordChar = '\0';
            this.txtNameChat.Radius = 10;
            this.txtNameChat.SelectedText = "";
            this.txtNameChat.Size = new System.Drawing.Size(238, 36);
            this.txtNameChat.TabIndex = 1;
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(149)))), ((int)(((byte)(255)))));
            this.gunaPanel1.Controls.Add(this.gunaImageButton4);
            this.gunaPanel1.Controls.Add(this.gunaImageButton3);
            this.gunaPanel1.Controls.Add(this.gunaImageButton2);
            this.gunaPanel1.Controls.Add(this.gunaImageButton1);
            this.gunaPanel1.Controls.Add(this.gunaCirclePictureBox1);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(71, 728);
            this.gunaPanel1.TabIndex = 21;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thayĐổiThôngTinToolStripMenuItem,
            this.thayĐổiMậtKhẩuToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(201, 52);
            // 
            // thayĐổiThôngTinToolStripMenuItem
            // 
            this.thayĐổiThôngTinToolStripMenuItem.Name = "thayĐổiThôngTinToolStripMenuItem";
            this.thayĐổiThôngTinToolStripMenuItem.Size = new System.Drawing.Size(200, 24);
            this.thayĐổiThôngTinToolStripMenuItem.Text = "Thay đổi thông tin";
            this.thayĐổiThôngTinToolStripMenuItem.Click += new System.EventHandler(this.thayĐổiThôngTinToolStripMenuItem_Click);
            // 
            // thayĐổiMậtKhẩuToolStripMenuItem
            // 
            this.thayĐổiMậtKhẩuToolStripMenuItem.Name = "thayĐổiMậtKhẩuToolStripMenuItem";
            this.thayĐổiMậtKhẩuToolStripMenuItem.Size = new System.Drawing.Size(200, 24);
            this.thayĐổiMậtKhẩuToolStripMenuItem.Text = "Thay đổi mật khẩu";
            this.thayĐổiMậtKhẩuToolStripMenuItem.Click += new System.EventHandler(this.thayĐổiMậtKhẩuToolStripMenuItem_Click);
            // 
            // btnSend
            // 
            this.btnSend.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSend.Image = global::app_chat.Properties.Resources.send_2;
            this.btnSend.ImageSize = new System.Drawing.Size(40, 40);
            this.btnSend.Location = new System.Drawing.Point(806, 8);
            this.btnSend.Name = "btnSend";
            this.btnSend.OnHoverImage = null;
            this.btnSend.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.btnSend.Size = new System.Drawing.Size(49, 47);
            this.btnSend.TabIndex = 4;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // gunaImageButton6
            // 
            this.gunaImageButton6.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaImageButton6.Image = global::app_chat.Properties.Resources.gallery;
            this.gunaImageButton6.ImageSize = new System.Drawing.Size(40, 40);
            this.gunaImageButton6.Location = new System.Drawing.Point(64, 8);
            this.gunaImageButton6.Name = "gunaImageButton6";
            this.gunaImageButton6.OnHoverImage = null;
            this.gunaImageButton6.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.gunaImageButton6.Size = new System.Drawing.Size(49, 47);
            this.gunaImageButton6.TabIndex = 3;
            // 
            // gunaImageButton5
            // 
            this.gunaImageButton5.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaImageButton5.Image = global::app_chat.Properties.Resources.carbon_face_satisfied;
            this.gunaImageButton5.ImageSize = new System.Drawing.Size(40, 40);
            this.gunaImageButton5.Location = new System.Drawing.Point(6, 8);
            this.gunaImageButton5.Name = "gunaImageButton5";
            this.gunaImageButton5.OnHoverImage = null;
            this.gunaImageButton5.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.gunaImageButton5.Size = new System.Drawing.Size(49, 47);
            this.gunaImageButton5.TabIndex = 2;
            // 
            // btnReLoad
            // 
            this.btnReLoad.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnReLoad.Image = global::app_chat.Properties.Resources.maximize_circle1;
            this.btnReLoad.ImageSize = new System.Drawing.Size(25, 25);
            this.btnReLoad.Location = new System.Drawing.Point(262, 142);
            this.btnReLoad.Name = "btnReLoad";
            this.btnReLoad.OnHoverImage = null;
            this.btnReLoad.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.btnReLoad.Size = new System.Drawing.Size(34, 37);
            this.btnReLoad.TabIndex = 28;
            this.btnReLoad.Click += new System.EventHandler(this.btnReLoad_Click);
            // 
            // btnJoin
            // 
            this.btnJoin.AnimationHoverSpeed = 0.07F;
            this.btnJoin.AnimationSpeed = 0.03F;
            this.btnJoin.BackColor = System.Drawing.Color.Transparent;
            this.btnJoin.BaseColor = System.Drawing.Color.White;
            this.btnJoin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(152)))), ((int)(((byte)(255)))));
            this.btnJoin.BorderSize = 2;
            this.btnJoin.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnJoin.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnJoin.CheckedForeColor = System.Drawing.Color.White;
            this.btnJoin.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnJoin.CheckedImage")));
            this.btnJoin.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnJoin.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnJoin.FocusedColor = System.Drawing.Color.Empty;
            this.btnJoin.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJoin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(152)))), ((int)(((byte)(255)))));
            this.btnJoin.Image = null;
            this.btnJoin.ImageSize = new System.Drawing.Size(20, 20);
            this.btnJoin.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(152)))), ((int)(((byte)(255)))));
            this.btnJoin.Location = new System.Drawing.Point(56, 65);
            this.btnJoin.Name = "btnJoin";
            this.btnJoin.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(152)))), ((int)(((byte)(255)))));
            this.btnJoin.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(152)))), ((int)(((byte)(255)))));
            this.btnJoin.OnHoverForeColor = System.Drawing.Color.White;
            this.btnJoin.OnHoverImage = null;
            this.btnJoin.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(152)))), ((int)(((byte)(255)))));
            this.btnJoin.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(152)))), ((int)(((byte)(255)))));
            this.btnJoin.Radius = 15;
            this.btnJoin.Size = new System.Drawing.Size(238, 43);
            this.btnJoin.TabIndex = 26;
            this.btnJoin.Text = "Tham gia";
            this.btnJoin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnJoin.Click += new System.EventHandler(this.btnJoin_Click);
            // 
            // gunaImageButton4
            // 
            this.gunaImageButton4.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaImageButton4.Image = global::app_chat.Properties.Resources.star;
            this.gunaImageButton4.ImageSize = new System.Drawing.Size(40, 40);
            this.gunaImageButton4.Location = new System.Drawing.Point(9, 302);
            this.gunaImageButton4.Name = "gunaImageButton4";
            this.gunaImageButton4.OnHoverImage = null;
            this.gunaImageButton4.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.gunaImageButton4.Size = new System.Drawing.Size(52, 58);
            this.gunaImageButton4.TabIndex = 4;
            // 
            // gunaImageButton3
            // 
            this.gunaImageButton3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaImageButton3.Image = global::app_chat.Properties.Resources.setting_2;
            this.gunaImageButton3.ImageSize = new System.Drawing.Size(40, 40);
            this.gunaImageButton3.Location = new System.Drawing.Point(8, 643);
            this.gunaImageButton3.Name = "gunaImageButton3";
            this.gunaImageButton3.OnHoverImage = null;
            this.gunaImageButton3.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.gunaImageButton3.Size = new System.Drawing.Size(52, 58);
            this.gunaImageButton3.TabIndex = 3;
            // 
            // gunaImageButton2
            // 
            this.gunaImageButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaImageButton2.Image = global::app_chat.Properties.Resources.people1;
            this.gunaImageButton2.ImageSize = new System.Drawing.Size(40, 40);
            this.gunaImageButton2.Location = new System.Drawing.Point(8, 220);
            this.gunaImageButton2.Name = "gunaImageButton2";
            this.gunaImageButton2.OnHoverImage = null;
            this.gunaImageButton2.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.gunaImageButton2.Size = new System.Drawing.Size(52, 58);
            this.gunaImageButton2.TabIndex = 2;
            // 
            // gunaImageButton1
            // 
            this.gunaImageButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaImageButton1.Image = global::app_chat.Properties.Resources.message;
            this.gunaImageButton1.ImageSize = new System.Drawing.Size(40, 40);
            this.gunaImageButton1.Location = new System.Drawing.Point(9, 135);
            this.gunaImageButton1.Name = "gunaImageButton1";
            this.gunaImageButton1.OnHoverImage = null;
            this.gunaImageButton1.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.gunaImageButton1.Size = new System.Drawing.Size(52, 58);
            this.gunaImageButton1.TabIndex = 1;
            // 
            // gunaCirclePictureBox1
            // 
            this.gunaCirclePictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(149)))), ((int)(((byte)(255)))));
            this.gunaCirclePictureBox1.BaseColor = System.Drawing.Color.RosyBrown;
            this.gunaCirclePictureBox1.Image = global::app_chat.Properties.Resources.R;
            this.gunaCirclePictureBox1.Location = new System.Drawing.Point(8, 6);
            this.gunaCirclePictureBox1.Name = "gunaCirclePictureBox1";
            this.gunaCirclePictureBox1.Size = new System.Drawing.Size(53, 56);
            this.gunaCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaCirclePictureBox1.TabIndex = 0;
            this.gunaCirclePictureBox1.TabStop = false;
            this.gunaCirclePictureBox1.UseTransfarantBackground = false;
            // 
            // ChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1240, 728);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.gunaPanel5);
            this.Controls.Add(this.listViewMessage);
            this.Controls.Add(this.gunaPanel4);
            this.Controls.Add(this.gunaPanel1);
            this.Name = "ChatForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChatForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChatForm_FormClosing);
            this.Load += new System.EventHandler(this.ChatForm_Load);
            this.gunaPanel5.ResumeLayout(false);
            this.gunaPanel4.ResumeLayout(false);
            this.gunaPanel4.PerformLayout();
            this.gunaPanel1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaPanel gunaPanel5;
        private Guna.UI.WinForms.GunaTextBox txtTyping;
        private Guna.UI.WinForms.GunaImageButton btnSend;
        private Guna.UI.WinForms.GunaImageButton gunaImageButton6;
        private Guna.UI.WinForms.GunaImageButton gunaImageButton5;
        private System.Windows.Forms.ListView listViewMessage;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private Guna.UI.WinForms.GunaPanel gunaPanel4;
        private System.Windows.Forms.ListView UserLv;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaAdvenceButton btnJoin;
        private System.Windows.Forms.Label lbSignIn;
        private Guna.UI.WinForms.GunaTextBox txtNameChat;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaImageButton gunaImageButton4;
        private Guna.UI.WinForms.GunaImageButton gunaImageButton3;
        private Guna.UI.WinForms.GunaImageButton gunaImageButton2;
        private Guna.UI.WinForms.GunaImageButton gunaImageButton1;
        private Guna.UI.WinForms.GunaCirclePictureBox gunaCirclePictureBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thayĐổiThôngTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thayĐổiMậtKhẩuToolStripMenuItem;
        private Guna.UI.WinForms.GunaImageButton btnReLoad;
    }
}