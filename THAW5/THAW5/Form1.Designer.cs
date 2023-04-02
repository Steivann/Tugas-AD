namespace THAW5
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgv_product = new System.Windows.Forms.DataGridView();
            this.Btn_all = new System.Windows.Forms.Button();
            this.btn_filter = new System.Windows.Forms.Button();
            this.dgv_category = new System.Windows.Forms.DataGridView();
            this.textBox_name_category = new System.Windows.Forms.TextBox();
            this.textBox_name_details = new System.Windows.Forms.TextBox();
            this.textBox_stock = new System.Windows.Forms.TextBox();
            this.textBox_harga = new System.Windows.Forms.TextBox();
            this.cmbo_categorydetail = new System.Windows.Forms.ComboBox();
            this.cmbo_listproduk = new System.Windows.Forms.ComboBox();
            this.btn_addproduct = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btn_addcategory = new System.Windows.Forms.Button();
            this.btn_rmv_category = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_category)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 403);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Stock :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 372);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Harga :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nama :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 343);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Category :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(545, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Name :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(543, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 25);
            this.label9.TabIndex = 8;
            this.label9.Text = "Category";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 279);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 25);
            this.label8.TabIndex = 9;
            this.label8.Text = "Details :";
            // 
            // dgv_product
            // 
            this.dgv_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_product.Location = new System.Drawing.Point(17, 55);
            this.dgv_product.Name = "dgv_product";
            this.dgv_product.RowHeadersWidth = 51;
            this.dgv_product.RowTemplate.Height = 24;
            this.dgv_product.Size = new System.Drawing.Size(472, 212);
            this.dgv_product.TabIndex = 10;
            this.dgv_product.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_product_CellClick);
            this.dgv_product.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_product_CellContentClick);
            // 
            // Btn_all
            // 
            this.Btn_all.Location = new System.Drawing.Point(196, 26);
            this.Btn_all.Name = "Btn_all";
            this.Btn_all.Size = new System.Drawing.Size(75, 23);
            this.Btn_all.TabIndex = 11;
            this.Btn_all.Text = "All";
            this.Btn_all.UseVisualStyleBackColor = true;
            this.Btn_all.Click += new System.EventHandler(this.Btn_all_Click);
            // 
            // btn_filter
            // 
            this.btn_filter.Location = new System.Drawing.Point(277, 26);
            this.btn_filter.Name = "btn_filter";
            this.btn_filter.Size = new System.Drawing.Size(75, 23);
            this.btn_filter.TabIndex = 12;
            this.btn_filter.Text = "Filter :";
            this.btn_filter.UseVisualStyleBackColor = true;
            this.btn_filter.Click += new System.EventHandler(this.btn_filter_Click);
            // 
            // dgv_category
            // 
            this.dgv_category.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_category.Location = new System.Drawing.Point(548, 55);
            this.dgv_category.Name = "dgv_category";
            this.dgv_category.RowHeadersWidth = 51;
            this.dgv_category.RowTemplate.Height = 24;
            this.dgv_category.Size = new System.Drawing.Size(240, 150);
            this.dgv_category.TabIndex = 13;
            this.dgv_category.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_category_CellClick);
            this.dgv_category.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_category_CellContentClick);
            // 
            // textBox_name_category
            // 
            this.textBox_name_category.Location = new System.Drawing.Point(611, 219);
            this.textBox_name_category.Name = "textBox_name_category";
            this.textBox_name_category.Size = new System.Drawing.Size(177, 22);
            this.textBox_name_category.TabIndex = 14;
            // 
            // textBox_name_details
            // 
            this.textBox_name_details.Location = new System.Drawing.Point(89, 307);
            this.textBox_name_details.Name = "textBox_name_details";
            this.textBox_name_details.Size = new System.Drawing.Size(400, 22);
            this.textBox_name_details.TabIndex = 15;
            this.textBox_name_details.TextChanged += new System.EventHandler(this.textBox_name_details_TextChanged);
            // 
            // textBox_stock
            // 
            this.textBox_stock.Location = new System.Drawing.Point(89, 400);
            this.textBox_stock.Name = "textBox_stock";
            this.textBox_stock.Size = new System.Drawing.Size(121, 22);
            this.textBox_stock.TabIndex = 16;
            this.textBox_stock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_stock_KeyPress);
            // 
            // textBox_harga
            // 
            this.textBox_harga.Location = new System.Drawing.Point(89, 369);
            this.textBox_harga.Name = "textBox_harga";
            this.textBox_harga.Size = new System.Drawing.Size(121, 22);
            this.textBox_harga.TabIndex = 17;
            this.textBox_harga.TextChanged += new System.EventHandler(this.textBox_harga_TextChanged);
            this.textBox_harga.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_harga_KeyPress);
            // 
            // cmbo_categorydetail
            // 
            this.cmbo_categorydetail.FormattingEnabled = true;
            this.cmbo_categorydetail.Location = new System.Drawing.Point(89, 339);
            this.cmbo_categorydetail.Name = "cmbo_categorydetail";
            this.cmbo_categorydetail.Size = new System.Drawing.Size(121, 24);
            this.cmbo_categorydetail.TabIndex = 18;
            this.cmbo_categorydetail.SelectedIndexChanged += new System.EventHandler(this.cmbo_categorydetail_SelectedIndexChanged);
            // 
            // cmbo_listproduk
            // 
            this.cmbo_listproduk.FormattingEnabled = true;
            this.cmbo_listproduk.Location = new System.Drawing.Point(368, 25);
            this.cmbo_listproduk.Name = "cmbo_listproduk";
            this.cmbo_listproduk.Size = new System.Drawing.Size(121, 24);
            this.cmbo_listproduk.TabIndex = 19;
            this.cmbo_listproduk.SelectionChangeCommitted += new System.EventHandler(this.cmbo_listproduk_SelectionChangeCommitted);
            // 
            // btn_addproduct
            // 
            this.btn_addproduct.Location = new System.Drawing.Point(222, 351);
            this.btn_addproduct.Name = "btn_addproduct";
            this.btn_addproduct.Size = new System.Drawing.Size(85, 58);
            this.btn_addproduct.TabIndex = 20;
            this.btn_addproduct.Text = "Add Product";
            this.btn_addproduct.UseVisualStyleBackColor = true;
            this.btn_addproduct.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(313, 351);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(85, 58);
            this.button3.TabIndex = 21;
            this.button3.Text = "Edit Product";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(404, 351);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(85, 58);
            this.button4.TabIndex = 22;
            this.button4.Text = "Remove Proudct";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn_addcategory
            // 
            this.btn_addcategory.Location = new System.Drawing.Point(611, 256);
            this.btn_addcategory.Name = "btn_addcategory";
            this.btn_addcategory.Size = new System.Drawing.Size(85, 58);
            this.btn_addcategory.TabIndex = 23;
            this.btn_addcategory.Text = "Add Category";
            this.btn_addcategory.UseVisualStyleBackColor = true;
            this.btn_addcategory.Click += new System.EventHandler(this.button5_Click);
            // 
            // btn_rmv_category
            // 
            this.btn_rmv_category.Location = new System.Drawing.Point(703, 256);
            this.btn_rmv_category.Name = "btn_rmv_category";
            this.btn_rmv_category.Size = new System.Drawing.Size(85, 58);
            this.btn_rmv_category.TabIndex = 24;
            this.btn_rmv_category.Text = "Remove Category";
            this.btn_rmv_category.UseVisualStyleBackColor = true;
            this.btn_rmv_category.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 441);
            this.Controls.Add(this.btn_rmv_category);
            this.Controls.Add(this.btn_addcategory);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_addproduct);
            this.Controls.Add(this.cmbo_listproduk);
            this.Controls.Add(this.cmbo_categorydetail);
            this.Controls.Add(this.textBox_harga);
            this.Controls.Add(this.textBox_stock);
            this.Controls.Add(this.textBox_name_details);
            this.Controls.Add(this.textBox_name_category);
            this.Controls.Add(this.dgv_category);
            this.Controls.Add(this.btn_filter);
            this.Controls.Add(this.Btn_all);
            this.Controls.Add(this.dgv_product);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_category)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgv_product;
        private System.Windows.Forms.Button Btn_all;
        private System.Windows.Forms.Button btn_filter;
        private System.Windows.Forms.DataGridView dgv_category;
        private System.Windows.Forms.TextBox textBox_name_category;
        private System.Windows.Forms.TextBox textBox_name_details;
        private System.Windows.Forms.TextBox textBox_stock;
        private System.Windows.Forms.TextBox textBox_harga;
        private System.Windows.Forms.ComboBox cmbo_categorydetail;
        private System.Windows.Forms.ComboBox cmbo_listproduk;
        private System.Windows.Forms.Button btn_addproduct;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btn_addcategory;
        private System.Windows.Forms.Button btn_rmv_category;
    }
}

