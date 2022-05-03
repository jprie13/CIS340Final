
namespace StoreApp
{
    partial class ChangePasswordForm
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
            this.originalpasstxt = new System.Windows.Forms.TextBox();
            this.oldpasslbl = new System.Windows.Forms.Label();
            this.newpass1lbl = new System.Windows.Forms.Label();
            this.newpass1txt = new System.Windows.Forms.TextBox();
            this.newpass2lbl = new System.Windows.Forms.Label();
            this.newpass2txt = new System.Windows.Forms.TextBox();
            this.backbtn = new System.Windows.Forms.Button();
            this.confirmbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // originalpasstxt
            // 
            this.originalpasstxt.Location = new System.Drawing.Point(13, 41);
            this.originalpasstxt.Name = "originalpasstxt";
            this.originalpasstxt.PasswordChar = '*';
            this.originalpasstxt.Size = new System.Drawing.Size(316, 26);
            this.originalpasstxt.TabIndex = 0;
            // 
            // oldpasslbl
            // 
            this.oldpasslbl.AutoSize = true;
            this.oldpasslbl.Location = new System.Drawing.Point(13, 13);
            this.oldpasslbl.Name = "oldpasslbl";
            this.oldpasslbl.Size = new System.Drawing.Size(135, 20);
            this.oldpasslbl.TabIndex = 1;
            this.oldpasslbl.Text = "Current Password";
            // 
            // newpass1lbl
            // 
            this.newpass1lbl.AutoSize = true;
            this.newpass1lbl.Location = new System.Drawing.Point(13, 102);
            this.newpass1lbl.Name = "newpass1lbl";
            this.newpass1lbl.Size = new System.Drawing.Size(113, 20);
            this.newpass1lbl.TabIndex = 3;
            this.newpass1lbl.Text = "New Password";
            // 
            // newpass1txt
            // 
            this.newpass1txt.Location = new System.Drawing.Point(13, 130);
            this.newpass1txt.Name = "newpass1txt";
            this.newpass1txt.PasswordChar = '*';
            this.newpass1txt.Size = new System.Drawing.Size(316, 26);
            this.newpass1txt.TabIndex = 2;
            // 
            // newpass2lbl
            // 
            this.newpass2lbl.AutoSize = true;
            this.newpass2lbl.Location = new System.Drawing.Point(12, 163);
            this.newpass2lbl.Name = "newpass2lbl";
            this.newpass2lbl.Size = new System.Drawing.Size(64, 20);
            this.newpass2lbl.TabIndex = 5;
            this.newpass2lbl.Text = "Confirm";
            // 
            // newpass2txt
            // 
            this.newpass2txt.Location = new System.Drawing.Point(12, 191);
            this.newpass2txt.Name = "newpass2txt";
            this.newpass2txt.PasswordChar = '*';
            this.newpass2txt.Size = new System.Drawing.Size(317, 26);
            this.newpass2txt.TabIndex = 4;
            // 
            // backbtn
            // 
            this.backbtn.Location = new System.Drawing.Point(229, 235);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(100, 29);
            this.backbtn.TabIndex = 6;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // confirmbtn
            // 
            this.confirmbtn.Location = new System.Drawing.Point(123, 235);
            this.confirmbtn.Name = "confirmbtn";
            this.confirmbtn.Size = new System.Drawing.Size(100, 29);
            this.confirmbtn.TabIndex = 7;
            this.confirmbtn.Text = "Confirm";
            this.confirmbtn.UseVisualStyleBackColor = true;
            this.confirmbtn.Click += new System.EventHandler(this.confirmbtn_Click);
            // 
            // ChangePasswordForm
            // 
            this.AcceptButton = this.confirmbtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.backbtn;
            this.ClientSize = new System.Drawing.Size(341, 288);
            this.Controls.Add(this.confirmbtn);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.newpass2lbl);
            this.Controls.Add(this.newpass2txt);
            this.Controls.Add(this.newpass1lbl);
            this.Controls.Add(this.newpass1txt);
            this.Controls.Add(this.oldpasslbl);
            this.Controls.Add(this.originalpasstxt);
            this.Name = "ChangePasswordForm";
            this.Text = "Change Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox originalpasstxt;
        private System.Windows.Forms.Label oldpasslbl;
        private System.Windows.Forms.Label newpass1lbl;
        private System.Windows.Forms.TextBox newpass1txt;
        private System.Windows.Forms.Label newpass2lbl;
        private System.Windows.Forms.TextBox newpass2txt;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Button confirmbtn;
    }
}