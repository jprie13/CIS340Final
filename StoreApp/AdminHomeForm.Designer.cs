
namespace StoreApp
{
    partial class AdminHomeForm
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
            this.exitBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.productsbtn = new System.Windows.Forms.Button();
            this.invoicebtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exitBtn
            // 
            this.exitBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitBtn.Location = new System.Drawing.Point(15, 224);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(359, 34);
            this.exitBtn.TabIndex = 2;
            this.exitBtn.Text = "Log out";
            this.exitBtn.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(359, 50);
            this.button1.TabIndex = 3;
            this.button1.Text = "View Users";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // productsbtn
            // 
            this.productsbtn.Location = new System.Drawing.Point(15, 29);
            this.productsbtn.Name = "productsbtn";
            this.productsbtn.Size = new System.Drawing.Size(359, 50);
            this.productsbtn.TabIndex = 4;
            this.productsbtn.Text = "View Products";
            this.productsbtn.UseVisualStyleBackColor = true;
            this.productsbtn.Click += new System.EventHandler(this.productsbtn_Click);
            // 
            // invoicebtn
            // 
            this.invoicebtn.Location = new System.Drawing.Point(15, 141);
            this.invoicebtn.Name = "invoicebtn";
            this.invoicebtn.Size = new System.Drawing.Size(359, 50);
            this.invoicebtn.TabIndex = 5;
            this.invoicebtn.Text = "View Invoices";
            this.invoicebtn.UseVisualStyleBackColor = true;
            // 
            // AdminHomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitBtn;
            this.ClientSize = new System.Drawing.Size(391, 282);
            this.Controls.Add(this.invoicebtn);
            this.Controls.Add(this.productsbtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.exitBtn);
            this.Name = "AdminHomeForm";
            this.Text = "ShopEasy";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProductsForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button productsbtn;
        private System.Windows.Forms.Button invoicebtn;
    }
}

