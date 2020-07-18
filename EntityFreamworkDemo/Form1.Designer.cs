namespace EntityFreamworkDemo
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
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.gbxUpdate = new System.Windows.Forms.GroupBox();
            this.tbxName2 = new System.Windows.Forms.TextBox();
            this.lblName2 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbxStockAmount2 = new System.Windows.Forms.TextBox();
            this.tbxunitPrice2 = new System.Windows.Forms.TextBox();
            this.lblUnitPrice2 = new System.Windows.Forms.Label();
            this.lblStockAmount2 = new System.Windows.Forms.Label();
            this.gbxAdd = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbxStockAmount = new System.Windows.Forms.TextBox();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbxunitPrice = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.lblStockAmount = new System.Windows.Forms.Label();
            this.dgwProducts = new System.Windows.Forms.DataGridView();
            this.gbxUpdate.SuspendLayout();
            this.gbxAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(556, 16);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(125, 20);
            this.tbxSearch.TabIndex = 15;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(498, 19);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(41, 13);
            this.lblSearch.TabIndex = 14;
            this.lblSearch.Text = "Search";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(327, 366);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(148, 23);
            this.btnRemove.TabIndex = 13;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // gbxUpdate
            // 
            this.gbxUpdate.Controls.Add(this.tbxName2);
            this.gbxUpdate.Controls.Add(this.lblName2);
            this.gbxUpdate.Controls.Add(this.btnUpdate);
            this.gbxUpdate.Controls.Add(this.tbxStockAmount2);
            this.gbxUpdate.Controls.Add(this.tbxunitPrice2);
            this.gbxUpdate.Controls.Add(this.lblUnitPrice2);
            this.gbxUpdate.Controls.Add(this.lblStockAmount2);
            this.gbxUpdate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxUpdate.Location = new System.Drawing.Point(501, 236);
            this.gbxUpdate.Name = "gbxUpdate";
            this.gbxUpdate.Size = new System.Drawing.Size(265, 153);
            this.gbxUpdate.TabIndex = 12;
            this.gbxUpdate.TabStop = false;
            this.gbxUpdate.Text = "Update a product";
            // 
            // tbxName2
            // 
            this.tbxName2.Location = new System.Drawing.Point(95, 28);
            this.tbxName2.Name = "tbxName2";
            this.tbxName2.Size = new System.Drawing.Size(148, 21);
            this.tbxName2.TabIndex = 10;
            // 
            // lblName2
            // 
            this.lblName2.AutoSize = true;
            this.lblName2.Location = new System.Drawing.Point(16, 28);
            this.lblName2.Name = "lblName2";
            this.lblName2.Size = new System.Drawing.Size(34, 13);
            this.lblName2.TabIndex = 9;
            this.lblName2.Text = "Name";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(95, 124);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(148, 23);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbxStockAmount2
            // 
            this.tbxStockAmount2.Location = new System.Drawing.Point(95, 87);
            this.tbxStockAmount2.Name = "tbxStockAmount2";
            this.tbxStockAmount2.Size = new System.Drawing.Size(148, 21);
            this.tbxStockAmount2.TabIndex = 7;
            // 
            // tbxunitPrice2
            // 
            this.tbxunitPrice2.Location = new System.Drawing.Point(95, 58);
            this.tbxunitPrice2.Name = "tbxunitPrice2";
            this.tbxunitPrice2.Size = new System.Drawing.Size(148, 21);
            this.tbxunitPrice2.TabIndex = 6;
            // 
            // lblUnitPrice2
            // 
            this.lblUnitPrice2.AutoSize = true;
            this.lblUnitPrice2.Location = new System.Drawing.Point(16, 58);
            this.lblUnitPrice2.Name = "lblUnitPrice2";
            this.lblUnitPrice2.Size = new System.Drawing.Size(52, 13);
            this.lblUnitPrice2.TabIndex = 3;
            this.lblUnitPrice2.Text = "Unit Price";
            // 
            // lblStockAmount2
            // 
            this.lblStockAmount2.AutoSize = true;
            this.lblStockAmount2.Location = new System.Drawing.Point(16, 95);
            this.lblStockAmount2.Name = "lblStockAmount2";
            this.lblStockAmount2.Size = new System.Drawing.Size(73, 13);
            this.lblStockAmount2.TabIndex = 4;
            this.lblStockAmount2.Text = "Stock Amount";
            // 
            // gbxAdd
            // 
            this.gbxAdd.Controls.Add(this.btnAdd);
            this.gbxAdd.Controls.Add(this.tbxStockAmount);
            this.gbxAdd.Controls.Add(this.tbxName);
            this.gbxAdd.Controls.Add(this.tbxunitPrice);
            this.gbxAdd.Controls.Add(this.lblName);
            this.gbxAdd.Controls.Add(this.lblUnitPrice);
            this.gbxAdd.Controls.Add(this.lblStockAmount);
            this.gbxAdd.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxAdd.Location = new System.Drawing.Point(29, 236);
            this.gbxAdd.Name = "gbxAdd";
            this.gbxAdd.Size = new System.Drawing.Size(265, 159);
            this.gbxAdd.TabIndex = 11;
            this.gbxAdd.TabStop = false;
            this.gbxAdd.Text = "Add a product";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(95, 130);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(148, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbxStockAmount
            // 
            this.tbxStockAmount.Location = new System.Drawing.Point(95, 99);
            this.tbxStockAmount.Name = "tbxStockAmount";
            this.tbxStockAmount.Size = new System.Drawing.Size(148, 21);
            this.tbxStockAmount.TabIndex = 7;
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(95, 20);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(148, 21);
            this.tbxName.TabIndex = 5;
            // 
            // tbxunitPrice
            // 
            this.tbxunitPrice.Location = new System.Drawing.Point(95, 58);
            this.tbxunitPrice.Name = "tbxunitPrice";
            this.tbxunitPrice.Size = new System.Drawing.Size(148, 21);
            this.tbxunitPrice.TabIndex = 6;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(16, 22);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(34, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name";
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Location = new System.Drawing.Point(16, 61);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(52, 13);
            this.lblUnitPrice.TabIndex = 3;
            this.lblUnitPrice.Text = "Unit Price";
            // 
            // lblStockAmount
            // 
            this.lblStockAmount.AutoSize = true;
            this.lblStockAmount.Location = new System.Drawing.Point(16, 102);
            this.lblStockAmount.Name = "lblStockAmount";
            this.lblStockAmount.Size = new System.Drawing.Size(73, 13);
            this.lblStockAmount.TabIndex = 4;
            this.lblStockAmount.Text = "Stock Amount";
            // 
            // dgwProducts
            // 
            this.dgwProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProducts.Location = new System.Drawing.Point(29, 60);
            this.dgwProducts.Name = "dgwProducts";
            this.dgwProducts.Size = new System.Drawing.Size(737, 170);
            this.dgwProducts.TabIndex = 10;
            this.dgwProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProducts_CellClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.gbxUpdate);
            this.Controls.Add(this.gbxAdd);
            this.Controls.Add(this.dgwProducts);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxUpdate.ResumeLayout(false);
            this.gbxUpdate.PerformLayout();
            this.gbxAdd.ResumeLayout(false);
            this.gbxAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.GroupBox gbxUpdate;
        private System.Windows.Forms.TextBox tbxName2;
        private System.Windows.Forms.Label lblName2;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tbxStockAmount2;
        private System.Windows.Forms.TextBox tbxunitPrice2;
        private System.Windows.Forms.Label lblUnitPrice2;
        private System.Windows.Forms.Label lblStockAmount2;
        private System.Windows.Forms.GroupBox gbxAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbxStockAmount;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.TextBox tbxunitPrice;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.Label lblStockAmount;
        private System.Windows.Forms.DataGridView dgwProducts;
    }
}

