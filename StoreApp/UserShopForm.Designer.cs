
namespace StoreApp
{
    partial class UserShopForm
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
            this.productsdvg = new System.Windows.Forms.DataGridView();
            this.cartdvg = new System.Windows.Forms.DataGridView();
            this.productslbl = new System.Windows.Forms.Label();
            this.categorycbo = new System.Windows.Forms.ComboBox();
            this.searchtxt = new System.Windows.Forms.TextBox();
            this.searchbtn = new System.Windows.Forms.Button();
            this.addtocartbtn = new System.Windows.Forms.Button();
            this.cartlbl = new System.Windows.Forms.Label();
            this.checkoutbtn = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.exitbtn = new System.Windows.Forms.Button();
            this.totaldisplaytxt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productsdvg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartdvg)).BeginInit();
            this.SuspendLayout();
            // 
            // productsdvg
            // 
            this.productsdvg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsdvg.Location = new System.Drawing.Point(12, 44);
            this.productsdvg.MultiSelect = false;
            this.productsdvg.Name = "productsdvg";
            this.productsdvg.RowHeadersWidth = 62;
            this.productsdvg.RowTemplate.Height = 28;
            this.productsdvg.Size = new System.Drawing.Size(776, 259);
            this.productsdvg.TabIndex = 0;
            this.productsdvg.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.productsdvg_RowEnter);
            this.productsdvg.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.productsdvg_RowLeave);
            // 
            // cartdvg
            // 
            this.cartdvg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cartdvg.Location = new System.Drawing.Point(13, 389);
            this.cartdvg.Name = "cartdvg";
            this.cartdvg.RowHeadersWidth = 62;
            this.cartdvg.RowTemplate.Height = 28;
            this.cartdvg.Size = new System.Drawing.Size(635, 200);
            this.cartdvg.TabIndex = 1;
            this.cartdvg.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.cartdvg_RowEnter);
            this.cartdvg.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.cartdvg_RowLeave);
            // 
            // productslbl
            // 
            this.productslbl.AutoSize = true;
            this.productslbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productslbl.Location = new System.Drawing.Point(6, 9);
            this.productslbl.Name = "productslbl";
            this.productslbl.Size = new System.Drawing.Size(127, 32);
            this.productslbl.TabIndex = 2;
            this.productslbl.Text = "Products";
            // 
            // categorycbo
            // 
            this.categorycbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categorycbo.FormattingEnabled = true;
            this.categorycbo.Location = new System.Drawing.Point(13, 312);
            this.categorycbo.Name = "categorycbo";
            this.categorycbo.Size = new System.Drawing.Size(236, 28);
            this.categorycbo.TabIndex = 3;
            this.categorycbo.SelectedIndexChanged += new System.EventHandler(this.categorycbo_SelectedIndexChanged);
            // 
            // searchtxt
            // 
            this.searchtxt.Location = new System.Drawing.Point(255, 312);
            this.searchtxt.Name = "searchtxt";
            this.searchtxt.Size = new System.Drawing.Size(250, 26);
            this.searchtxt.TabIndex = 4;
            // 
            // searchbtn
            // 
            this.searchbtn.Location = new System.Drawing.Point(511, 310);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(103, 30);
            this.searchbtn.TabIndex = 5;
            this.searchbtn.Text = "Search";
            this.searchbtn.UseVisualStyleBackColor = true;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // addtocartbtn
            // 
            this.addtocartbtn.Enabled = false;
            this.addtocartbtn.Location = new System.Drawing.Point(654, 309);
            this.addtocartbtn.Name = "addtocartbtn";
            this.addtocartbtn.Size = new System.Drawing.Size(134, 29);
            this.addtocartbtn.TabIndex = 6;
            this.addtocartbtn.Text = "Add to Cart";
            this.addtocartbtn.UseVisualStyleBackColor = true;
            this.addtocartbtn.Click += new System.EventHandler(this.addtocartbtn_Click);
            // 
            // cartlbl
            // 
            this.cartlbl.AutoSize = true;
            this.cartlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cartlbl.Location = new System.Drawing.Point(12, 354);
            this.cartlbl.Name = "cartlbl";
            this.cartlbl.Size = new System.Drawing.Size(68, 32);
            this.cartlbl.TabIndex = 7;
            this.cartlbl.Text = "Cart";
            // 
            // checkoutbtn
            // 
            this.checkoutbtn.Location = new System.Drawing.Point(654, 389);
            this.checkoutbtn.Name = "checkoutbtn";
            this.checkoutbtn.Size = new System.Drawing.Size(134, 40);
            this.checkoutbtn.TabIndex = 8;
            this.checkoutbtn.Text = "Checkout";
            this.checkoutbtn.UseVisualStyleBackColor = true;
            this.checkoutbtn.Click += new System.EventHandler(this.checkoutbtn_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.Enabled = false;
            this.deletebtn.Location = new System.Drawing.Point(654, 435);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(134, 40);
            this.deletebtn.TabIndex = 9;
            this.deletebtn.Text = "Remove";
            this.deletebtn.UseVisualStyleBackColor = true;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // exitbtn
            // 
            this.exitbtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitbtn.Location = new System.Drawing.Point(685, 597);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(103, 33);
            this.exitbtn.TabIndex = 10;
            this.exitbtn.Text = "Back";
            this.exitbtn.UseVisualStyleBackColor = true;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // totaldisplaytxt
            // 
            this.totaldisplaytxt.Location = new System.Drawing.Point(654, 562);
            this.totaldisplaytxt.Name = "totaldisplaytxt";
            this.totaldisplaytxt.Size = new System.Drawing.Size(134, 27);
            this.totaldisplaytxt.TabIndex = 11;
            this.totaldisplaytxt.Text = "0.00";
            this.totaldisplaytxt.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(658, 539);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Total:";
            // 
            // UserShopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitbtn;
            this.ClientSize = new System.Drawing.Size(800, 642);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.totaldisplaytxt);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.checkoutbtn);
            this.Controls.Add(this.cartlbl);
            this.Controls.Add(this.addtocartbtn);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.searchtxt);
            this.Controls.Add(this.categorycbo);
            this.Controls.Add(this.productslbl);
            this.Controls.Add(this.cartdvg);
            this.Controls.Add(this.productsdvg);
            this.Name = "UserShopForm";
            this.Text = "UserShopForm";
            ((System.ComponentModel.ISupportInitialize)(this.productsdvg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartdvg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView productsdvg;
        private System.Windows.Forms.DataGridView cartdvg;
        private System.Windows.Forms.Label productslbl;
        private System.Windows.Forms.ComboBox categorycbo;
        private System.Windows.Forms.TextBox searchtxt;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.Button addtocartbtn;
        private System.Windows.Forms.Label cartlbl;
        private System.Windows.Forms.Button checkoutbtn;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button exitbtn;
        private System.Windows.Forms.Label totaldisplaytxt;
        private System.Windows.Forms.Label label1;
    }
}