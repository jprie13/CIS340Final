
namespace StoreApp.Products
{
    partial class ProductsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.searchtxt = new System.Windows.Forms.TextBox();
            this.searchbtn = new System.Windows.Forms.Button();
            this.exitbtn = new System.Windows.Forms.Button();
            this.productsdvg = new System.Windows.Forms.DataGridView();
            this.addbtn = new System.Windows.Forms.Button();
            this.editbtn = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.activebtn = new System.Windows.Forms.Button();
            this.inactivebtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.productsdvg)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Products";
            // 
            // searchtxt
            // 
            this.searchtxt.Location = new System.Drawing.Point(523, 19);
            this.searchtxt.Name = "searchtxt";
            this.searchtxt.Size = new System.Drawing.Size(173, 26);
            this.searchtxt.TabIndex = 1;
            // 
            // searchbtn
            // 
            this.searchbtn.Location = new System.Drawing.Point(702, 17);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(73, 32);
            this.searchbtn.TabIndex = 2;
            this.searchbtn.Text = "Search";
            this.searchbtn.UseVisualStyleBackColor = true;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // exitbtn
            // 
            this.exitbtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitbtn.Location = new System.Drawing.Point(678, 400);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(97, 38);
            this.exitbtn.TabIndex = 3;
            this.exitbtn.Text = "Back";
            this.exitbtn.UseVisualStyleBackColor = true;
            this.exitbtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // productsdvg
            // 
            this.productsdvg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsdvg.Location = new System.Drawing.Point(19, 61);
            this.productsdvg.Name = "productsdvg";
            this.productsdvg.RowHeadersWidth = 62;
            this.productsdvg.RowTemplate.Height = 28;
            this.productsdvg.Size = new System.Drawing.Size(626, 338);
            this.productsdvg.TabIndex = 4;
            this.productsdvg.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.productsdvg_RowEnter);
            this.productsdvg.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.productsdvg_RowLeave);
            // 
            // addbtn
            // 
            this.addbtn.Location = new System.Drawing.Point(651, 61);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(124, 48);
            this.addbtn.TabIndex = 5;
            this.addbtn.Text = "Add";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // editbtn
            // 
            this.editbtn.Enabled = false;
            this.editbtn.Location = new System.Drawing.Point(651, 115);
            this.editbtn.Name = "editbtn";
            this.editbtn.Size = new System.Drawing.Size(124, 48);
            this.editbtn.TabIndex = 6;
            this.editbtn.Text = "Edit";
            this.editbtn.UseVisualStyleBackColor = true;
            this.editbtn.Click += new System.EventHandler(this.button4_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.Enabled = false;
            this.deletebtn.Location = new System.Drawing.Point(651, 277);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(124, 48);
            this.deletebtn.TabIndex = 7;
            this.deletebtn.Text = "Delete";
            this.deletebtn.UseVisualStyleBackColor = true;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // activebtn
            // 
            this.activebtn.Enabled = false;
            this.activebtn.Location = new System.Drawing.Point(651, 223);
            this.activebtn.Name = "activebtn";
            this.activebtn.Size = new System.Drawing.Size(124, 48);
            this.activebtn.TabIndex = 8;
            this.activebtn.Text = "Mark Active";
            this.activebtn.UseVisualStyleBackColor = true;
            this.activebtn.Click += new System.EventHandler(this.activebtn_Click);
            // 
            // inactivebtn
            // 
            this.inactivebtn.Enabled = false;
            this.inactivebtn.Location = new System.Drawing.Point(651, 169);
            this.inactivebtn.Name = "inactivebtn";
            this.inactivebtn.Size = new System.Drawing.Size(124, 48);
            this.inactivebtn.TabIndex = 9;
            this.inactivebtn.Text = "Mark Inactive";
            this.inactivebtn.UseVisualStyleBackColor = true;
            this.inactivebtn.Click += new System.EventHandler(this.inactivebtn_Click);
            // 
            // ProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitbtn;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.inactivebtn);
            this.Controls.Add(this.activebtn);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.editbtn);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.productsdvg);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.searchtxt);
            this.Controls.Add(this.label1);
            this.Name = "ProductsForm";
            this.Text = "Products";
            ((System.ComponentModel.ISupportInitialize)(this.productsdvg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchtxt;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.Button exitbtn;
        private System.Windows.Forms.DataGridView productsdvg;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Button editbtn;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button activebtn;
        private System.Windows.Forms.Button inactivebtn;
    }
}