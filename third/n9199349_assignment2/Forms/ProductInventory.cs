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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 0; i < CataInitial.NumberOfCatalogue; i++)
            {
                listBox1.Items.Add(CataInitial.catalogues[i].catalogueName);

            }

            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            if (listBox1.SelectedIndex!= -1)
            {
                for (int i = 0; i < CataInitial.catalogues[listBox1.SelectedIndex].numberOfProducts; i++)
                {
                    listBox2.Items.Add
                        (
                         productdetails_transfer.transfer
                        (
                        i + 1,
                        CataInitial.catalogues[listBox1.SelectedIndex].products[i].ProductName,
                        CataInitial.catalogues[listBox1.SelectedIndex].products[i].RetailPrice
                        )
                        );
                    //CataInitial.catalogues[listBox1.SelectedIndex].products[i].RetailPrice);


                }
            }

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
