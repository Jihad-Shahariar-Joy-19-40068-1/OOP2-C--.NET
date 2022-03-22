
namespace Inventory_Management_System_I_.Presentation_Layer
{
    partial class ManageProduct
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listOfProductGridView = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.addCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.addButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.addQuantityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.addPriceTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addProductNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.updateProductIdTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.updateCategoryIdComboBox = new System.Windows.Forms.ComboBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.updateQuantotyNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.updatePriceTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.updateProductNameTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.deleteProductIdTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.searchProductNameTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.searchProductDataGridView = new System.Windows.Forms.DataGridView();
            this.backButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listOfProductGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addQuantityNumericUpDown)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updateQuantotyNumericUpDown)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchProductDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listOfProductGridView);
            this.groupBox1.Location = new System.Drawing.Point(457, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(482, 191);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "List of Products";
            // 
            // listOfProductGridView
            // 
            this.listOfProductGridView.AllowUserToAddRows = false;
            this.listOfProductGridView.AllowUserToDeleteRows = false;
            this.listOfProductGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listOfProductGridView.Location = new System.Drawing.Point(22, 35);
            this.listOfProductGridView.Name = "listOfProductGridView";
            this.listOfProductGridView.ReadOnly = true;
            this.listOfProductGridView.Size = new System.Drawing.Size(433, 140);
            this.listOfProductGridView.TabIndex = 0;
            this.listOfProductGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listOfProductGridView_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.addCategoryComboBox);
            this.groupBox2.Controls.Add(this.addButton);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.addQuantityNumericUpDown);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.addPriceTextBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.addProductNameTextBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(34, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(326, 237);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add New Product";
            // 
            // addCategoryComboBox
            // 
            this.addCategoryComboBox.FormattingEnabled = true;
            this.addCategoryComboBox.Location = new System.Drawing.Point(118, 155);
            this.addCategoryComboBox.Name = "addCategoryComboBox";
            this.addCategoryComboBox.Size = new System.Drawing.Size(149, 21);
            this.addCategoryComboBox.TabIndex = 9;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(118, 190);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(149, 32);
            this.addButton.TabIndex = 8;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Category ";
            // 
            // addQuantityNumericUpDown
            // 
            this.addQuantityNumericUpDown.Location = new System.Drawing.Point(118, 117);
            this.addQuantityNumericUpDown.Name = "addQuantityNumericUpDown";
            this.addQuantityNumericUpDown.Size = new System.Drawing.Size(149, 20);
            this.addQuantityNumericUpDown.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Product Quantity";
            // 
            // addPriceTextBox
            // 
            this.addPriceTextBox.Location = new System.Drawing.Point(118, 80);
            this.addPriceTextBox.Name = "addPriceTextBox";
            this.addPriceTextBox.Size = new System.Drawing.Size(149, 20);
            this.addPriceTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Product Price";
            // 
            // addProductNameTextBox
            // 
            this.addProductNameTextBox.Location = new System.Drawing.Point(118, 43);
            this.addProductNameTextBox.Name = "addProductNameTextBox";
            this.addProductNameTextBox.Size = new System.Drawing.Size(149, 20);
            this.addProductNameTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Name";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.updateProductIdTextBox);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.updateCategoryIdComboBox);
            this.groupBox3.Controls.Add(this.updateButton);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.updateQuantotyNumericUpDown);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.updatePriceTextBox);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.updateProductNameTextBox);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(34, 276);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(326, 273);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Update Product";
            // 
            // updateProductIdTextBox
            // 
            this.updateProductIdTextBox.Enabled = false;
            this.updateProductIdTextBox.Location = new System.Drawing.Point(118, 39);
            this.updateProductIdTextBox.Name = "updateProductIdTextBox";
            this.updateProductIdTextBox.Size = new System.Drawing.Size(149, 20);
            this.updateProductIdTextBox.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Product Id";
            // 
            // updateCategoryIdComboBox
            // 
            this.updateCategoryIdComboBox.FormattingEnabled = true;
            this.updateCategoryIdComboBox.Location = new System.Drawing.Point(118, 187);
            this.updateCategoryIdComboBox.Name = "updateCategoryIdComboBox";
            this.updateCategoryIdComboBox.Size = new System.Drawing.Size(149, 21);
            this.updateCategoryIdComboBox.TabIndex = 9;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(118, 222);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(149, 32);
            this.updateButton.TabIndex = 8;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Category ";
            // 
            // updateQuantotyNumericUpDown
            // 
            this.updateQuantotyNumericUpDown.Location = new System.Drawing.Point(118, 149);
            this.updateQuantotyNumericUpDown.Name = "updateQuantotyNumericUpDown";
            this.updateQuantotyNumericUpDown.Size = new System.Drawing.Size(149, 20);
            this.updateQuantotyNumericUpDown.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Product Quantity";
            // 
            // updatePriceTextBox
            // 
            this.updatePriceTextBox.Location = new System.Drawing.Point(118, 112);
            this.updatePriceTextBox.Name = "updatePriceTextBox";
            this.updatePriceTextBox.Size = new System.Drawing.Size(149, 20);
            this.updatePriceTextBox.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Product Price";
            // 
            // updateProductNameTextBox
            // 
            this.updateProductNameTextBox.Location = new System.Drawing.Point(118, 75);
            this.updateProductNameTextBox.Name = "updateProductNameTextBox";
            this.updateProductNameTextBox.Size = new System.Drawing.Size(149, 20);
            this.updateProductNameTextBox.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Product Name";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.deleteButton);
            this.groupBox4.Controls.Add(this.deleteProductIdTextBox);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Location = new System.Drawing.Point(34, 570);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(326, 100);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Delete Product";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(118, 55);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(149, 26);
            this.deleteButton.TabIndex = 12;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // deleteProductIdTextBox
            // 
            this.deleteProductIdTextBox.Location = new System.Drawing.Point(118, 29);
            this.deleteProductIdTextBox.Name = "deleteProductIdTextBox";
            this.deleteProductIdTextBox.Size = new System.Drawing.Size(149, 20);
            this.deleteProductIdTextBox.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Product Id";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.searchProductDataGridView);
            this.groupBox5.Controls.Add(this.searchProductNameTextBox);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Location = new System.Drawing.Point(457, 267);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(482, 322);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Search Product";
            // 
            // searchProductNameTextBox
            // 
            this.searchProductNameTextBox.Location = new System.Drawing.Point(207, 44);
            this.searchProductNameTextBox.Name = "searchProductNameTextBox";
            this.searchProductNameTextBox.Size = new System.Drawing.Size(149, 20);
            this.searchProductNameTextBox.TabIndex = 13;
            this.searchProductNameTextBox.TextChanged += new System.EventHandler(this.searchProductNameTextBox_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(108, 47);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Product Name";
            // 
            // searchProductDataGridView
            // 
            this.searchProductDataGridView.AllowUserToAddRows = false;
            this.searchProductDataGridView.AllowUserToDeleteRows = false;
            this.searchProductDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchProductDataGridView.Location = new System.Drawing.Point(22, 99);
            this.searchProductDataGridView.Name = "searchProductDataGridView";
            this.searchProductDataGridView.ReadOnly = true;
            this.searchProductDataGridView.Size = new System.Drawing.Size(433, 205);
            this.searchProductDataGridView.TabIndex = 14;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(790, 599);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(149, 32);
            this.backButton.TabIndex = 10;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // ManageProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 688);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ManageProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageProduct";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManageProduct_FormClosing);
            this.Load += new System.EventHandler(this.ManageProduct_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listOfProductGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addQuantityNumericUpDown)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updateQuantotyNumericUpDown)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchProductDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView listOfProductGridView;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown addQuantityNumericUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox addPriceTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox addProductNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox addCategoryComboBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox updateProductIdTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox updateCategoryIdComboBox;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown updateQuantotyNumericUpDown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox updatePriceTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox updateProductNameTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox deleteProductIdTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView searchProductDataGridView;
        private System.Windows.Forms.TextBox searchProductNameTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button backButton;
    }
}