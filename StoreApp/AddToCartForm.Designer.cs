
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
            this.productscbo = new System.Windows.Forms.ComboBox();
            this.selectlbl = new System.Windows.Forms.Label();
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
            // productscbo
            // 
            this.productscbo.FormattingEnabled = true;
            this.productscbo.Location = new System.Drawing.Point(13, 54);
            this.productscbo.Name = "productscbo";
            this.productscbo.Size = new System.Drawing.Size(355, 28);
            this.productscbo.TabIndex = 0;
            // 
            // selectlbl
            // 
            this.selectlbl.AutoSize = true;
            this.selectlbl.Location = new System.Drawing.Point(13, 28);
            this.selectlbl.Name = "selectlbl";
            this.selectlbl.Size = new System.Drawing.Size(72, 20);
            this.selectlbl.TabIndex = 1;
            this.selectlbl.Text = "Products";
            // 
            // selectedlbl
            // 
            this.selectedlbl.AutoSize = true;
            this.selectedlbl.Location = new System.Drawing.Point(13, 103);
            this.selectedlbl.Name = "selectedlbl";
            this.selectedlbl.Size = new System.Drawing.Size(131, 20);
            this.selectedlbl.TabIndex = 2;
            this.selectedlbl.Text = "Selected Product";
            // 
            // namelbl
            // 
            this.namelbl.AutoSize = true;
            this.namelbl.Location = new System.Drawing.Point(30, 136);
            this.namelbl.Name = "namelbl";
            this.namelbl.Size = new System.Drawing.Size(51, 20);
            this.namelbl.TabIndex = 3;
            this.namelbl.Text = "Name";
            // 
            // pricelbl
            // 
            this.pricelbl.AutoSize = true;
            this.pricelbl.Location = new System.Drawing.Point(30, 170);
            this.pricelbl.Name = "pricelbl";
            this.pricelbl.Size = new System.Drawing.Size(44, 20);
            this.pricelbl.TabIndex = 4;
            this.pricelbl.Text = "Price";
            // 
            // categorylbl
            // 
            this.categorylbl.AutoSize = true;
            this.categorylbl.Location = new System.Drawing.Point(30, 199);
            this.categorylbl.Name = "categorylbl";
            this.categorylbl.Size = new System.Drawing.Size(73, 20);
            this.categorylbl.TabIndex = 5;
            this.categorylbl.Text = "Category";
            // 
            // namedisplaylbl
            // 
            this.namedisplaylbl.AutoSize = true;
            this.namedisplaylbl.Location = new System.Drawing.Point(344, 136);
            this.namedisplaylbl.Name = "namedisplaylbl";
            this.namedisplaylbl.Size = new System.Drawing.Size(24, 20);
            this.namedisplaylbl.TabIndex = 6;
            this.namedisplaylbl.Text = "---";
            this.namedisplaylbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pricedisplaylbl
            // 
            this.pricedisplaylbl.AutoSize = true;
            this.pricedisplaylbl.Location = new System.Drawing.Point(343, 170);
            this.pricedisplaylbl.Name = "pricedisplaylbl";
            this.pricedisplaylbl.Size = new System.Drawing.Size(24, 20);
            this.pricedisplaylbl.TabIndex = 7;
            this.pricedisplaylbl.Text = "---";
            this.pricedisplaylbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // categorydisplaylbl
            // 
            this.categorydisplaylbl.AutoSize = true;
            this.categorydisplaylbl.Location = new System.Drawing.Point(343, 199);
            this.categorydisplaylbl.Name = "categorydisplaylbl";
            this.categorydisplaylbl.Size = new System.Drawing.Size(24, 20);
            this.categorydisplaylbl.TabIndex = 8;
            this.categorydisplaylbl.Text = "---";
            this.categorydisplaylbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // quantitytxt
            // 
            this.quantitytxt.Location = new System.Drawing.Point(87, 242);
            this.quantitytxt.Name = "quantitytxt";
            this.quantitytxt.Size = new System.Drawing.Size(281, 26);
            this.quantitytxt.TabIndex = 9;
            this.quantitytxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // quantitylbl
            // 
            this.quantitylbl.AutoSize = true;
            this.quantitylbl.Location = new System.Drawing.Point(13, 242);
            this.quantitylbl.Name = "quantitylbl";
            this.quantitylbl.Size = new System.Drawing.Size(68, 20);
            this.quantitylbl.TabIndex = 10;
            this.quantitylbl.Text = "Quantity";
            // 
            // cancelbtn
            // 
            this.cancelbtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelbtn.Location = new System.Drawing.Point(281, 294);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(86, 30);
            this.cancelbtn.TabIndex = 11;
            this.cancelbtn.Text = "Cancel";
            this.cancelbtn.UseVisualStyleBackColor = true;
            // 
            // addbtn
            // 
            this.addbtn.Location = new System.Drawing.Point(146, 294);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(129, 30);
            this.addbtn.TabIndex = 12;
            this.addbtn.Text = "Add to Cart";
            this.addbtn.UseVisualStyleBackColor = true;
            // 
            // AddToCartForm
            // 
            this.AcceptButton = this.addbtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelbtn;
            this.ClientSize = new System.Drawing.Size(390, 349);
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
            this.Controls.Add(this.selectlbl);
            this.Controls.Add(this.productscbo);
            this.Name = "AddToCartForm";
            this.Text = "Add Product";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox productscbo;
        private System.Windows.Forms.Label selectlbl;
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