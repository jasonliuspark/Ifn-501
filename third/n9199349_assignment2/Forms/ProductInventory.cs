using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace n9199349_assignment2
{

    public partial class ProductInventory : Form
    {
        
        public ProductInventory()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddCata(object sender, EventArgs e)
        {
           AddCata addcata=new AddCata();
           if (addcata.ShowDialog() == DialogResult.OK)
           { this.Show(); }

        }

        private void AddProduct(object sender, EventArgs e)
        {
            AddNewProduct addproduct = new AddNewProduct();
            if (addproduct.ShowDialog() == DialogResult.OK)
            { this.Show(); }
            
        }

        private void CalculateMedian(object sender, EventArgs e)
        {
            CalculateMedian calculatemedian = new CalculateMedian();
            if (calculatemedian.ShowDialog() == DialogResult.OK)
            {
                this.Show();
            
            }
        }
    }
}
