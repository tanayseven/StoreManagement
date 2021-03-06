﻿/*
 *  This project is a simlpe implmentation of store management database
 *  Copyright (C) 2012  Tanay Virkant Prabhu Desai
 *
 *  This program is free software: you can redistribute it and/or modify
 *  it under the terms of the GNU General Public License as published by
 *  the Free Software Foundation, either version 3 of the License, or
 *  (at your option) any later version.
 *
 *  This program is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *  GNU General Public License for more details.
 *
 *   You should have received a copy of the GNU General Public License
 *  along with this program.  If not, see <http://www.gnu.org/licenses/>.
 * 
 */
namespace StoreManagement
{
    partial class Products
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
            this.grp_products = new System.Windows.Forms.GroupBox();
            this.rad_delete = new System.Windows.Forms.RadioButton();
            this.rad_modify = new System.Windows.Forms.RadioButton();
            this.rad_select = new System.Windows.Forms.RadioButton();
            this.rad_add = new System.Windows.Forms.RadioButton();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_ok = new System.Windows.Forms.Button();
            this.cmb_supplier_name = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_retail_cost = new System.Windows.Forms.TextBox();
            this.txt_wholesale_cost = new System.Windows.Forms.TextBox();
            this.cmb_product_category = new System.Windows.Forms.ComboBox();
            this.txt_product_name = new System.Windows.Forms.TextBox();
            this.txt_product_id = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grp_products.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_products
            // 
            this.grp_products.Controls.Add(this.rad_delete);
            this.grp_products.Controls.Add(this.rad_modify);
            this.grp_products.Controls.Add(this.rad_select);
            this.grp_products.Controls.Add(this.rad_add);
            this.grp_products.Controls.Add(this.btn_cancel);
            this.grp_products.Controls.Add(this.btn_ok);
            this.grp_products.Controls.Add(this.cmb_supplier_name);
            this.grp_products.Controls.Add(this.label6);
            this.grp_products.Controls.Add(this.txt_retail_cost);
            this.grp_products.Controls.Add(this.txt_wholesale_cost);
            this.grp_products.Controls.Add(this.cmb_product_category);
            this.grp_products.Controls.Add(this.txt_product_name);
            this.grp_products.Controls.Add(this.txt_product_id);
            this.grp_products.Controls.Add(this.label5);
            this.grp_products.Controls.Add(this.label4);
            this.grp_products.Controls.Add(this.label3);
            this.grp_products.Controls.Add(this.label2);
            this.grp_products.Controls.Add(this.label1);
            this.grp_products.Location = new System.Drawing.Point(12, 12);
            this.grp_products.Name = "grp_products";
            this.grp_products.Size = new System.Drawing.Size(263, 274);
            this.grp_products.TabIndex = 0;
            this.grp_products.TabStop = false;
            this.grp_products.Text = "Products";
            // 
            // rad_delete
            // 
            this.rad_delete.AutoSize = true;
            this.rad_delete.Location = new System.Drawing.Point(17, 249);
            this.rad_delete.Name = "rad_delete";
            this.rad_delete.Size = new System.Drawing.Size(56, 17);
            this.rad_delete.TabIndex = 17;
            this.rad_delete.TabStop = true;
            this.rad_delete.Text = "Delete";
            this.rad_delete.UseVisualStyleBackColor = true;
            this.rad_delete.CheckedChanged += new System.EventHandler(this.rad_delete_CheckedChanged);
            // 
            // rad_modify
            // 
            this.rad_modify.AutoSize = true;
            this.rad_modify.Location = new System.Drawing.Point(17, 226);
            this.rad_modify.Name = "rad_modify";
            this.rad_modify.Size = new System.Drawing.Size(56, 17);
            this.rad_modify.TabIndex = 16;
            this.rad_modify.TabStop = true;
            this.rad_modify.Text = "Modify";
            this.rad_modify.UseVisualStyleBackColor = true;
            this.rad_modify.CheckedChanged += new System.EventHandler(this.rad_modify_CheckedChanged);
            // 
            // rad_select
            // 
            this.rad_select.AutoSize = true;
            this.rad_select.Location = new System.Drawing.Point(17, 203);
            this.rad_select.Name = "rad_select";
            this.rad_select.Size = new System.Drawing.Size(55, 17);
            this.rad_select.TabIndex = 15;
            this.rad_select.TabStop = true;
            this.rad_select.Text = "Select";
            this.rad_select.UseVisualStyleBackColor = true;
            this.rad_select.CheckedChanged += new System.EventHandler(this.rad_select_CheckedChanged);
            // 
            // rad_add
            // 
            this.rad_add.AutoSize = true;
            this.rad_add.Location = new System.Drawing.Point(17, 180);
            this.rad_add.Name = "rad_add";
            this.rad_add.Size = new System.Drawing.Size(44, 17);
            this.rad_add.TabIndex = 14;
            this.rad_add.TabStop = true;
            this.rad_add.Text = "Add";
            this.rad_add.UseVisualStyleBackColor = true;
            this.rad_add.CheckedChanged += new System.EventHandler(this.rad_add_CheckedChanged);
            // 
            // btn_cancel
            // 
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Location = new System.Drawing.Point(154, 226);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 13;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(154, 197);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 12;
            this.btn_ok.Text = "Ok";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_accept_Click);
            // 
            // cmb_supplier_name
            // 
            this.cmb_supplier_name.FormattingEnabled = true;
            this.cmb_supplier_name.Location = new System.Drawing.Point(108, 72);
            this.cmb_supplier_name.Name = "cmb_supplier_name";
            this.cmb_supplier_name.Size = new System.Drawing.Size(121, 21);
            this.cmb_supplier_name.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Supplier Name:";
            // 
            // txt_retail_cost
            // 
            this.txt_retail_cost.Location = new System.Drawing.Point(108, 152);
            this.txt_retail_cost.Name = "txt_retail_cost";
            this.txt_retail_cost.Size = new System.Drawing.Size(121, 20);
            this.txt_retail_cost.TabIndex = 9;
            // 
            // txt_wholesale_cost
            // 
            this.txt_wholesale_cost.Location = new System.Drawing.Point(108, 126);
            this.txt_wholesale_cost.Name = "txt_wholesale_cost";
            this.txt_wholesale_cost.Size = new System.Drawing.Size(121, 20);
            this.txt_wholesale_cost.TabIndex = 8;
            // 
            // cmb_product_category
            // 
            this.cmb_product_category.FormattingEnabled = true;
            this.cmb_product_category.Location = new System.Drawing.Point(108, 99);
            this.cmb_product_category.Name = "cmb_product_category";
            this.cmb_product_category.Size = new System.Drawing.Size(121, 21);
            this.cmb_product_category.TabIndex = 7;
            // 
            // txt_product_name
            // 
            this.txt_product_name.Location = new System.Drawing.Point(108, 47);
            this.txt_product_name.Name = "txt_product_name";
            this.txt_product_name.Size = new System.Drawing.Size(121, 20);
            this.txt_product_name.TabIndex = 6;
            // 
            // txt_product_id
            // 
            this.txt_product_id.Location = new System.Drawing.Point(108, 21);
            this.txt_product_id.Name = "txt_product_id";
            this.txt_product_id.ReadOnly = true;
            this.txt_product_id.Size = new System.Drawing.Size(121, 20);
            this.txt_product_id.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Retail Cost:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Wholesale Cost:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Product Category:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Product Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product ID:";
            // 
            // Products
            // 
            this.AcceptButton = this.btn_ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_cancel;
            this.ClientSize = new System.Drawing.Size(287, 298);
            this.Controls.Add(this.grp_products);
            this.MaximumSize = new System.Drawing.Size(303, 336);
            this.MinimumSize = new System.Drawing.Size(303, 336);
            this.Name = "Products";
            this.Text = "Products";
            this.Load += new System.EventHandler(this.Products_Load);
            this.grp_products.ResumeLayout(false);
            this.grp_products.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_products;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.ComboBox cmb_supplier_name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_retail_cost;
        private System.Windows.Forms.TextBox txt_wholesale_cost;
        private System.Windows.Forms.ComboBox cmb_product_category;
        private System.Windows.Forms.TextBox txt_product_name;
        private System.Windows.Forms.TextBox txt_product_id;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rad_delete;
        private System.Windows.Forms.RadioButton rad_modify;
        private System.Windows.Forms.RadioButton rad_select;
        private System.Windows.Forms.RadioButton rad_add;
    }
}