
namespace StoreApp
{
    partial class ProductAddForm
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
            this.ProductCategorycbo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Confirmbtn = new System.Windows.Forms.Button();
            this.Cancelbtn = new System.Windows.Forms.Button();
            this.ProductNametxt = new System.Windows.Forms.TextBox();
            this.Namelbl = new System.Windows.Forms.Label();
            this.Pricetxt = new System.Windows.Forms.TextBox();
            this.Pricelbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ProductCategorycbo
            // 
            this.ProductCategorycbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProductCategorycbo.FormattingEnabled = true;
            this.ProductCategorycbo.Location = new System.Drawing.Point(30, 200);
            this.ProductCategorycbo.Name = "ProductCategorycbo";
            this.ProductCategorycbo.Size = new System.Drawing.Size(336, 28);
            this.ProductCategorycbo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Product Category";
            // 
            // Confirmbtn
            // 
            this.Confirmbtn.Location = new System.Drawing.Point(152, 252);
            this.Confirmbtn.Name = "Confirmbtn";
            this.Confirmbtn.Size = new System.Drawing.Size(117, 32);
            this.Confirmbtn.TabIndex = 2;
            this.Confirmbtn.Text = "Add";
            this.Confirmbtn.UseVisualStyleBackColor = true;
            this.Confirmbtn.Click += new System.EventHandler(this.Confirmbtn_Click);
            // 
            // Cancelbtn
            // 
            this.Cancelbtn.Location = new System.Drawing.Point(275, 252);
            this.Cancelbtn.Name = "Cancelbtn";
            this.Cancelbtn.Size = new System.Drawing.Size(109, 32);
            this.Cancelbtn.TabIndex = 3;
            this.Cancelbtn.Text = "Cancel";
            this.Cancelbtn.UseVisualStyleBackColor = true;
            this.Cancelbtn.Click += new System.EventHandler(this.Cancelbtn_Click);
            // 
            // ProductNametxt
            // 
            this.ProductNametxt.Location = new System.Drawing.Point(30, 49);
            this.ProductNametxt.Name = "ProductNametxt";
            this.ProductNametxt.Size = new System.Drawing.Size(336, 26);
            this.ProductNametxt.TabIndex = 4;
            // 
            // Namelbl
            // 
            this.Namelbl.AutoSize = true;
            this.Namelbl.Location = new System.Drawing.Point(30, 26);
            this.Namelbl.Name = "Namelbl";
            this.Namelbl.Size = new System.Drawing.Size(110, 20);
            this.Namelbl.TabIndex = 5;
            this.Namelbl.Text = "Product Name";
            // 
            // Pricetxt
            // 
            this.Pricetxt.Location = new System.Drawing.Point(30, 120);
            this.Pricetxt.Name = "Pricetxt";
            this.Pricetxt.Size = new System.Drawing.Size(336, 26);
            this.Pricetxt.TabIndex = 6;
            // 
            // Pricelbl
            // 
            this.Pricelbl.AutoSize = true;
            this.Pricelbl.Location = new System.Drawing.Point(30, 97);
            this.Pricelbl.Name = "Pricelbl";
            this.Pricelbl.Size = new System.Drawing.Size(44, 20);
            this.Pricelbl.TabIndex = 7;
            this.Pricelbl.Text = "Price";
            // 
            // ProductAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 303);
            this.Controls.Add(this.Pricelbl);
            this.Controls.Add(this.Pricetxt);
            this.Controls.Add(this.Namelbl);
            this.Controls.Add(this.ProductNametxt);
            this.Controls.Add(this.Cancelbtn);
            this.Controls.Add(this.Confirmbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProductCategorycbo);
            this.Name = "ProductAddForm";
            this.Text = "Add Product";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ProductCategorycbo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Confirmbtn;
        private System.Windows.Forms.Button Cancelbtn;
        private System.Windows.Forms.TextBox ProductNametxt;
        private System.Windows.Forms.Label Namelbl;
        private System.Windows.Forms.TextBox Pricetxt;
        private System.Windows.Forms.Label Pricelbl;
    }
}