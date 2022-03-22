
namespace Inventory_Management_System_I_.Presentation_Layer
{
    partial class ManageCategory
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
            this.listOfCategoriesGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.addButton = new System.Windows.Forms.Button();
            this.addCategoryNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.updateCategoryIdTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.updateCategoryNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.loadButton = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.deleteCategoryIdTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.categoryWiseProductListGridView = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.categoryWiseProductListComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.listOfCategoriesGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryWiseProductListGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // listOfCategoriesGridView
            // 
            this.listOfCategoriesGridView.AllowUserToAddRows = false;
            this.listOfCategoriesGridView.AllowUserToDeleteRows = false;
            this.listOfCategoriesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listOfCategoriesGridView.Location = new System.Drawing.Point(23, 37);
            this.listOfCategoriesGridView.Name = "listOfCategoriesGridView";
            this.listOfCategoriesGridView.ReadOnly = true;
            this.listOfCategoriesGridView.Size = new System.Drawing.Size(372, 150);
            this.listOfCategoriesGridView.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listOfCategoriesGridView);
            this.groupBox1.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(379, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(418, 209);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "List of Categories";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.addButton);
            this.groupBox2.Controls.Add(this.addCategoryNameTextBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(23, 34);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(301, 138);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add New Category";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(128, 87);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(155, 31);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // addCategoryNameTextBox
            // 
            this.addCategoryNameTextBox.Location = new System.Drawing.Point(128, 46);
            this.addCategoryNameTextBox.Name = "addCategoryNameTextBox";
            this.addCategoryNameTextBox.Size = new System.Drawing.Size(155, 25);
            this.addCategoryNameTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Category Name";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.updateCategoryIdTextBox);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.updateButton);
            this.groupBox3.Controls.Add(this.updateCategoryNameTextBox);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(23, 191);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(301, 174);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Update Category";
            // 
            // updateCategoryIdTextBox
            // 
            this.updateCategoryIdTextBox.Location = new System.Drawing.Point(128, 36);
            this.updateCategoryIdTextBox.Name = "updateCategoryIdTextBox";
            this.updateCategoryIdTextBox.Size = new System.Drawing.Size(75, 25);
            this.updateCategoryIdTextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Category ID";
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(128, 125);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(155, 31);
            this.updateButton.TabIndex = 2;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // updateCategoryNameTextBox
            // 
            this.updateCategoryNameTextBox.Location = new System.Drawing.Point(128, 84);
            this.updateCategoryNameTextBox.Name = "updateCategoryNameTextBox";
            this.updateCategoryNameTextBox.Size = new System.Drawing.Size(155, 25);
            this.updateCategoryNameTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Category Name";
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(232, 223);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(74, 31);
            this.loadButton.TabIndex = 5;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.deleteButton);
            this.groupBox4.Controls.Add(this.deleteCategoryIdTextBox);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(23, 384);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(301, 138);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Delete Category";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(128, 87);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(155, 31);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // deleteCategoryIdTextBox
            // 
            this.deleteCategoryIdTextBox.Location = new System.Drawing.Point(128, 46);
            this.deleteCategoryIdTextBox.Name = "deleteCategoryIdTextBox";
            this.deleteCategoryIdTextBox.Size = new System.Drawing.Size(155, 25);
            this.deleteCategoryIdTextBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Category ID";
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(642, 527);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(155, 31);
            this.backButton.TabIndex = 3;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.categoryWiseProductListComboBox);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.categoryWiseProductListGridView);
            this.groupBox5.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(379, 267);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(418, 254);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Category-Wise Product List";
            // 
            // categoryWiseProductListGridView
            // 
            this.categoryWiseProductListGridView.AllowUserToAddRows = false;
            this.categoryWiseProductListGridView.AllowUserToDeleteRows = false;
            this.categoryWiseProductListGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categoryWiseProductListGridView.Location = new System.Drawing.Point(23, 85);
            this.categoryWiseProductListGridView.Name = "categoryWiseProductListGridView";
            this.categoryWiseProductListGridView.ReadOnly = true;
            this.categoryWiseProductListGridView.Size = new System.Drawing.Size(372, 150);
            this.categoryWiseProductListGridView.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(74, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Category";
            // 
            // categoryWiseProductListComboBox
            // 
            this.categoryWiseProductListComboBox.FormattingEnabled = true;
            this.categoryWiseProductListComboBox.Location = new System.Drawing.Point(157, 35);
            this.categoryWiseProductListComboBox.Name = "categoryWiseProductListComboBox";
            this.categoryWiseProductListComboBox.Size = new System.Drawing.Size(200, 24);
            this.categoryWiseProductListComboBox.TabIndex = 4;
            this.categoryWiseProductListComboBox.SelectedIndexChanged += new System.EventHandler(this.categoryWiseProductListComboBox_SelectedIndexChanged);
            // 
            // ManageCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 570);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ManageCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Category";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManageCategory_FormClosing);
            this.Load += new System.EventHandler(this.ManageCategory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listOfCategoriesGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryWiseProductListGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView listOfCategoriesGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox addCategoryNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox updateCategoryIdTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.TextBox updateCategoryNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox deleteCategoryIdTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox categoryWiseProductListComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView categoryWiseProductListGridView;
    }
}