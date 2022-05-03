
namespace StoreApp
{
    partial class CustomerHomeForm
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
            this.shopbtn = new System.Windows.Forms.Button();
            this.invoicebtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.passbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // shopbtn
            // 
            this.shopbtn.Location = new System.Drawing.Point(12, 24);
            this.shopbtn.Name = "shopbtn";
            this.shopbtn.Size = new System.Drawing.Size(359, 50);
            this.shopbtn.TabIndex = 5;
            this.shopbtn.Text = "Shop";
            this.shopbtn.UseVisualStyleBackColor = true;
            this.shopbtn.Click += new System.EventHandler(this.shopbtn_Click);
            // 
            // invoicebtn
            // 
            this.invoicebtn.Location = new System.Drawing.Point(12, 80);
            this.invoicebtn.Name = "invoicebtn";
            this.invoicebtn.Size = new System.Drawing.Size(359, 50);
            this.invoicebtn.TabIndex = 6;
            this.invoicebtn.Text = "View History";
            this.invoicebtn.UseVisualStyleBackColor = true;
            this.invoicebtn.Click += new System.EventHandler(this.invoicebtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitBtn.Location = new System.Drawing.Point(12, 215);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(359, 34);
            this.exitBtn.TabIndex = 7;
            this.exitBtn.Text = "Log out";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // passbtn
            // 
            this.passbtn.Location = new System.Drawing.Point(12, 136);
            this.passbtn.Name = "passbtn";
            this.passbtn.Size = new System.Drawing.Size(359, 50);
            this.passbtn.TabIndex = 8;
            this.passbtn.Text = "Change Password";
            this.passbtn.UseVisualStyleBackColor = true;
            this.passbtn.Click += new System.EventHandler(this.passbtn_Click);
            // 
            // CustomerHomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitBtn;
            this.ClientSize = new System.Drawing.Size(387, 261);
            this.Controls.Add(this.passbtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.invoicebtn);
            this.Controls.Add(this.shopbtn);
            this.Name = "CustomerHomeForm";
            this.Text = "ShopEasy";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CustomerHomeForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button shopbtn;
        private System.Windows.Forms.Button invoicebtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button passbtn;
    }
}