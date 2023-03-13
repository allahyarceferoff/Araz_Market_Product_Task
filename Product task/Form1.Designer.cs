namespace Product_task
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
            this.NameLbl = new System.Windows.Forms.Label();
            this.Nametxtb = new System.Windows.Forms.TextBox();
            this.Descriptiontxtb = new System.Windows.Forms.TextBox();
            this.DescriptionLbl = new System.Windows.Forms.Label();
            this.PriceLbl = new System.Windows.Forms.Label();
            this.AddBtn = new System.Windows.Forms.Button();
            this.ShowBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.ProductAddLbl = new System.Windows.Forms.Label();
            this.Pricetxtb = new System.Windows.Forms.TextBox();
            this.YellowLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.BackColor = System.Drawing.Color.Lime;
            this.NameLbl.Cursor = System.Windows.Forms.Cursors.Default;
            this.NameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.NameLbl.Location = new System.Drawing.Point(53, 70);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(55, 20);
            this.NameLbl.TabIndex = 0;
            this.NameLbl.Text = "Name";
            // 
            // Nametxtb
            // 
            this.Nametxtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nametxtb.Location = new System.Drawing.Point(18, 93);
            this.Nametxtb.Name = "Nametxtb";
            this.Nametxtb.Size = new System.Drawing.Size(211, 26);
            this.Nametxtb.TabIndex = 1;
            // 
            // Descriptiontxtb
            // 
            this.Descriptiontxtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Descriptiontxtb.Location = new System.Drawing.Point(18, 179);
            this.Descriptiontxtb.Name = "Descriptiontxtb";
            this.Descriptiontxtb.Size = new System.Drawing.Size(211, 26);
            this.Descriptiontxtb.TabIndex = 1;
            // 
            // DescriptionLbl
            // 
            this.DescriptionLbl.AutoSize = true;
            this.DescriptionLbl.BackColor = System.Drawing.Color.YellowGreen;
            this.DescriptionLbl.Font = new System.Drawing.Font("MisterEarl BT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionLbl.Location = new System.Drawing.Point(75, 157);
            this.DescriptionLbl.Name = "DescriptionLbl";
            this.DescriptionLbl.Size = new System.Drawing.Size(58, 19);
            this.DescriptionLbl.TabIndex = 0;
            this.DescriptionLbl.Text = "Description";
            // 
            // PriceLbl
            // 
            this.PriceLbl.AutoSize = true;
            this.PriceLbl.BackColor = System.Drawing.Color.Yellow;
            this.PriceLbl.Font = new System.Drawing.Font("Moderno One", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PriceLbl.Location = new System.Drawing.Point(75, 240);
            this.PriceLbl.Name = "PriceLbl";
            this.PriceLbl.Size = new System.Drawing.Size(46, 20);
            this.PriceLbl.TabIndex = 0;
            this.PriceLbl.Text = "Price";
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.Gold;
            this.AddBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.Location = new System.Drawing.Point(197, 403);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(90, 40);
            this.AddBtn.TabIndex = 3;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // ShowBtn
            // 
            this.ShowBtn.BackColor = System.Drawing.Color.NavajoWhite;
            this.ShowBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ShowBtn.Location = new System.Drawing.Point(251, 372);
            this.ShowBtn.Name = "ShowBtn";
            this.ShowBtn.Size = new System.Drawing.Size(101, 40);
            this.ShowBtn.TabIndex = 4;
            this.ShowBtn.Text = "SHOW";
            this.ShowBtn.UseVisualStyleBackColor = false;
            this.ShowBtn.Click += new System.EventHandler(this.ShowBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.Color.Gold;
            this.UpdateBtn.Font = new System.Drawing.Font("Modernist One", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpdateBtn.Location = new System.Drawing.Point(328, 403);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(90, 40);
            this.UpdateBtn.TabIndex = 5;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // ProductAddLbl
            // 
            this.ProductAddLbl.AutoSize = true;
            this.ProductAddLbl.BackColor = System.Drawing.Color.Transparent;
            this.ProductAddLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductAddLbl.ForeColor = System.Drawing.Color.Lime;
            this.ProductAddLbl.Location = new System.Drawing.Point(171, 309);
            this.ProductAddLbl.Name = "ProductAddLbl";
            this.ProductAddLbl.Size = new System.Drawing.Size(0, 20);
            this.ProductAddLbl.TabIndex = 7;
            // 
            // Pricetxtb
            // 
            this.Pricetxtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pricetxtb.Location = new System.Drawing.Point(12, 263);
            this.Pricetxtb.Name = "Pricetxtb";
            this.Pricetxtb.Size = new System.Drawing.Size(211, 26);
            this.Pricetxtb.TabIndex = 8;
            // 
            // YellowLbl
            // 
            this.YellowLbl.AutoSize = true;
            this.YellowLbl.BackColor = System.Drawing.Color.Chartreuse;
            this.YellowLbl.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YellowLbl.Location = new System.Drawing.Point(191, 24);
            this.YellowLbl.Name = "YellowLbl";
            this.YellowLbl.Size = new System.Drawing.Size(198, 33);
            this.YellowLbl.TabIndex = 9;
            this.YellowLbl.Text = "Araz Market";
            this.YellowLbl.Click += new System.EventHandler(this.YellowLbl_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.BackgroundImage = global::Product_task.Properties.Resources.araz__2_;
            this.ClientSize = new System.Drawing.Size(574, 451);
            this.Controls.Add(this.YellowLbl);
            this.Controls.Add(this.Pricetxtb);
            this.Controls.Add(this.ProductAddLbl);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.ShowBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.Descriptiontxtb);
            this.Controls.Add(this.Nametxtb);
            this.Controls.Add(this.PriceLbl);
            this.Controls.Add(this.DescriptionLbl);
            this.Controls.Add(this.NameLbl);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.TextBox Nametxtb;
        private System.Windows.Forms.TextBox Descriptiontxtb;
        private System.Windows.Forms.Label DescriptionLbl;
        private System.Windows.Forms.Label PriceLbl;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button ShowBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Label ProductAddLbl;
        private System.Windows.Forms.TextBox Pricetxtb;
        private System.Windows.Forms.Label YellowLbl;
    }
}

