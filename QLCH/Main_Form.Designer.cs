﻿namespace QLCH
{
    partial class Main_Form
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.khachhang = new System.Windows.Forms.ToolStripMenuItem();
            this.addCusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editCusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listCusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printCusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cĂNHỘToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tHỐNGKÊToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.khachhang,
            this.cĂNHỘToolStripMenuItem,
            this.tHỐNGKÊToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // khachhang
            // 
            this.khachhang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCusToolStripMenuItem,
            this.editCusToolStripMenuItem,
            this.listCusToolStripMenuItem,
            this.printCusToolStripMenuItem});
            this.khachhang.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.khachhang.Name = "khachhang";
            this.khachhang.Size = new System.Drawing.Size(153, 29);
            this.khachhang.Text = "KHÁCH HÀNG";
            // 
            // addCusToolStripMenuItem
            // 
            this.addCusToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCusToolStripMenuItem.Name = "addCusToolStripMenuItem";
            this.addCusToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.addCusToolStripMenuItem.Text = "Thêm";
            this.addCusToolStripMenuItem.Click += new System.EventHandler(this.addCusToolStripMenuItem_Click);
            // 
            // editCusToolStripMenuItem
            // 
            this.editCusToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editCusToolStripMenuItem.Name = "editCusToolStripMenuItem";
            this.editCusToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.editCusToolStripMenuItem.Text = "Xóa / Sửa";
            this.editCusToolStripMenuItem.Click += new System.EventHandler(this.editCusToolStripMenuItem_Click);
            // 
            // listCusToolStripMenuItem
            // 
            this.listCusToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listCusToolStripMenuItem.Name = "listCusToolStripMenuItem";
            this.listCusToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.listCusToolStripMenuItem.Text = "Danh sách";
            this.listCusToolStripMenuItem.Click += new System.EventHandler(this.listCusToolStripMenuItem_Click);
            // 
            // printCusToolStripMenuItem
            // 
            this.printCusToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printCusToolStripMenuItem.Name = "printCusToolStripMenuItem";
            this.printCusToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.printCusToolStripMenuItem.Text = "In";
            this.printCusToolStripMenuItem.Click += new System.EventHandler(this.printCusToolStripMenuItem_Click);
            // 
            // cĂNHỘToolStripMenuItem
            // 
            this.cĂNHỘToolStripMenuItem.Name = "cĂNHỘToolStripMenuItem";
            this.cĂNHỘToolStripMenuItem.Size = new System.Drawing.Size(98, 29);
            this.cĂNHỘToolStripMenuItem.Text = "CĂN HỘ";
            // 
            // tHỐNGKÊToolStripMenuItem
            // 
            this.tHỐNGKÊToolStripMenuItem.Name = "tHỐNGKÊToolStripMenuItem";
            this.tHỐNGKÊToolStripMenuItem.Size = new System.Drawing.Size(120, 29);
            this.tHỐNGKÊToolStripMenuItem.Text = "THỐNG KÊ";
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main_Form";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem khachhang;
        private System.Windows.Forms.ToolStripMenuItem addCusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listCusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cĂNHỘToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tHỐNGKÊToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editCusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printCusToolStripMenuItem;
    }
}