namespace Product_task
{
    partial class Form2
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
            this.ProductListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ProductListBox
            // 
            this.ProductListBox.BackColor = System.Drawing.Color.ForestGreen;
            this.ProductListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductListBox.FormattingEnabled = true;
            this.ProductListBox.ItemHeight = 20;
            this.ProductListBox.Location = new System.Drawing.Point(12, 106);
            this.ProductListBox.Name = "ProductListBox";
            this.ProductListBox.Size = new System.Drawing.Size(550, 284);
            this.ProductListBox.TabIndex = 0;
            this.ProductListBox.SelectedIndexChanged += new System.EventHandler(this.ProductListBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(550, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "List of products";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 451);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProductListBox);
            this.Name = "Form2";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ProductListBox;
        private System.Windows.Forms.Label label1;
    }
}