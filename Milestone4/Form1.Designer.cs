namespace Milestone4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lbl_price = new System.Windows.Forms.Label();
            this.lbl_origin = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_stock = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtb_origin = new System.Windows.Forms.TextBox();
            this.txtb_price = new System.Windows.Forms.TextBox();
            this.txtb_stock = new System.Windows.Forms.TextBox();
            this.txtb_id = new System.Windows.Forms.TextBox();
            this.Title = new System.Windows.Forms.Label();
            this.txtb_name = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtb_searchName = new System.Windows.Forms.TextBox();
            this.txtb_searchOrigin = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtb_stockId = new System.Windows.Forms.TextBox();
            this.txtb_restock = new System.Windows.Forms.TextBox();
            this.btn_restock = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtb_remove = new System.Windows.Forms.TextBox();
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_showItems = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1178, 630);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lbl_price);
            this.tabPage1.Controls.Add(this.lbl_origin);
            this.tabPage1.Controls.Add(this.lbl_id);
            this.tabPage1.Controls.Add(this.lbl_stock);
            this.tabPage1.Controls.Add(this.lbl_name);
            this.tabPage1.Controls.Add(this.btn_add);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtb_origin);
            this.tabPage1.Controls.Add(this.txtb_price);
            this.tabPage1.Controls.Add(this.txtb_stock);
            this.tabPage1.Controls.Add(this.txtb_id);
            this.tabPage1.Controls.Add(this.Title);
            this.tabPage1.Controls.Add(this.txtb_name);
            this.tabPage1.Location = new System.Drawing.Point(8, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1162, 583);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add Product";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Location = new System.Drawing.Point(20, 405);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(202, 25);
            this.lbl_price.TabIndex = 12;
            this.lbl_price.Text = "Enter Item Price ($):";
            // 
            // lbl_origin
            // 
            this.lbl_origin.AutoSize = true;
            this.lbl_origin.Location = new System.Drawing.Point(643, 308);
            this.lbl_origin.Name = "lbl_origin";
            this.lbl_origin.Size = new System.Drawing.Size(178, 25);
            this.lbl_origin.TabIndex = 11;
            this.lbl_origin.Text = "Enter Item Origin:";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(643, 216);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(141, 25);
            this.lbl_id.TabIndex = 10;
            this.lbl_id.Text = "Enter Item ID:";
            // 
            // lbl_stock
            // 
            this.lbl_stock.AutoSize = true;
            this.lbl_stock.Location = new System.Drawing.Point(20, 308);
            this.lbl_stock.Name = "lbl_stock";
            this.lbl_stock.Size = new System.Drawing.Size(175, 25);
            this.lbl_stock.TabIndex = 9;
            this.lbl_stock.Text = "Enter Item Stock:";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(18, 216);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(177, 25);
            this.lbl_name.TabIndex = 8;
            this.lbl_name.Text = "Enter Item Name:";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(871, 391);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(138, 52);
            this.btn_add.TabIndex = 7;
            this.btn_add.Text = "Add Item";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(175, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 37);
            this.label1.TabIndex = 6;
            this.label1.Text = "Add Item:";
            // 
            // txtb_origin
            // 
            this.txtb_origin.Location = new System.Drawing.Point(827, 305);
            this.txtb_origin.Multiline = true;
            this.txtb_origin.Name = "txtb_origin";
            this.txtb_origin.Size = new System.Drawing.Size(298, 44);
            this.txtb_origin.TabIndex = 5;
            // 
            // txtb_price
            // 
            this.txtb_price.Location = new System.Drawing.Point(222, 391);
            this.txtb_price.Multiline = true;
            this.txtb_price.Name = "txtb_price";
            this.txtb_price.Size = new System.Drawing.Size(298, 44);
            this.txtb_price.TabIndex = 4;
            // 
            // txtb_stock
            // 
            this.txtb_stock.Location = new System.Drawing.Point(222, 305);
            this.txtb_stock.Multiline = true;
            this.txtb_stock.Name = "txtb_stock";
            this.txtb_stock.Size = new System.Drawing.Size(298, 44);
            this.txtb_stock.TabIndex = 3;
            // 
            // txtb_id
            // 
            this.txtb_id.Location = new System.Drawing.Point(827, 213);
            this.txtb_id.Multiline = true;
            this.txtb_id.Name = "txtb_id";
            this.txtb_id.Size = new System.Drawing.Size(298, 44);
            this.txtb_id.TabIndex = 2;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Segoe MDL2 Assets", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(394, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(319, 53);
            this.Title.TabIndex = 1;
            this.Title.Text = "Farmers Market";
            // 
            // txtb_name
            // 
            this.txtb_name.Location = new System.Drawing.Point(222, 213);
            this.txtb_name.Multiline = true;
            this.txtb_name.Name = "txtb_name";
            this.txtb_name.Size = new System.Drawing.Size(298, 44);
            this.txtb_name.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.txtb_searchName);
            this.tabPage2.Controls.Add(this.txtb_searchOrigin);
            this.tabPage2.Controls.Add(this.btn_search);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.txtb_stockId);
            this.tabPage2.Controls.Add(this.txtb_restock);
            this.tabPage2.Controls.Add(this.btn_restock);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.txtb_remove);
            this.tabPage2.Controls.Add(this.btn_remove);
            this.tabPage2.Controls.Add(this.btn_showItems);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(8, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1162, 583);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Products";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtb_searchName
            // 
            this.txtb_searchName.Location = new System.Drawing.Point(176, 372);
            this.txtb_searchName.Name = "txtb_searchName";
            this.txtb_searchName.Size = new System.Drawing.Size(144, 31);
            this.txtb_searchName.TabIndex = 13;
            // 
            // txtb_searchOrigin
            // 
            this.txtb_searchOrigin.Location = new System.Drawing.Point(176, 456);
            this.txtb_searchOrigin.Name = "txtb_searchOrigin";
            this.txtb_searchOrigin.Size = new System.Drawing.Size(144, 31);
            this.txtb_searchOrigin.TabIndex = 12;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(176, 501);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(144, 60);
            this.btn_search.TabIndex = 11;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(967, 434);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 53);
            this.label5.TabIndex = 10;
            this.label5.Text = "Press Again After Editing Inventory";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(477, 417);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Stock:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(477, 344);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Enter Item ID:";
            // 
            // txtb_stockId
            // 
            this.txtb_stockId.Location = new System.Drawing.Point(482, 372);
            this.txtb_stockId.Multiline = true;
            this.txtb_stockId.Name = "txtb_stockId";
            this.txtb_stockId.Size = new System.Drawing.Size(144, 31);
            this.txtb_stockId.TabIndex = 7;
         //   this.txtb_stockId.TextChanged += new System.EventHandler(this.txtb_stockId_TextChanged);
            // 
            // txtb_restock
            // 
            this.txtb_restock.Location = new System.Drawing.Point(482, 456);
            this.txtb_restock.Multiline = true;
            this.txtb_restock.Name = "txtb_restock";
            this.txtb_restock.Size = new System.Drawing.Size(144, 31);
            this.txtb_restock.TabIndex = 6;
            // 
            // btn_restock
            // 
            this.btn_restock.Location = new System.Drawing.Point(482, 501);
            this.btn_restock.Name = "btn_restock";
            this.btn_restock.Size = new System.Drawing.Size(144, 60);
            this.btn_restock.TabIndex = 5;
            this.btn_restock.Text = "Restock Item";
            this.btn_restock.UseVisualStyleBackColor = true;
            this.btn_restock.Click += new System.EventHandler(this.btn_restock_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(745, 417);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter Item ID:";
            // 
            // txtb_remove
            // 
            this.txtb_remove.Location = new System.Drawing.Point(750, 456);
            this.txtb_remove.Multiline = true;
            this.txtb_remove.Name = "txtb_remove";
            this.txtb_remove.Size = new System.Drawing.Size(144, 31);
            this.txtb_remove.TabIndex = 3;
            // 
            // btn_remove
            // 
            this.btn_remove.Location = new System.Drawing.Point(750, 501);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(144, 60);
            this.btn_remove.TabIndex = 2;
            this.btn_remove.Text = "Remove Item";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // btn_showItems
            // 
            this.btn_showItems.Location = new System.Drawing.Point(972, 501);
            this.btn_showItems.Name = "btn_showItems";
            this.btn_showItems.Size = new System.Drawing.Size(144, 60);
            this.btn_showItems.TabIndex = 1;
            this.btn_showItems.Text = "Show Items";
            this.btn_showItems.UseVisualStyleBackColor = true;
            this.btn_showItems.Click += new System.EventHandler(this.btn_showItems_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-8, -10);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1140, 345);
            this.dataGridView1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 372);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Item Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 456);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 25);
            this.label7.TabIndex = 15;
            this.label7.Text = "Item Origin:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 628);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Inventory Manager";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_showItems;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.TextBox txtb_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtb_origin;
        private System.Windows.Forms.TextBox txtb_price;
        private System.Windows.Forms.TextBox txtb_stock;
        private System.Windows.Forms.TextBox txtb_id;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label lbl_stock;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.Label lbl_origin;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.TextBox txtb_remove;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_restock;
        private System.Windows.Forms.TextBox txtb_stockId;
        private System.Windows.Forms.TextBox txtb_restock;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txtb_searchName;
        private System.Windows.Forms.TextBox txtb_searchOrigin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}

