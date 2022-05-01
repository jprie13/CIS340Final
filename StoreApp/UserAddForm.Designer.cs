
namespace StoreApp
{
    partial class UserAddForm
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
            this.fnametxt = new System.Windows.Forms.TextBox();
            this.fnamelbl = new System.Windows.Forms.Label();
            this.lnamelbl = new System.Windows.Forms.Label();
            this.lnametxt = new System.Windows.Forms.TextBox();
            this.phonelbl = new System.Windows.Forms.Label();
            this.phonetxt = new System.Windows.Forms.TextBox();
            this.emaillbl = new System.Windows.Forms.Label();
            this.emailtxt = new System.Windows.Forms.TextBox();
            this.typecbo = new System.Windows.Forms.ComboBox();
            this.typelbl = new System.Windows.Forms.Label();
            this.confirmbtn = new System.Windows.Forms.Button();
            this.backbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fnametxt
            // 
            this.fnametxt.Location = new System.Drawing.Point(23, 57);
            this.fnametxt.Name = "fnametxt";
            this.fnametxt.Size = new System.Drawing.Size(258, 26);
            this.fnametxt.TabIndex = 0;
            // 
            // fnamelbl
            // 
            this.fnamelbl.AutoSize = true;
            this.fnamelbl.Location = new System.Drawing.Point(23, 31);
            this.fnamelbl.Name = "fnamelbl";
            this.fnamelbl.Size = new System.Drawing.Size(86, 20);
            this.fnamelbl.TabIndex = 1;
            this.fnamelbl.Text = "First Name";
            // 
            // lnamelbl
            // 
            this.lnamelbl.AutoSize = true;
            this.lnamelbl.Location = new System.Drawing.Point(283, 31);
            this.lnamelbl.Name = "lnamelbl";
            this.lnamelbl.Size = new System.Drawing.Size(86, 20);
            this.lnamelbl.TabIndex = 3;
            this.lnamelbl.Text = "Last Name";
            // 
            // lnametxt
            // 
            this.lnametxt.Location = new System.Drawing.Point(287, 57);
            this.lnametxt.Name = "lnametxt";
            this.lnametxt.Size = new System.Drawing.Size(258, 26);
            this.lnametxt.TabIndex = 2;
            // 
            // phonelbl
            // 
            this.phonelbl.AutoSize = true;
            this.phonelbl.Location = new System.Drawing.Point(335, 92);
            this.phonelbl.Name = "phonelbl";
            this.phonelbl.Size = new System.Drawing.Size(55, 20);
            this.phonelbl.TabIndex = 11;
            this.phonelbl.Text = "Phone";
            // 
            // phonetxt
            // 
            this.phonetxt.Location = new System.Drawing.Point(339, 118);
            this.phonetxt.Name = "phonetxt";
            this.phonetxt.Size = new System.Drawing.Size(206, 26);
            this.phonetxt.TabIndex = 10;
            // 
            // emaillbl
            // 
            this.emaillbl.AutoSize = true;
            this.emaillbl.Location = new System.Drawing.Point(23, 92);
            this.emaillbl.Name = "emaillbl";
            this.emaillbl.Size = new System.Drawing.Size(48, 20);
            this.emaillbl.TabIndex = 13;
            this.emaillbl.Text = "Email";
            // 
            // emailtxt
            // 
            this.emailtxt.Location = new System.Drawing.Point(23, 118);
            this.emailtxt.Name = "emailtxt";
            this.emailtxt.Size = new System.Drawing.Size(310, 26);
            this.emailtxt.TabIndex = 12;
            // 
            // typecbo
            // 
            this.typecbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typecbo.FormattingEnabled = true;
            this.typecbo.Location = new System.Drawing.Point(23, 179);
            this.typecbo.Name = "typecbo";
            this.typecbo.Size = new System.Drawing.Size(367, 28);
            this.typecbo.TabIndex = 14;
            // 
            // typelbl
            // 
            this.typelbl.AutoSize = true;
            this.typelbl.Location = new System.Drawing.Point(23, 156);
            this.typelbl.Name = "typelbl";
            this.typelbl.Size = new System.Drawing.Size(81, 20);
            this.typelbl.TabIndex = 15;
            this.typelbl.Text = "User Type";
            // 
            // confirmbtn
            // 
            this.confirmbtn.Location = new System.Drawing.Point(312, 228);
            this.confirmbtn.Name = "confirmbtn";
            this.confirmbtn.Size = new System.Drawing.Size(114, 35);
            this.confirmbtn.TabIndex = 16;
            this.confirmbtn.Text = "Confirm";
            this.confirmbtn.UseVisualStyleBackColor = true;
            this.confirmbtn.Click += new System.EventHandler(this.confirmbtn_Click);
            // 
            // backbtn
            // 
            this.backbtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.backbtn.Location = new System.Drawing.Point(432, 228);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(113, 35);
            this.backbtn.TabIndex = 17;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // UserAddForm
            // 
            this.AcceptButton = this.confirmbtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.backbtn;
            this.ClientSize = new System.Drawing.Size(558, 283);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.confirmbtn);
            this.Controls.Add(this.typelbl);
            this.Controls.Add(this.typecbo);
            this.Controls.Add(this.emaillbl);
            this.Controls.Add(this.emailtxt);
            this.Controls.Add(this.phonelbl);
            this.Controls.Add(this.phonetxt);
            this.Controls.Add(this.lnamelbl);
            this.Controls.Add(this.lnametxt);
            this.Controls.Add(this.fnamelbl);
            this.Controls.Add(this.fnametxt);
            this.Name = "UserAddForm";
            this.Text = "Add User";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fnametxt;
        private System.Windows.Forms.Label fnamelbl;
        private System.Windows.Forms.Label lnamelbl;
        private System.Windows.Forms.TextBox lnametxt;
        private System.Windows.Forms.Label phonelbl;
        private System.Windows.Forms.TextBox phonetxt;
        private System.Windows.Forms.Label emaillbl;
        private System.Windows.Forms.TextBox emailtxt;
        private System.Windows.Forms.ComboBox typecbo;
        private System.Windows.Forms.Label typelbl;
        private System.Windows.Forms.Button confirmbtn;
        private System.Windows.Forms.Button backbtn;
    }
}