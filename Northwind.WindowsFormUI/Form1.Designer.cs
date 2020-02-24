namespace Northwind.WindowsFormUI
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
            this.gBoxCategory = new System.Windows.Forms.GroupBox();
            this.cBoxCategories = new System.Windows.Forms.ComboBox();
            this.lblCategories = new System.Windows.Forms.Label();
            this.gBoxProducts = new System.Windows.Forms.GroupBox();
            this.txtBoxProductName = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.dgwProduct = new System.Windows.Forms.DataGridView();
            this.gbCreate = new System.Windows.Forms.GroupBox();
            this.lblPCName = new System.Windows.Forms.Label();
            this.lblPCCaterory = new System.Windows.Forms.Label();
            this.lblPCPreis = new System.Windows.Forms.Label();
            this.txtCPProductName = new System.Windows.Forms.TextBox();
            this.txtCPPreis = new System.Windows.Forms.TextBox();
            this.cbCPCategory = new System.Windows.Forms.ComboBox();
            this.lblCPStock = new System.Windows.Forms.Label();
            this.lblCPQuantityPerUnit = new System.Windows.Forms.Label();
            this.txtCPUnitsInStock = new System.Windows.Forms.TextBox();
            this.txtCPQuantityPerUnit = new System.Windows.Forms.TextBox();
            this.btnCProduct = new System.Windows.Forms.Button();
            this.gbUpdate = new System.Windows.Forms.GroupBox();
            this.btnUProduct = new System.Windows.Forms.Button();
            this.txtUPQuantityPerUnit = new System.Windows.Forms.TextBox();
            this.txtUPUnitsInStock = new System.Windows.Forms.TextBox();
            this.lblUPQuantityPerUnit = new System.Windows.Forms.Label();
            this.lblUPUnitsInStock = new System.Windows.Forms.Label();
            this.cbUPCategory = new System.Windows.Forms.ComboBox();
            this.txtUPPreis = new System.Windows.Forms.TextBox();
            this.txtUPName = new System.Windows.Forms.TextBox();
            this.lblUPPreis = new System.Windows.Forms.Label();
            this.lblUPCategory = new System.Windows.Forms.Label();
            this.lblUPName = new System.Windows.Forms.Label();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.gBoxCategory.SuspendLayout();
            this.gBoxProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).BeginInit();
            this.gbCreate.SuspendLayout();
            this.gbUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBoxCategory
            // 
            this.gBoxCategory.Controls.Add(this.cBoxCategories);
            this.gBoxCategory.Controls.Add(this.lblCategories);
            this.gBoxCategory.Location = new System.Drawing.Point(25, 12);
            this.gBoxCategory.Name = "gBoxCategory";
            this.gBoxCategory.Size = new System.Drawing.Size(709, 64);
            this.gBoxCategory.TabIndex = 0;
            this.gBoxCategory.TabStop = false;
            this.gBoxCategory.Text = "Search by Category";
            // 
            // cBoxCategories
            // 
            this.cBoxCategories.FormattingEnabled = true;
            this.cBoxCategories.Location = new System.Drawing.Point(93, 27);
            this.cBoxCategories.Name = "cBoxCategories";
            this.cBoxCategories.Size = new System.Drawing.Size(212, 21);
            this.cBoxCategories.TabIndex = 1;
            this.cBoxCategories.SelectedIndexChanged += new System.EventHandler(this.cBoxCategories_SelectedIndexChanged);
            // 
            // lblCategories
            // 
            this.lblCategories.AutoSize = true;
            this.lblCategories.Location = new System.Drawing.Point(6, 30);
            this.lblCategories.Name = "lblCategories";
            this.lblCategories.Size = new System.Drawing.Size(63, 13);
            this.lblCategories.TabIndex = 0;
            this.lblCategories.Text = "Categories :";
            // 
            // gBoxProducts
            // 
            this.gBoxProducts.Controls.Add(this.txtBoxProductName);
            this.gBoxProducts.Controls.Add(this.lblProductName);
            this.gBoxProducts.Location = new System.Drawing.Point(25, 100);
            this.gBoxProducts.Name = "gBoxProducts";
            this.gBoxProducts.Size = new System.Drawing.Size(709, 84);
            this.gBoxProducts.TabIndex = 1;
            this.gBoxProducts.TabStop = false;
            this.gBoxProducts.Text = "Search by Product Name";
            // 
            // txtBoxProductName
            // 
            this.txtBoxProductName.Location = new System.Drawing.Point(93, 29);
            this.txtBoxProductName.Name = "txtBoxProductName";
            this.txtBoxProductName.Size = new System.Drawing.Size(212, 20);
            this.txtBoxProductName.TabIndex = 2;
            this.txtBoxProductName.TextChanged += new System.EventHandler(this.txtBoxProductName_TextChanged);
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(6, 32);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(81, 13);
            this.lblProductName.TabIndex = 1;
            this.lblProductName.Text = "Product Name :";
            // 
            // dgwProduct
            // 
            this.dgwProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProduct.Location = new System.Drawing.Point(25, 191);
            this.dgwProduct.Name = "dgwProduct";
            this.dgwProduct.Size = new System.Drawing.Size(709, 150);
            this.dgwProduct.TabIndex = 2;
            this.dgwProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProduct_CellClick);
            // 
            // gbCreate
            // 
            this.gbCreate.Controls.Add(this.btnCProduct);
            this.gbCreate.Controls.Add(this.txtCPQuantityPerUnit);
            this.gbCreate.Controls.Add(this.txtCPUnitsInStock);
            this.gbCreate.Controls.Add(this.lblCPQuantityPerUnit);
            this.gbCreate.Controls.Add(this.lblCPStock);
            this.gbCreate.Controls.Add(this.cbCPCategory);
            this.gbCreate.Controls.Add(this.txtCPPreis);
            this.gbCreate.Controls.Add(this.txtCPProductName);
            this.gbCreate.Controls.Add(this.lblPCPreis);
            this.gbCreate.Controls.Add(this.lblPCCaterory);
            this.gbCreate.Controls.Add(this.lblPCName);
            this.gbCreate.Location = new System.Drawing.Point(25, 390);
            this.gbCreate.Name = "gbCreate";
            this.gbCreate.Size = new System.Drawing.Size(672, 116);
            this.gbCreate.TabIndex = 3;
            this.gbCreate.TabStop = false;
            this.gbCreate.Text = "Create New Product";
            // 
            // lblPCName
            // 
            this.lblPCName.AutoSize = true;
            this.lblPCName.Location = new System.Drawing.Point(6, 28);
            this.lblPCName.Name = "lblPCName";
            this.lblPCName.Size = new System.Drawing.Size(81, 13);
            this.lblPCName.TabIndex = 0;
            this.lblPCName.Text = "Product Name :";
            // 
            // lblPCCaterory
            // 
            this.lblPCCaterory.AutoSize = true;
            this.lblPCCaterory.Location = new System.Drawing.Point(6, 54);
            this.lblPCCaterory.Name = "lblPCCaterory";
            this.lblPCCaterory.Size = new System.Drawing.Size(55, 13);
            this.lblPCCaterory.TabIndex = 1;
            this.lblPCCaterory.Text = "Category :";
            // 
            // lblPCPreis
            // 
            this.lblPCPreis.AutoSize = true;
            this.lblPCPreis.Location = new System.Drawing.Point(6, 84);
            this.lblPCPreis.Name = "lblPCPreis";
            this.lblPCPreis.Size = new System.Drawing.Size(36, 13);
            this.lblPCPreis.TabIndex = 2;
            this.lblPCPreis.Text = "Preis :";
            // 
            // txtCPProductName
            // 
            this.txtCPProductName.Location = new System.Drawing.Point(93, 25);
            this.txtCPProductName.Name = "txtCPProductName";
            this.txtCPProductName.Size = new System.Drawing.Size(212, 20);
            this.txtCPProductName.TabIndex = 3;
            // 
            // txtCPPreis
            // 
            this.txtCPPreis.Location = new System.Drawing.Point(93, 81);
            this.txtCPPreis.Name = "txtCPPreis";
            this.txtCPPreis.Size = new System.Drawing.Size(212, 20);
            this.txtCPPreis.TabIndex = 4;
            // 
            // cbCPCategory
            // 
            this.cbCPCategory.FormattingEnabled = true;
            this.cbCPCategory.Location = new System.Drawing.Point(93, 54);
            this.cbCPCategory.Name = "cbCPCategory";
            this.cbCPCategory.Size = new System.Drawing.Size(212, 21);
            this.cbCPCategory.TabIndex = 5;
            // 
            // lblCPStock
            // 
            this.lblCPStock.AutoSize = true;
            this.lblCPStock.Location = new System.Drawing.Point(328, 28);
            this.lblCPStock.Name = "lblCPStock";
            this.lblCPStock.Size = new System.Drawing.Size(79, 13);
            this.lblCPStock.TabIndex = 6;
            this.lblCPStock.Text = "Units in Stock :";
            // 
            // lblCPQuantityPerUnit
            // 
            this.lblCPQuantityPerUnit.AutoSize = true;
            this.lblCPQuantityPerUnit.Location = new System.Drawing.Point(328, 54);
            this.lblCPQuantityPerUnit.Name = "lblCPQuantityPerUnit";
            this.lblCPQuantityPerUnit.Size = new System.Drawing.Size(92, 13);
            this.lblCPQuantityPerUnit.TabIndex = 7;
            this.lblCPQuantityPerUnit.Text = "Quantity per Unit :";
            // 
            // txtCPUnitsInStock
            // 
            this.txtCPUnitsInStock.Location = new System.Drawing.Point(422, 25);
            this.txtCPUnitsInStock.Name = "txtCPUnitsInStock";
            this.txtCPUnitsInStock.Size = new System.Drawing.Size(127, 20);
            this.txtCPUnitsInStock.TabIndex = 8;
            // 
            // txtCPQuantityPerUnit
            // 
            this.txtCPQuantityPerUnit.Location = new System.Drawing.Point(422, 51);
            this.txtCPQuantityPerUnit.Name = "txtCPQuantityPerUnit";
            this.txtCPQuantityPerUnit.Size = new System.Drawing.Size(127, 20);
            this.txtCPQuantityPerUnit.TabIndex = 9;
            // 
            // btnCProduct
            // 
            this.btnCProduct.Location = new System.Drawing.Point(422, 84);
            this.btnCProduct.Name = "btnCProduct";
            this.btnCProduct.Size = new System.Drawing.Size(127, 23);
            this.btnCProduct.TabIndex = 10;
            this.btnCProduct.Text = "Add";
            this.btnCProduct.UseVisualStyleBackColor = true;
            this.btnCProduct.Click += new System.EventHandler(this.btnCProduct_Click);
            // 
            // gbUpdate
            // 
            this.gbUpdate.Controls.Add(this.btnUProduct);
            this.gbUpdate.Controls.Add(this.txtUPQuantityPerUnit);
            this.gbUpdate.Controls.Add(this.txtUPUnitsInStock);
            this.gbUpdate.Controls.Add(this.lblUPQuantityPerUnit);
            this.gbUpdate.Controls.Add(this.lblUPUnitsInStock);
            this.gbUpdate.Controls.Add(this.cbUPCategory);
            this.gbUpdate.Controls.Add(this.txtUPPreis);
            this.gbUpdate.Controls.Add(this.txtUPName);
            this.gbUpdate.Controls.Add(this.lblUPPreis);
            this.gbUpdate.Controls.Add(this.lblUPCategory);
            this.gbUpdate.Controls.Add(this.lblUPName);
            this.gbUpdate.Location = new System.Drawing.Point(25, 532);
            this.gbUpdate.Name = "gbUpdate";
            this.gbUpdate.Size = new System.Drawing.Size(672, 116);
            this.gbUpdate.TabIndex = 4;
            this.gbUpdate.TabStop = false;
            this.gbUpdate.Text = "Update Product";
            // 
            // btnUProduct
            // 
            this.btnUProduct.Location = new System.Drawing.Point(422, 84);
            this.btnUProduct.Name = "btnUProduct";
            this.btnUProduct.Size = new System.Drawing.Size(127, 23);
            this.btnUProduct.TabIndex = 10;
            this.btnUProduct.Text = "Update";
            this.btnUProduct.UseVisualStyleBackColor = true;
            this.btnUProduct.Click += new System.EventHandler(this.btnUProduct_Click);
            // 
            // txtUPQuantityPerUnit
            // 
            this.txtUPQuantityPerUnit.Location = new System.Drawing.Point(422, 51);
            this.txtUPQuantityPerUnit.Name = "txtUPQuantityPerUnit";
            this.txtUPQuantityPerUnit.Size = new System.Drawing.Size(127, 20);
            this.txtUPQuantityPerUnit.TabIndex = 9;
            // 
            // txtUPUnitsInStock
            // 
            this.txtUPUnitsInStock.Location = new System.Drawing.Point(422, 25);
            this.txtUPUnitsInStock.Name = "txtUPUnitsInStock";
            this.txtUPUnitsInStock.Size = new System.Drawing.Size(127, 20);
            this.txtUPUnitsInStock.TabIndex = 8;
            // 
            // lblUPQuantityPerUnit
            // 
            this.lblUPQuantityPerUnit.AutoSize = true;
            this.lblUPQuantityPerUnit.Location = new System.Drawing.Point(328, 54);
            this.lblUPQuantityPerUnit.Name = "lblUPQuantityPerUnit";
            this.lblUPQuantityPerUnit.Size = new System.Drawing.Size(92, 13);
            this.lblUPQuantityPerUnit.TabIndex = 7;
            this.lblUPQuantityPerUnit.Text = "Quantity per Unit :";
            // 
            // lblUPUnitsInStock
            // 
            this.lblUPUnitsInStock.AutoSize = true;
            this.lblUPUnitsInStock.Location = new System.Drawing.Point(328, 28);
            this.lblUPUnitsInStock.Name = "lblUPUnitsInStock";
            this.lblUPUnitsInStock.Size = new System.Drawing.Size(79, 13);
            this.lblUPUnitsInStock.TabIndex = 6;
            this.lblUPUnitsInStock.Text = "Units in Stock :";
            // 
            // cbUPCategory
            // 
            this.cbUPCategory.FormattingEnabled = true;
            this.cbUPCategory.Location = new System.Drawing.Point(93, 54);
            this.cbUPCategory.Name = "cbUPCategory";
            this.cbUPCategory.Size = new System.Drawing.Size(212, 21);
            this.cbUPCategory.TabIndex = 5;
            // 
            // txtUPPreis
            // 
            this.txtUPPreis.Location = new System.Drawing.Point(93, 81);
            this.txtUPPreis.Name = "txtUPPreis";
            this.txtUPPreis.Size = new System.Drawing.Size(212, 20);
            this.txtUPPreis.TabIndex = 4;
            // 
            // txtUPName
            // 
            this.txtUPName.Location = new System.Drawing.Point(93, 25);
            this.txtUPName.Name = "txtUPName";
            this.txtUPName.Size = new System.Drawing.Size(212, 20);
            this.txtUPName.TabIndex = 3;
            // 
            // lblUPPreis
            // 
            this.lblUPPreis.AutoSize = true;
            this.lblUPPreis.Location = new System.Drawing.Point(6, 84);
            this.lblUPPreis.Name = "lblUPPreis";
            this.lblUPPreis.Size = new System.Drawing.Size(36, 13);
            this.lblUPPreis.TabIndex = 2;
            this.lblUPPreis.Text = "Preis :";
            // 
            // lblUPCategory
            // 
            this.lblUPCategory.AutoSize = true;
            this.lblUPCategory.Location = new System.Drawing.Point(6, 54);
            this.lblUPCategory.Name = "lblUPCategory";
            this.lblUPCategory.Size = new System.Drawing.Size(55, 13);
            this.lblUPCategory.TabIndex = 1;
            this.lblUPCategory.Text = "Category :";
            // 
            // lblUPName
            // 
            this.lblUPName.AutoSize = true;
            this.lblUPName.Location = new System.Drawing.Point(6, 28);
            this.lblUPName.Name = "lblUPName";
            this.lblUPName.Size = new System.Drawing.Size(81, 13);
            this.lblUPName.TabIndex = 0;
            this.lblUPName.Text = "Product Name :";
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Location = new System.Drawing.Point(571, 347);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(126, 37);
            this.btnDeleteProduct.TabIndex = 5;
            this.btnDeleteProduct.Text = "Delete";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 686);
            this.Controls.Add(this.btnDeleteProduct);
            this.Controls.Add(this.gbUpdate);
            this.Controls.Add(this.gbCreate);
            this.Controls.Add(this.dgwProduct);
            this.Controls.Add(this.gBoxProducts);
            this.Controls.Add(this.gBoxCategory);
            this.Name = "Form1";
            this.Text = "Products";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gBoxCategory.ResumeLayout(false);
            this.gBoxCategory.PerformLayout();
            this.gBoxProducts.ResumeLayout(false);
            this.gBoxProducts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).EndInit();
            this.gbCreate.ResumeLayout(false);
            this.gbCreate.PerformLayout();
            this.gbUpdate.ResumeLayout(false);
            this.gbUpdate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxCategory;
        private System.Windows.Forms.Label lblCategories;
        private System.Windows.Forms.ComboBox cBoxCategories;
        private System.Windows.Forms.GroupBox gBoxProducts;
        private System.Windows.Forms.TextBox txtBoxProductName;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.DataGridView dgwProduct;
        private System.Windows.Forms.GroupBox gbCreate;
        private System.Windows.Forms.ComboBox cbCPCategory;
        private System.Windows.Forms.TextBox txtCPPreis;
        private System.Windows.Forms.TextBox txtCPProductName;
        private System.Windows.Forms.Label lblPCPreis;
        private System.Windows.Forms.Label lblPCCaterory;
        private System.Windows.Forms.Label lblPCName;
        private System.Windows.Forms.Label lblCPQuantityPerUnit;
        private System.Windows.Forms.Label lblCPStock;
        private System.Windows.Forms.TextBox txtCPQuantityPerUnit;
        private System.Windows.Forms.TextBox txtCPUnitsInStock;
        private System.Windows.Forms.Button btnCProduct;
        private System.Windows.Forms.GroupBox gbUpdate;
        private System.Windows.Forms.Button btnUProduct;
        private System.Windows.Forms.TextBox txtUPQuantityPerUnit;
        private System.Windows.Forms.TextBox txtUPUnitsInStock;
        private System.Windows.Forms.Label lblUPQuantityPerUnit;
        private System.Windows.Forms.Label lblUPUnitsInStock;
        private System.Windows.Forms.ComboBox cbUPCategory;
        private System.Windows.Forms.TextBox txtUPPreis;
        private System.Windows.Forms.TextBox txtUPName;
        private System.Windows.Forms.Label lblUPPreis;
        private System.Windows.Forms.Label lblUPCategory;
        private System.Windows.Forms.Label lblUPName;
        private System.Windows.Forms.Button btnDeleteProduct;
    }
}

