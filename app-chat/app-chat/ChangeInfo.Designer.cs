namespace app_chat
{
    partial class ChangeInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeInfo));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNote = new Guna.UI.WinForms.GunaTextBox();
            this.txtName = new Guna.UI.WinForms.GunaTextBox();
            this.dtpDayOfBirth = new Guna.UI.WinForms.GunaDateTimePicker();
            this.btnUpdate = new Guna.UI.WinForms.GunaAdvenceButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(152)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(21, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 21);
            this.label1.TabIndex = 28;
            this.label1.Text = "Họ tên :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(152)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(21, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 21);
            this.label2.TabIndex = 29;
            this.label2.Text = "Ghi chú :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(152)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(21, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 21);
            this.label3.TabIndex = 30;
            this.label3.Text = "Ngày sinh :";
            // 
            // txtNote
            // 
            this.txtNote.BackColor = System.Drawing.Color.Transparent;
            this.txtNote.BaseColor = System.Drawing.Color.White;
            this.txtNote.BorderColor = System.Drawing.Color.Silver;
            this.txtNote.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNote.FocusedBaseColor = System.Drawing.Color.White;
            this.txtNote.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtNote.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNote.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNote.Location = new System.Drawing.Point(135, 144);
            this.txtNote.Name = "txtNote";
            this.txtNote.PasswordChar = '\0';
            this.txtNote.Radius = 10;
            this.txtNote.SelectedText = "";
            this.txtNote.Size = new System.Drawing.Size(354, 131);
            this.txtNote.TabIndex = 31;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.Transparent;
            this.txtName.BaseColor = System.Drawing.Color.White;
            this.txtName.BorderColor = System.Drawing.Color.Silver;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.FocusedBaseColor = System.Drawing.Color.White;
            this.txtName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtName.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(135, 21);
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.Radius = 10;
            this.txtName.SelectedText = "";
            this.txtName.Size = new System.Drawing.Size(354, 43);
            this.txtName.TabIndex = 32;
            // 
            // dtpDayOfBirth
            // 
            this.dtpDayOfBirth.BackColor = System.Drawing.Color.Transparent;
            this.dtpDayOfBirth.BaseColor = System.Drawing.Color.White;
            this.dtpDayOfBirth.BorderColor = System.Drawing.Color.Silver;
            this.dtpDayOfBirth.CustomFormat = null;
            this.dtpDayOfBirth.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpDayOfBirth.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpDayOfBirth.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpDayOfBirth.ForeColor = System.Drawing.Color.Black;
            this.dtpDayOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDayOfBirth.Location = new System.Drawing.Point(136, 83);
            this.dtpDayOfBirth.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpDayOfBirth.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpDayOfBirth.Name = "dtpDayOfBirth";
            this.dtpDayOfBirth.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtpDayOfBirth.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpDayOfBirth.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpDayOfBirth.OnPressedColor = System.Drawing.Color.Black;
            this.dtpDayOfBirth.Radius = 5;
            this.dtpDayOfBirth.Size = new System.Drawing.Size(354, 38);
            this.dtpDayOfBirth.TabIndex = 33;
            this.dtpDayOfBirth.Text = "6/5/2022";
            this.dtpDayOfBirth.Value = new System.DateTime(2022, 6, 5, 0, 0, 0, 0);
            // 
            // btnUpdate
            // 
            this.btnUpdate.AnimationHoverSpeed = 0.07F;
            this.btnUpdate.AnimationSpeed = 0.03F;
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.BaseColor = System.Drawing.Color.White;
            this.btnUpdate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(152)))), ((int)(((byte)(255)))));
            this.btnUpdate.BorderSize = 2;
            this.btnUpdate.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnUpdate.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnUpdate.CheckedForeColor = System.Drawing.Color.White;
            this.btnUpdate.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.CheckedImage")));
            this.btnUpdate.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnUpdate.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnUpdate.FocusedColor = System.Drawing.Color.Empty;
            this.btnUpdate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(152)))), ((int)(((byte)(255)))));
            this.btnUpdate.Image = null;
            this.btnUpdate.ImageSize = new System.Drawing.Size(20, 20);
            this.btnUpdate.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(152)))), ((int)(((byte)(255)))));
            this.btnUpdate.Location = new System.Drawing.Point(149, 294);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(152)))), ((int)(((byte)(255)))));
            this.btnUpdate.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(152)))), ((int)(((byte)(255)))));
            this.btnUpdate.OnHoverForeColor = System.Drawing.Color.White;
            this.btnUpdate.OnHoverImage = null;
            this.btnUpdate.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(152)))), ((int)(((byte)(255)))));
            this.btnUpdate.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(152)))), ((int)(((byte)(255)))));
            this.btnUpdate.Radius = 15;
            this.btnUpdate.Size = new System.Drawing.Size(238, 43);
            this.btnUpdate.TabIndex = 34;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // ChangeInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 367);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dtpDayOfBirth);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ChangeInfo";
            this.Text = "ChangeInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaTextBox txtNote;
        private Guna.UI.WinForms.GunaTextBox txtName;
        private Guna.UI.WinForms.GunaDateTimePicker dtpDayOfBirth;
        private Guna.UI.WinForms.GunaAdvenceButton btnUpdate;
    }
}