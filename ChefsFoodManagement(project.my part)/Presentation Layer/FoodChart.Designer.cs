
namespace ChefsFoodManagement.Presentation_Layer
{
    partial class FoodChart
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.stockChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.backButton = new System.Windows.Forms.Button();
            this.priceChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this._OOP2_I_DataSet = new ChefsFoodManagement._OOP2_I_DataSet();
            this.foodsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.foodsTableAdapter = new ChefsFoodManagement._OOP2_I_DataSetTableAdapters.FoodsTableAdapter();
            this.ingredientsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perUnitPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mfgDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foodCategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foodNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foodIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listOfFoodsGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stockChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._OOP2_I_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listOfFoodsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listOfFoodsGridView);
            this.groupBox1.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1358, 289);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "List of Foods";
            // 
            // stockChart
            // 
            chartArea1.Name = "ChartArea1";
            this.stockChart.ChartAreas.Add(chartArea1);
            this.stockChart.DataSource = this.foodsBindingSource;
            legend1.Name = "Legend1";
            this.stockChart.Legends.Add(legend1);
            this.stockChart.Location = new System.Drawing.Point(18, 307);
            this.stockChart.Name = "stockChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Food Stock";
            series1.XValueMember = "FoodName";
            series1.YValueMembers = "Quantity";
            this.stockChart.Series.Add(series1);
            this.stockChart.Size = new System.Drawing.Size(670, 409);
            this.stockChart.TabIndex = 2;
            this.stockChart.Text = "Stock Chart";
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(18, 733);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(93, 43);
            this.backButton.TabIndex = 4;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            this.backButton.MouseLeave += new System.EventHandler(this.backButton_MouseLeave);
            this.backButton.MouseHover += new System.EventHandler(this.backButton_MouseHover);
            // 
            // priceChart
            // 
            chartArea2.Name = "ChartArea1";
            this.priceChart.ChartAreas.Add(chartArea2);
            this.priceChart.DataSource = this.foodsBindingSource;
            legend2.Name = "Legend1";
            this.priceChart.Legends.Add(legend2);
            this.priceChart.Location = new System.Drawing.Point(694, 307);
            this.priceChart.Name = "priceChart";
            this.priceChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Price Per Unit";
            series2.XValueMember = "FoodName";
            series2.YValueMembers = "PerUnitPrice";
            this.priceChart.Series.Add(series2);
            this.priceChart.Size = new System.Drawing.Size(670, 409);
            this.priceChart.TabIndex = 5;
            this.priceChart.Text = "Price Chart";
            // 
            // _OOP2_I_DataSet
            // 
            this._OOP2_I_DataSet.DataSetName = "_OOP2_I_DataSet";
            this._OOP2_I_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // foodsBindingSource
            // 
            this.foodsBindingSource.DataMember = "Foods";
            this.foodsBindingSource.DataSource = this._OOP2_I_DataSet;
            // 
            // foodsTableAdapter
            // 
            this.foodsTableAdapter.ClearBeforeFill = true;
            // 
            // ingredientsDataGridViewTextBoxColumn
            // 
            this.ingredientsDataGridViewTextBoxColumn.DataPropertyName = "Ingredients";
            this.ingredientsDataGridViewTextBoxColumn.HeaderText = "Ingredients";
            this.ingredientsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ingredientsDataGridViewTextBoxColumn.Name = "ingredientsDataGridViewTextBoxColumn";
            this.ingredientsDataGridViewTextBoxColumn.ReadOnly = true;
            this.ingredientsDataGridViewTextBoxColumn.Width = 125;
            // 
            // perUnitPriceDataGridViewTextBoxColumn
            // 
            this.perUnitPriceDataGridViewTextBoxColumn.DataPropertyName = "PerUnitPrice";
            this.perUnitPriceDataGridViewTextBoxColumn.HeaderText = "PerUnitPrice";
            this.perUnitPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perUnitPriceDataGridViewTextBoxColumn.Name = "perUnitPriceDataGridViewTextBoxColumn";
            this.perUnitPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.perUnitPriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            this.quantityDataGridViewTextBoxColumn.Width = 125;
            // 
            // expDateDataGridViewTextBoxColumn
            // 
            this.expDateDataGridViewTextBoxColumn.DataPropertyName = "ExpDate";
            this.expDateDataGridViewTextBoxColumn.HeaderText = "ExpDate";
            this.expDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.expDateDataGridViewTextBoxColumn.Name = "expDateDataGridViewTextBoxColumn";
            this.expDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.expDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // mfgDateDataGridViewTextBoxColumn
            // 
            this.mfgDateDataGridViewTextBoxColumn.DataPropertyName = "MfgDate";
            this.mfgDateDataGridViewTextBoxColumn.HeaderText = "MfgDate";
            this.mfgDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mfgDateDataGridViewTextBoxColumn.Name = "mfgDateDataGridViewTextBoxColumn";
            this.mfgDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.mfgDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // foodCategoryDataGridViewTextBoxColumn
            // 
            this.foodCategoryDataGridViewTextBoxColumn.DataPropertyName = "FoodCategory";
            this.foodCategoryDataGridViewTextBoxColumn.HeaderText = "FoodCategory";
            this.foodCategoryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.foodCategoryDataGridViewTextBoxColumn.Name = "foodCategoryDataGridViewTextBoxColumn";
            this.foodCategoryDataGridViewTextBoxColumn.ReadOnly = true;
            this.foodCategoryDataGridViewTextBoxColumn.Width = 125;
            // 
            // foodNameDataGridViewTextBoxColumn
            // 
            this.foodNameDataGridViewTextBoxColumn.DataPropertyName = "FoodName";
            this.foodNameDataGridViewTextBoxColumn.HeaderText = "FoodName";
            this.foodNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.foodNameDataGridViewTextBoxColumn.Name = "foodNameDataGridViewTextBoxColumn";
            this.foodNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.foodNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // foodIdDataGridViewTextBoxColumn
            // 
            this.foodIdDataGridViewTextBoxColumn.DataPropertyName = "FoodId";
            this.foodIdDataGridViewTextBoxColumn.HeaderText = "FoodId";
            this.foodIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.foodIdDataGridViewTextBoxColumn.Name = "foodIdDataGridViewTextBoxColumn";
            this.foodIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.foodIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // listOfFoodsGridView
            // 
            this.listOfFoodsGridView.AllowUserToAddRows = false;
            this.listOfFoodsGridView.AllowUserToDeleteRows = false;
            this.listOfFoodsGridView.AutoGenerateColumns = false;
            this.listOfFoodsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listOfFoodsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.foodIdDataGridViewTextBoxColumn,
            this.foodNameDataGridViewTextBoxColumn,
            this.foodCategoryDataGridViewTextBoxColumn,
            this.mfgDateDataGridViewTextBoxColumn,
            this.expDateDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.perUnitPriceDataGridViewTextBoxColumn,
            this.ingredientsDataGridViewTextBoxColumn});
            this.listOfFoodsGridView.DataSource = this.foodsBindingSource;
            this.listOfFoodsGridView.Location = new System.Drawing.Point(6, 30);
            this.listOfFoodsGridView.Name = "listOfFoodsGridView";
            this.listOfFoodsGridView.ReadOnly = true;
            this.listOfFoodsGridView.RowHeadersWidth = 51;
            this.listOfFoodsGridView.RowTemplate.Height = 24;
            this.listOfFoodsGridView.Size = new System.Drawing.Size(1346, 253);
            this.listOfFoodsGridView.TabIndex = 0;
            // 
            // FoodChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 788);
            this.Controls.Add(this.priceChart);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.stockChart);
            this.Controls.Add(this.groupBox1);
            this.Name = "FoodChart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Food Chart";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FoodChart_FormClosing);
            this.Load += new System.EventHandler(this.FoodChart_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.stockChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._OOP2_I_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listOfFoodsGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart stockChart;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart priceChart;
        private _OOP2_I_DataSet _OOP2_I_DataSet;
        private System.Windows.Forms.BindingSource foodsBindingSource;
        private _OOP2_I_DataSetTableAdapters.FoodsTableAdapter foodsTableAdapter;
        private System.Windows.Forms.DataGridView listOfFoodsGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn foodIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn foodNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn foodCategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mfgDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perUnitPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ingredientsDataGridViewTextBoxColumn;
    }
}