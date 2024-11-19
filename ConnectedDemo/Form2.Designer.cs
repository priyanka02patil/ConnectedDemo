namespace ConnectedDemo
{
    partial class FormProduct
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
            this.labelPrdID = new System.Windows.Forms.Label();
            this.textBoxPrdID = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.labelPrdName = new System.Windows.Forms.Label();
            this.labelPrdPrice = new System.Windows.Forms.Label();
            this.textBoxPrdName = new System.Windows.Forms.TextBox();
            this.textBoxPrdPrice = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dataGridViewProduct = new System.Windows.Forms.DataGridView();
            this.btnProductList = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPrdID
            // 
            this.labelPrdID.AutoSize = true;
            this.labelPrdID.Location = new System.Drawing.Point(86, 50);
            this.labelPrdID.Name = "labelPrdID";
            this.labelPrdID.Size = new System.Drawing.Size(85, 20);
            this.labelPrdID.TabIndex = 0;
            this.labelPrdID.Text = "Product ID";
            // 
            // textBoxPrdID
            // 
            this.textBoxPrdID.Location = new System.Drawing.Point(241, 50);
            this.textBoxPrdID.Name = "textBoxPrdID";
            this.textBoxPrdID.Size = new System.Drawing.Size(242, 26);
            this.textBoxPrdID.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 335);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(128, 52);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // labelPrdName
            // 
            this.labelPrdName.AutoSize = true;
            this.labelPrdName.Location = new System.Drawing.Point(86, 129);
            this.labelPrdName.Name = "labelPrdName";
            this.labelPrdName.Size = new System.Drawing.Size(110, 20);
            this.labelPrdName.TabIndex = 3;
            this.labelPrdName.Text = "Product Name";
            // 
            // labelPrdPrice
            // 
            this.labelPrdPrice.AutoSize = true;
            this.labelPrdPrice.Location = new System.Drawing.Point(86, 210);
            this.labelPrdPrice.Name = "labelPrdPrice";
            this.labelPrdPrice.Size = new System.Drawing.Size(103, 20);
            this.labelPrdPrice.TabIndex = 4;
            this.labelPrdPrice.Text = "Product Price";
            // 
            // textBoxPrdName
            // 
            this.textBoxPrdName.Location = new System.Drawing.Point(241, 123);
            this.textBoxPrdName.Name = "textBoxPrdName";
            this.textBoxPrdName.Size = new System.Drawing.Size(242, 26);
            this.textBoxPrdName.TabIndex = 6;
            // 
            // textBoxPrdPrice
            // 
            this.textBoxPrdPrice.Location = new System.Drawing.Point(241, 204);
            this.textBoxPrdPrice.Name = "textBoxPrdPrice";
            this.textBoxPrdPrice.Size = new System.Drawing.Size(242, 26);
            this.textBoxPrdPrice.TabIndex = 7;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(163, 335);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(128, 52);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(313, 335);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(128, 52);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(463, 335);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(128, 52);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dataGridViewProduct
            // 
            this.dataGridViewProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProduct.Location = new System.Drawing.Point(644, 34);
            this.dataGridViewProduct.Name = "dataGridViewProduct";
            this.dataGridViewProduct.RowHeadersWidth = 62;
            this.dataGridViewProduct.RowTemplate.Height = 28;
            this.dataGridViewProduct.Size = new System.Drawing.Size(724, 383);
            this.dataGridViewProduct.TabIndex = 12;
            // 
            // btnProductList
            // 
            this.btnProductList.Location = new System.Drawing.Point(746, 447);
            this.btnProductList.Name = "btnProductList";
            this.btnProductList.Size = new System.Drawing.Size(269, 61);
            this.btnProductList.TabIndex = 13;
            this.btnProductList.Text = "Show All Product List";
            this.btnProductList.UseVisualStyleBackColor = true;
            this.btnProductList.Click += new System.EventHandler(this.btnProductList_Click);
            // 
            // FormProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1406, 555);
            this.Controls.Add(this.btnProductList);
            this.Controls.Add(this.dataGridViewProduct);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.textBoxPrdPrice);
            this.Controls.Add(this.textBoxPrdName);
            this.Controls.Add(this.labelPrdPrice);
            this.Controls.Add(this.labelPrdName);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.textBoxPrdID);
            this.Controls.Add(this.labelPrdID);
            this.Name = "FormProduct";
            this.Text = "Product Form";
            this.Load += new System.EventHandler(this.FormProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPrdID;
        private System.Windows.Forms.TextBox textBoxPrdID;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label labelPrdName;
        private System.Windows.Forms.Label labelPrdPrice;
        private System.Windows.Forms.TextBox textBoxPrdName;
        private System.Windows.Forms.TextBox textBoxPrdPrice;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dataGridViewProduct;
        private System.Windows.Forms.Button btnProductList;
    }
}