using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Product_task
{
    public partial class Form1 : Form
    {
        List<Product> products = new List<Product>();
        public EventHandler<EventArgs> SelectionHandler { get; set; }
        public EventHandler<EventArgs> UpdateHandler { get; set; }
        public Form1()
        {
            InitializeComponent();
            SelectionHandler = new EventHandler<EventArgs>(SelectItem);
            UpdateHandler = new EventHandler<EventArgs>(UpdateItem);
        }
        private void UpdateItem(object sender, EventArgs e)
        {
            var product = form2.SelectedProduct;
            product.Name = Nametxtb.Text;
            product.Description = Descriptiontxtb.Text;
            product.Price = double.Parse(Pricetxtb.Text);
            form2.SelectedProduct = product;
        }

        private void SelectItem(object sender, EventArgs e)
        {
            var product = form2.SelectedProduct;
            Nametxtb.Text = product.Name;
            Descriptiontxtb.Text = product.Description;
            Pricetxtb.Text = product.Price.ToString();
        }
        private void ClearBoxes()
        {
            Nametxtb.Text = String.Empty;
            Descriptiontxtb.Text = String.Empty;
            Pricetxtb.Text = null;
        }

        Form2 form2 = new Form2();
        private void AddBtn_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.Name = Nametxtb.Text;
            product.Description = Descriptiontxtb.Text;
            product.Price = double.Parse(Pricetxtb.Text);
            products.Add(product);
            ClearBoxes();
            ProductAddLbl.Text = "Product added successfully";
        }
        private void ShowBtn_Click(object sender, EventArgs e)
        {
            form2.List = products;
            form2.SelectionChange = SelectionHandler;
            if (form2.ShowDialog() == DialogResult.Cancel)
            {
                this.Show();
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            var product = form2.SelectedProduct;
            UpdateHandler.Invoke(sender, e);
            ClearBoxes();
            ProductAddLbl.Text = "Product updated successfully";

        }
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle,
                                                                  Color.Yellow,
                                                                  Color.OrangeRed,
                                                                  45F))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }

        private void YellowLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
