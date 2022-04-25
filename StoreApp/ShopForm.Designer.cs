
namespace StoreApp
{
    partial class ShopForm
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
            this.exitbtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.addbtn = new System.Windows.Forms.Button();
            this.removebtn = new System.Windows.Forms.Button();
            this.checkoutbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Shop";
            // 
            // exitbtn
            // 
            this.exitbtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitbtn.Location = new System.Drawing.Point(669, 401);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(119, 37);
            this.exitbtn.TabIndex = 1;
            this.exitbtn.Text = "Back";
            this.exitbtn.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(759, 247);
            this.dataGridView1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cart";
            // 
            // addbtn
            // 
            this.addbtn.Location = new System.Drawing.Point(19, 332);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(225, 33);
            this.addbtn.TabIndex = 4;
            this.addbtn.Text = "Add Item To Cart";
            this.addbtn.UseVisualStyleBackColor = true;
            // 
            // removebtn
            // 
            this.removebtn.Location = new System.Drawing.Point(251, 332);
            this.removebtn.Name = "removebtn";
            this.removebtn.Size = new System.Drawing.Size(123, 33);
            this.removebtn.TabIndex = 5;
            this.removebtn.Text = "Remove";
            this.removebtn.UseVisualStyleBackColor = true;
            // 
            // checkoutbtn
            // 
            this.checkoutbtn.Location = new System.Drawing.Point(638, 331);
            this.checkoutbtn.Name = "checkoutbtn";
            this.checkoutbtn.Size = new System.Drawing.Size(140, 33);
            this.checkoutbtn.TabIndex = 6;
            this.checkoutbtn.Text = "Checkout";
            this.checkoutbtn.UseVisualStyleBackColor = true;
            // 
            // ShopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitbtn;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkoutbtn);
            this.Controls.Add(this.removebtn);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.label1);
            this.Name = "ShopForm";
            this.Text = "ShopForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exitbtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Button removebtn;
        private System.Windows.Forms.Button checkoutbtn;
    }
}