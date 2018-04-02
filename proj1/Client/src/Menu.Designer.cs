﻿namespace Client
{
    partial class Menu
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
            this.diginotes_label = new System.Windows.Forms.Label();
            this.balance_label = new System.Windows.Forms.Label();
            this.orders_grid = new System.Windows.Forms.DataGridView();
            this.add_button = new System.Windows.Forms.Button();
            this.remove_button = new System.Windows.Forms.Button();
            this.edit_button = new System.Windows.Forms.Button();
            this.diginotes_display = new System.Windows.Forms.TextBox();
            this.balance_display = new System.Windows.Forms.TextBox();
            this.logout_button = new System.Windows.Forms.Button();
            this.funds_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.orders_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // diginotes_label
            // 
            this.diginotes_label.AutoSize = true;
            this.diginotes_label.Location = new System.Drawing.Point(12, 9);
            this.diginotes_label.Name = "diginotes_label";
            this.diginotes_label.Size = new System.Drawing.Size(51, 13);
            this.diginotes_label.TabIndex = 0;
            this.diginotes_label.Text = "Diginotes";
            this.diginotes_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // balance_label
            // 
            this.balance_label.AutoSize = true;
            this.balance_label.Location = new System.Drawing.Point(12, 38);
            this.balance_label.Name = "balance_label";
            this.balance_label.Size = new System.Drawing.Size(46, 13);
            this.balance_label.TabIndex = 1;
            this.balance_label.Text = "Balance";
            this.balance_label.Click += new System.EventHandler(this.label2_Click);
            // 
            // orders_grid
            // 
            this.orders_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orders_grid.Location = new System.Drawing.Point(12, 62);
            this.orders_grid.Name = "orders_grid";
            this.orders_grid.Size = new System.Drawing.Size(306, 306);
            this.orders_grid.TabIndex = 3;
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(12, 374);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(98, 23);
            this.add_button.TabIndex = 4;
            this.add_button.Text = "Add";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // remove_button
            // 
            this.remove_button.Location = new System.Drawing.Point(116, 374);
            this.remove_button.Name = "remove_button";
            this.remove_button.Size = new System.Drawing.Size(98, 23);
            this.remove_button.TabIndex = 5;
            this.remove_button.Text = "Remove";
            this.remove_button.UseVisualStyleBackColor = true;
            this.remove_button.Click += new System.EventHandler(this.remove_button_Click);
            // 
            // edit_button
            // 
            this.edit_button.Location = new System.Drawing.Point(220, 374);
            this.edit_button.Name = "edit_button";
            this.edit_button.Size = new System.Drawing.Size(98, 23);
            this.edit_button.TabIndex = 6;
            this.edit_button.Text = "Edit";
            this.edit_button.UseVisualStyleBackColor = true;
            this.edit_button.Click += new System.EventHandler(this.edit_button_Click);
            // 
            // diginotes_display
            // 
            this.diginotes_display.Location = new System.Drawing.Point(64, 6);
            this.diginotes_display.Name = "diginotes_display";
            this.diginotes_display.ReadOnly = true;
            this.diginotes_display.Size = new System.Drawing.Size(150, 20);
            this.diginotes_display.TabIndex = 7;
            // 
            // balance_display
            // 
            this.balance_display.Location = new System.Drawing.Point(64, 35);
            this.balance_display.Name = "balance_display";
            this.balance_display.ReadOnly = true;
            this.balance_display.Size = new System.Drawing.Size(150, 20);
            this.balance_display.TabIndex = 8;
            // 
            // logout_button
            // 
            this.logout_button.Location = new System.Drawing.Point(220, 4);
            this.logout_button.Name = "logout_button";
            this.logout_button.Size = new System.Drawing.Size(98, 23);
            this.logout_button.TabIndex = 9;
            this.logout_button.Text = "Logout";
            this.logout_button.UseVisualStyleBackColor = true;
            // 
            // funds_button
            // 
            this.funds_button.Location = new System.Drawing.Point(220, 33);
            this.funds_button.Name = "funds_button";
            this.funds_button.Size = new System.Drawing.Size(98, 23);
            this.funds_button.TabIndex = 10;
            this.funds_button.Text = "Funds";
            this.funds_button.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 400);
            this.Controls.Add(this.funds_button);
            this.Controls.Add(this.logout_button);
            this.Controls.Add(this.balance_display);
            this.Controls.Add(this.diginotes_display);
            this.Controls.Add(this.edit_button);
            this.Controls.Add(this.remove_button);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.orders_grid);
            this.Controls.Add(this.balance_label);
            this.Controls.Add(this.diginotes_label);
            this.Name = "Menu";
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.orders_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label diginotes_label;
        private System.Windows.Forms.Label balance_label;
        private System.Windows.Forms.DataGridView orders_grid;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button remove_button;
        private System.Windows.Forms.Button edit_button;
        private System.Windows.Forms.TextBox diginotes_display;
        private System.Windows.Forms.TextBox balance_display;
        private System.Windows.Forms.Button logout_button;
        private System.Windows.Forms.Button funds_button;
    }
}