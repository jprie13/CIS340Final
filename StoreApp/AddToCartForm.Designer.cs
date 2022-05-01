
namespace StoreApp
{
    partial class AddToCartForm
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
            this.selectedlbl = new System.Windows.Forms.Label();
            this.namelbl = new System.Windows.Forms.Label();
            this.pricelbl = new System.Windows.Forms.Label();
            this.categorylbl = new System.Windows.Forms.Label();
            this.namedisplaylbl = new System.Windows.Forms.Label();
            this.pricedisplaylbl = new System.Windows.Forms.Label();
            this.categorydisplaylbl = new System.Windows.Forms.Label();
            this.quantitytxt = new System.Windows.Forms.TextBox();
            this.quantitylbl = new System.Windows.Forms.Label();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.addbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // selectedlbl
            // 
            this.selectedlbl.AutoSize = true;
            this.selectedlbl.Location = new System.Drawing.Point(12, 9);
            this.selectedlbl.Name = "selectedlbl";
            this.selectedlbl.Size = new System.Drawing.Size(131, 20);
            this.selectedlbl.TabIndex = 2;
            this.selectedlbl.Text = "Selected Product";
            // 
            // namelbl
            // 
            this.namelbl.AutoSize = true;
            this.namelbl.Location = new System.Drawing.Point(29, 42);
            this.namelbl.Name = "namelbl";
            this.namelbl.Size = new System.Drawing.Size(51, 20);
            this.namelbl.TabIndex = 3;
            this.namelbl.Text = "Name";
            // 
            // pricelbl
            // 
            this.pricelbl.AutoSize = true;
            this.pricelbl.Location = new System.Drawing.Point(29, 76);
            this.pricelbl.Name = "pricelbl";
            this.pricelbl.Size = new System.Drawing.Size(44, 20);
            this.pricelbl.TabIndex = 4;
            this.pricelbl.Text = "Price";
            // 
            // categorylbl
            // 
            this.categorylbl.AutoSize = true;
            this.categorylbl.Location = new System.Drawing.Point(29, 105);
            this.categorylbl.Name = "categorylbl";
            this.categorylbl.Size = new System.Drawing.Size(73, 20);
            this.categorylbl.TabIndex = 5;
            this.categorylbl.Text = "Category";
            // 
            // namedisplaylbl
            // 
            this.namedisplaylbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.namedisplaylbl.Location = new System.Drawing.Point(145, 42);
            this.namedisplaylbl.Name = "namedisplaylbl";
            this.namedisplaylbl.Size = new System.Drawing.Size(222, 20);
            this.namedisplaylbl.TabIndex = 6;
            this.namedisplaylbl.Text = "---";
            this.namedisplaylbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pricedisplaylbl
            // 
            this.pricedisplaylbl.Location = new System.Drawing.Point(132, 76);
            this.pricedisplaylbl.Name = "pricedisplaylbl";
            this.pricedisplaylbl.Size = new System.Drawing.Size(234, 20);
            this.pricedisplaylbl.TabIndex = 7;
            this.pricedisplaylbl.Text = "---";
            this.pricedisplaylbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // categorydisplaylbl
            // 
            this.categorydisplaylbl.Location = new System.Drawing.Point(136, 96);
            this.categorydisplaylbl.Name = "categorydisplaylbl";
            this.categorydisplaylbl.Size = new System.Drawing.Size(230, 29);
            this.categorydisplaylbl.TabIndex = 8;
            this.categorydisplaylbl.Text = "---";
            this.categorydisplaylbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // quantitytxt
            // 
            this.quantitytxt.Location = new System.Drawing.Point(86, 148);
            this.quantitytxt.Name = "quantitytxt";
            this.quantitytxt.Size = new System.Drawing.Size(281, 26);
            this.quantitytxt.TabIndex = 9;
            this.quantitytxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // quantitylbl
            // 
            this.quantitylbl.AutoSize = true;
            this.quantitylbl.Location = new System.Drawing.Point(12, 148);
            this.quantitylbl.Name = "quantitylbl";
            this.quantitylbl.Size = new System.Drawing.Size(68, 20);
            this.quantitylbl.TabIndex = 10;
            this.quantitylbl.Text = "Quantity";
            // 
            // cancelbtn
            // 
            this.cancelbtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelbtn.Location = new System.Drawing.Point(280, 200);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(86, 30);
            this.cancelbtn.TabIndex = 11;
            this.cancelbtn.Text = "Cancel";
            this.cancelbtn.UseVisualStyleBackColor = true;
            // 
            // addbtn
            // 
            this.addbtn.Location = new System.Drawing.Point(145, 200);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(129, 30);
            this.addbtn.TabIndex = 12;
            this.addbtn.Text = "Add to Cart";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // AddToCartForm
            // 
            this.AcceptButton = this.addbtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelbtn;
            this.ClientSize = new System.Drawing.Size(390, 246);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.quantitylbl);
            this.Controls.Add(this.quantitytxt);
            this.Controls.Add(this.categorydisplaylbl);
            this.Controls.Add(this.pricedisplaylbl);
            this.Controls.Add(this.namedisplaylbl);
            this.Controls.Add(this.categorylbl);
            this.Controls.Add(this.pricelbl);
            this.Controls.Add(this.namelbl);
            this.Controls.Add(this.selectedlbl);
            this.Name = "AddToCartForm";
            this.Text = "Add Product";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label selectedlbl;
        private System.Windows.Forms.Label namelbl;
        private System.Windows.Forms.Label pricelbl;
        private System.Windows.Forms.Label categorylbl;
        private System.Windows.Forms.Label namedisplaylbl;
        private System.Windows.Forms.Label pricedisplaylbl;
        private System.Windows.Forms.Label categorydisplaylbl;
        private System.Windows.Forms.TextBox quantitytxt;
        private System.Windows.Forms.Label quantitylbl;
        private System.Windows.Forms.Button cancelbtn;
        private System.Windows.Forms.Button addbtn;
    }
}