
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
            this.LoadButton = new System.Windows.Forms.Button();
            this.updateCategoryIdTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.updateCategoryNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.deleteCategoryIdTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listOfCategoriesGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // listOfCategoriesGridView
            // 
            this.listOfCategoriesGridView.AllowUserToAddRows = false;
            this.listOfCategoriesGridView.AllowUserToDeleteRows = false;
            this.listOfCategoriesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listOfCategoriesGridView.Location = new System.Drawing.Point(6, 31);
            this.listOfCategoriesGridView.Name = "listOfCategoriesGridView";
            this.listOfCategoriesGridView.ReadOnly = true;
            this.listOfCategoriesGridView.RowHeadersWidth = 51;
            this.listOfCategoriesGridView.RowTemplate.Height = 24;
            this.listOfCategoriesGridView.Size = new System.Drawing.Size(341, 152);
            this.listOfCategoriesGridView.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listOfCategoriesGridView);
            this.groupBox1.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(577, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 189);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "List of Categories";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.addButton);
            this.groupBox2.Controls.Add(this.addCategoryNameTextBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(37, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(345, 155);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add New Category";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(170, 102);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(153, 27);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // addCategoryNameTextBox
            // 
            this.addCategoryNameTextBox.Location = new System.Drawing.Point(170, 44);
            this.addCategoryNameTextBox.Name = "addCategoryNameTextBox";
            this.addCategoryNameTextBox.Size = new System.Drawing.Size(153, 27);
            this.addCategoryNameTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Category Name";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.LoadButton);
            this.groupBox3.Controls.Add(this.updateCategoryIdTextBox);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.updateButton);
            this.groupBox3.Controls.Add(this.updateCategoryNameTextBox);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(37, 208);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(345, 191);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Update Category";
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(244, 30);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(79, 38);
            this.LoadButton.TabIndex = 5;
            this.LoadButton.Text = "Load";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // updateCategoryIdTextBox
            // 
            this.updateCategoryIdTextBox.Location = new System.Drawing.Point(170, 37);
            this.updateCategoryIdTextBox.Name = "updateCategoryIdTextBox";
            this.updateCategoryIdTextBox.Size = new System.Drawing.Size(68, 27);
            this.updateCategoryIdTextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Category Id";
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(170, 141);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(153, 27);
            this.updateButton.TabIndex = 2;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // updateCategoryNameTextBox
            // 
            this.updateCategoryNameTextBox.Location = new System.Drawing.Point(170, 89);
            this.updateCategoryNameTextBox.Name = "updateCategoryNameTextBox";
            this.updateCategoryNameTextBox.Size = new System.Drawing.Size(153, 27);
            this.updateCategoryNameTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Category Name";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.deleteButton);
            this.groupBox4.Controls.Add(this.deleteCategoryIdTextBox);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(37, 436);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(345, 155);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Detete Category";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(170, 102);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(153, 27);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // deleteCategoryIdTextBox
            // 
            this.deleteCategoryIdTextBox.Location = new System.Drawing.Point(170, 44);
            this.deleteCategoryIdTextBox.Name = "deleteCategoryIdTextBox";
            this.deleteCategoryIdTextBox.Size = new System.Drawing.Size(153, 27);
            this.deleteCategoryIdTextBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Category ID";
            // 
            // ManageCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(956, 633);
            this.Controls.Add(this.groupBox4);
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
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.TextBox updateCategoryIdTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.TextBox updateCategoryNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox deleteCategoryIdTextBox;
        private System.Windows.Forms.Label label4;
    }
}