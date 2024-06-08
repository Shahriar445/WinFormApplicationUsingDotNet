namespace WindowsFormsApp1
{
    partial class Form1
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
            this.createbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.inputproductname = new System.Windows.Forms.TextBox();
            this.TxtProductDescription = new System.Windows.Forms.RichTextBox();
            this.productQuantitya = new System.Windows.Forms.TextBox();
            this.dataviewgrid = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataviewgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // createbtn
            // 
            this.createbtn.AccessibleName = "";
            this.createbtn.Location = new System.Drawing.Point(389, 252);
            this.createbtn.Name = "createbtn";
            this.createbtn.Size = new System.Drawing.Size(75, 23);
            this.createbtn.TabIndex = 0;
            this.createbtn.Text = "Create Product";
            this.createbtn.UseVisualStyleBackColor = true;
            this.createbtn.Click += new System.EventHandler(this.btnCreate);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(243, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Product Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Product Descriptions";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(260, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Product Quantity";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // inputproductname
            // 
            this.inputproductname.AccessibleName = "";
            this.inputproductname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.inputproductname.Location = new System.Drawing.Point(352, 64);
            this.inputproductname.Name = "inputproductname";
            this.inputproductname.Size = new System.Drawing.Size(100, 20);
            this.inputproductname.TabIndex = 4;
            // 
            // TxtProductDescription
            // 
            this.TxtProductDescription.AccessibleName = "";
            this.TxtProductDescription.Location = new System.Drawing.Point(352, 150);
            this.TxtProductDescription.Name = "TxtProductDescription";
            this.TxtProductDescription.Size = new System.Drawing.Size(100, 96);
            this.TxtProductDescription.TabIndex = 5;
            this.TxtProductDescription.Text = "";
            this.TxtProductDescription.TextChanged += new System.EventHandler(this.ProductDescriptions);
            // 
            // productQuantitya
            // 
            this.productQuantitya.AccessibleName = "";
            this.productQuantitya.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.productQuantitya.Location = new System.Drawing.Point(352, 105);
            this.productQuantitya.Name = "productQuantitya";
            this.productQuantitya.Size = new System.Drawing.Size(100, 20);
            this.productQuantitya.TabIndex = 6;
            this.productQuantitya.TextChanged += new System.EventHandler(this.ProductQuantity);
            // 
            // dataviewgrid
            // 
            this.dataviewgrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataviewgrid.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dataviewgrid.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataviewgrid.Location = new System.Drawing.Point(476, 63);
            this.dataviewgrid.Name = "dataviewgrid";
            this.dataviewgrid.Size = new System.Drawing.Size(470, 249);
            this.dataviewgrid.TabIndex = 0;
            this.dataviewgrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(717, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Product List ";
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(271, 252);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 8;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 450);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataviewgrid);
            this.Controls.Add(this.productQuantitya);
            this.Controls.Add(this.TxtProductDescription);
            this.Controls.Add(this.inputproductname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.createbtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataviewgrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inputproductname;
        private System.Windows.Forms.RichTextBox TxtProductDescription;
        private System.Windows.Forms.TextBox productQuantitya;
        private System.Windows.Forms.DataGridView dataviewgrid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_update;
    }
}

