
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
            this.label1 = new System.Windows.Forms.Label();
            this.addProductNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addPriceTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addQuantityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.addCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listOfProductGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addQuantityNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listOfProductGridView);
            this.groupBox1.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(471, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(434, 166);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "List of Products";
            // 
            // listOfProductGridView
            // 
            this.listOfProductGridView.AllowUserToAddRows = false;
            this.listOfProductGridView.AllowUserToDeleteRows = false;
            this.listOfProductGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listOfProductGridView.Location = new System.Drawing.Point(6, 26);
            this.listOfProductGridView.Name = "listOfProductGridView";
            this.listOfProductGridView.ReadOnly = true;
            this.listOfProductGridView.RowHeadersWidth = 51;
            this.listOfProductGridView.RowTemplate.Height = 24;
            this.listOfProductGridView.Size = new System.Drawing.Size(422, 134);
            this.listOfProductGridView.TabIndex = 0;
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
            this.groupBox2.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(48, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(325, 260);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Product";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Name";
            // 
            // addProductNameTextBox
            // 
            this.addProductNameTextBox.Location = new System.Drawing.Point(172, 32);
            this.addProductNameTextBox.Name = "addProductNameTextBox";
            this.addProductNameTextBox.Size = new System.Drawing.Size(135, 27);
            this.addProductNameTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Product Price";
            // 
            // addPriceTextBox
            // 
            this.addPriceTextBox.Location = new System.Drawing.Point(172, 82);
            this.addPriceTextBox.Name = "addPriceTextBox";
            this.addPriceTextBox.Size = new System.Drawing.Size(135, 27);
            this.addPriceTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Product Quantity";
            // 
            // addQuantityNumericUpDown
            // 
            this.addQuantityNumericUpDown.Location = new System.Drawing.Point(172, 131);
            this.addQuantityNumericUpDown.Name = "addQuantityNumericUpDown";
            this.addQuantityNumericUpDown.Size = new System.Drawing.Size(135, 27);
            this.addQuantityNumericUpDown.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Category";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(106, 221);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(94, 33);
            this.addButton.TabIndex = 8;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // addCategoryComboBox
            // 
            this.addCategoryComboBox.FormattingEnabled = true;
            this.addCategoryComboBox.Location = new System.Drawing.Point(172, 179);
            this.addCategoryComboBox.Name = "addCategoryComboBox";
            this.addCategoryComboBox.Size = new System.Drawing.Size(135, 26);
            this.addCategoryComboBox.TabIndex = 9;
            // 
            // ManageProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(930, 623);
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
    }
}