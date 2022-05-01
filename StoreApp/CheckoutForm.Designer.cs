
namespace StoreApp
{
    partial class CheckoutForm
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
            this.cartdvg = new System.Windows.Forms.DataGridView();
            this.cartlbl = new System.Windows.Forms.Label();
            this.subtotaldisplaylbl = new System.Windows.Forms.Label();
            this.discountdisplaylbl = new System.Windows.Forms.Label();
            this.totaldisplaylbl = new System.Windows.Forms.Label();
            this.subtotallbl = new System.Windows.Forms.Label();
            this.discountlbl = new System.Windows.Forms.Label();
            this.totallbl = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.backbtn = new System.Windows.Forms.Button();
            this.confirmbtn = new System.Windows.Forms.Button();
            this.taxlbl = new System.Windows.Forms.Label();
            this.taxDisplaylbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cartdvg)).BeginInit();
            this.SuspendLayout();
            // 
            // cartdvg
            // 
            this.cartdvg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cartdvg.Location = new System.Drawing.Point(12, 48);
            this.cartdvg.Name = "cartdvg";
            this.cartdvg.RowHeadersWidth = 62;
            this.cartdvg.RowTemplate.Height = 28;
            this.cartdvg.Size = new System.Drawing.Size(531, 243);
            this.cartdvg.TabIndex = 0;
            // 
            // cartlbl
            // 
            this.cartlbl.AutoSize = true;
            this.cartlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cartlbl.Location = new System.Drawing.Point(13, 13);
            this.cartlbl.Name = "cartlbl";
            this.cartlbl.Size = new System.Drawing.Size(68, 32);
            this.cartlbl.TabIndex = 1;
            this.cartlbl.Text = "Cart";
            // 
            // subtotaldisplaylbl
            // 
            this.subtotaldisplaylbl.Location = new System.Drawing.Point(443, 309);
            this.subtotaldisplaylbl.Name = "subtotaldisplaylbl";
            this.subtotaldisplaylbl.Size = new System.Drawing.Size(100, 23);
            this.subtotaldisplaylbl.TabIndex = 2;
            this.subtotaldisplaylbl.Text = "0.00";
            this.subtotaldisplaylbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // discountdisplaylbl
            // 
            this.discountdisplaylbl.Location = new System.Drawing.Point(443, 328);
            this.discountdisplaylbl.Name = "discountdisplaylbl";
            this.discountdisplaylbl.Size = new System.Drawing.Size(100, 23);
            this.discountdisplaylbl.TabIndex = 3;
            this.discountdisplaylbl.Text = "0.00";
            this.discountdisplaylbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // totaldisplaylbl
            // 
            this.totaldisplaylbl.Location = new System.Drawing.Point(443, 388);
            this.totaldisplaylbl.Name = "totaldisplaylbl";
            this.totaldisplaylbl.Size = new System.Drawing.Size(100, 23);
            this.totaldisplaylbl.TabIndex = 4;
            this.totaldisplaylbl.Text = "0.00";
            this.totaldisplaylbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // subtotallbl
            // 
            this.subtotallbl.AutoSize = true;
            this.subtotallbl.Location = new System.Drawing.Point(347, 309);
            this.subtotallbl.Name = "subtotallbl";
            this.subtotallbl.Size = new System.Drawing.Size(73, 20);
            this.subtotallbl.TabIndex = 5;
            this.subtotallbl.Text = "Subtotal:";
            // 
            // discountlbl
            // 
            this.discountlbl.AutoSize = true;
            this.discountlbl.Location = new System.Drawing.Point(347, 331);
            this.discountlbl.Name = "discountlbl";
            this.discountlbl.Size = new System.Drawing.Size(76, 20);
            this.discountlbl.TabIndex = 6;
            this.discountlbl.Text = "Discount:";
            // 
            // totallbl
            // 
            this.totallbl.AutoSize = true;
            this.totallbl.Location = new System.Drawing.Point(346, 388);
            this.totallbl.Name = "totallbl";
            this.totallbl.Size = new System.Drawing.Size(48, 20);
            this.totallbl.TabIndex = 7;
            this.totallbl.Text = "Total:";
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Location = new System.Drawing.Point(306, 378);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(237, 2);
            this.label8.TabIndex = 8;
            // 
            // backbtn
            // 
            this.backbtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.backbtn.Location = new System.Drawing.Point(431, 425);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(114, 41);
            this.backbtn.TabIndex = 9;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // confirmbtn
            // 
            this.confirmbtn.Location = new System.Drawing.Point(279, 425);
            this.confirmbtn.Name = "confirmbtn";
            this.confirmbtn.Size = new System.Drawing.Size(144, 41);
            this.confirmbtn.TabIndex = 10;
            this.confirmbtn.Text = "Confirm Order";
            this.confirmbtn.UseVisualStyleBackColor = true;
            this.confirmbtn.Click += new System.EventHandler(this.confirmbtn_Click);
            // 
            // taxlbl
            // 
            this.taxlbl.AutoSize = true;
            this.taxlbl.Location = new System.Drawing.Point(347, 354);
            this.taxlbl.Name = "taxlbl";
            this.taxlbl.Size = new System.Drawing.Size(38, 20);
            this.taxlbl.TabIndex = 12;
            this.taxlbl.Text = "Tax:";
            // 
            // taxDisplaylbl
            // 
            this.taxDisplaylbl.Location = new System.Drawing.Point(443, 351);
            this.taxDisplaylbl.Name = "taxDisplaylbl";
            this.taxDisplaylbl.Size = new System.Drawing.Size(100, 23);
            this.taxDisplaylbl.TabIndex = 11;
            this.taxDisplaylbl.Text = "0.00";
            this.taxDisplaylbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CheckoutForm
            // 
            this.AcceptButton = this.confirmbtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.backbtn;
            this.ClientSize = new System.Drawing.Size(557, 480);
            this.Controls.Add(this.taxlbl);
            this.Controls.Add(this.taxDisplaylbl);
            this.Controls.Add(this.confirmbtn);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.totallbl);
            this.Controls.Add(this.discountlbl);
            this.Controls.Add(this.subtotallbl);
            this.Controls.Add(this.totaldisplaylbl);
            this.Controls.Add(this.discountdisplaylbl);
            this.Controls.Add(this.subtotaldisplaylbl);
            this.Controls.Add(this.cartlbl);
            this.Controls.Add(this.cartdvg);
            this.Name = "CheckoutForm";
            this.Text = "Checkout";
            ((System.ComponentModel.ISupportInitialize)(this.cartdvg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView cartdvg;
        private System.Windows.Forms.Label cartlbl;
        private System.Windows.Forms.Label subtotaldisplaylbl;
        private System.Windows.Forms.Label discountdisplaylbl;
        private System.Windows.Forms.Label totaldisplaylbl;
        private System.Windows.Forms.Label subtotallbl;
        private System.Windows.Forms.Label discountlbl;
        private System.Windows.Forms.Label totallbl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Button confirmbtn;
        private System.Windows.Forms.Label taxlbl;
        private System.Windows.Forms.Label taxDisplaylbl;
    }
}