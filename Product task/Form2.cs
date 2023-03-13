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
    public partial class Form2 : Form
    {
        private List<Product> list;
        public EventHandler<EventArgs> SelectionChange { get; set; }

        public List<Product> List
        {
            get { return list; }
            set { list = value; SetProductListBox(value); }
        }
        public Product SelectedProduct
        {
            get { return ProductListBox.SelectedItem as Product; }
            set { ProductListBox.SelectedItem = value; }
        }

        private void SetProductListBox(List<Product> value)
        {
            ProductListBox.Items.Clear();
            ProductListBox.Items.AddRange(List.ToArray());
        }

        public Form2()
        {
            InitializeComponent();
        }

        private void ProductListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var product = ProductListBox.SelectedItem as Product;
            SelectionChange.Invoke(sender, e);
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

  
    }
}
