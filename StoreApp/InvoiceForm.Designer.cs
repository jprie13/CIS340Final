
namespace StoreApp
{
    partial class InvoiceForm
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
            this.titlelbl = new System.Windows.Forms.Label();
            this.exitbtn = new System.Windows.Forms.Button();
            this.invoicedvg = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.timecbo = new System.Windows.Forms.ComboBox();
            this.timetxt = new System.Windows.Forms.Label();
            this.detailsdvg = new System.Windows.Forms.DataGridView();
            this.detaillbl = new System.Windows.Forms.Label();
            this.totallbl = new System.Windows.Forms.Label();
            this.totaldisplaylbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.invoicedvg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsdvg)).BeginInit();
            this.SuspendLayout();
            // 
            // titlelbl
            // 
            this.titlelbl.AutoSize = true;
            this.titlelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlelbl.Location = new System.Drawing.Point(13, 13);
            this.titlelbl.Name = "titlelbl";
            this.titlelbl.Size = new System.Drawing.Size(103, 32);
            this.titlelbl.TabIndex = 0;
            this.titlelbl.Text = "History";
            // 
            // exitbtn
            // 
            this.exitbtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitbtn.Location = new System.Drawing.Point(669, 640);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(119, 37);
            this.exitbtn.TabIndex = 1;
            this.exitbtn.Text = "Back";
            this.exitbtn.UseVisualStyleBackColor = true;
            // 
            // invoicedvg
            // 
            this.invoicedvg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.invoicedvg.Location = new System.Drawing.Point(19, 78);
            this.invoicedvg.Name = "invoicedvg";
            this.invoicedvg.RowHeadersWidth = 62;
            this.invoicedvg.RowTemplate.Height = 28;
            this.invoicedvg.Size = new System.Drawing.Size(759, 247);
            this.invoicedvg.TabIndex = 2;
            this.invoicedvg.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.invoicedvg_RowEnter);
            this.invoicedvg.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.invoicedvg_RowLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Invoices";
            // 
            // timecbo
            // 
            this.timecbo.FormattingEnabled = true;
            this.timecbo.Location = new System.Drawing.Point(563, 44);
            this.timecbo.Name = "timecbo";
            this.timecbo.Size = new System.Drawing.Size(214, 28);
            this.timecbo.TabIndex = 5;
            this.timecbo.SelectedIndexChanged += new System.EventHandler(this.timecbo_SelectedIndexChanged);
            // 
            // timetxt
            // 
            this.timetxt.AutoSize = true;
            this.timetxt.Location = new System.Drawing.Point(473, 47);
            this.timetxt.Name = "timetxt";
            this.timetxt.Size = new System.Drawing.Size(84, 20);
            this.timetxt.TabIndex = 6;
            this.timetxt.Text = "Timeframe";
            // 
            // detailsdvg
            // 
            this.detailsdvg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.detailsdvg.Location = new System.Drawing.Point(19, 393);
            this.detailsdvg.Name = "detailsdvg";
            this.detailsdvg.RowHeadersWidth = 62;
            this.detailsdvg.RowTemplate.Height = 28;
            this.detailsdvg.Size = new System.Drawing.Size(605, 235);
            this.detailsdvg.TabIndex = 7;
            // 
            // detaillbl
            // 
            this.detaillbl.AutoSize = true;
            this.detaillbl.Location = new System.Drawing.Point(15, 370);
            this.detaillbl.Name = "detaillbl";
            this.detaillbl.Size = new System.Drawing.Size(58, 20);
            this.detaillbl.TabIndex = 8;
            this.detaillbl.Text = "Details";
            // 
            // totallbl
            // 
            this.totallbl.AutoSize = true;
            this.totallbl.Location = new System.Drawing.Point(630, 608);
            this.totallbl.Name = "totallbl";
            this.totallbl.Size = new System.Drawing.Size(48, 20);
            this.totallbl.TabIndex = 9;
            this.totallbl.Text = "Total:";
            // 
            // totaldisplaylbl
            // 
            this.totaldisplaylbl.Location = new System.Drawing.Point(688, 608);
            this.totaldisplaylbl.Name = "totaldisplaylbl";
            this.totaldisplaylbl.Size = new System.Drawing.Size(100, 23);
            this.totaldisplaylbl.TabIndex = 10;
            this.totaldisplaylbl.Text = "0.00";
            this.totaldisplaylbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // InvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitbtn;
            this.ClientSize = new System.Drawing.Size(800, 689);
            this.Controls.Add(this.totaldisplaylbl);
            this.Controls.Add(this.totallbl);
            this.Controls.Add(this.detaillbl);
            this.Controls.Add(this.detailsdvg);
            this.Controls.Add(this.timetxt);
            this.Controls.Add(this.timecbo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.invoicedvg);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.titlelbl);
            this.Name = "InvoiceForm";
            this.Text = "ShopForm";
            ((System.ComponentModel.ISupportInitialize)(this.invoicedvg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsdvg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titlelbl;
        private System.Windows.Forms.Button exitbtn;
        private System.Windows.Forms.DataGridView invoicedvg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox timecbo;
        private System.Windows.Forms.Label timetxt;
        private System.Windows.Forms.DataGridView detailsdvg;
        private System.Windows.Forms.Label detaillbl;
        private System.Windows.Forms.Label totallbl;
        private System.Windows.Forms.Label totaldisplaylbl;
    }
}