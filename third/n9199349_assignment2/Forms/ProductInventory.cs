using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace n9199349_assignment2
{

    public partial class ProductInventory : Form
    {
        
        public ProductInventory()
        {
            InitializeComponent();

      

        }

        public void DataGrid_initial()
        {
            /*
                 DataTable dt = new DataTable();
            DataColumn col1 = new DataColumn("Product name", typeof(string));
            DataColumn col2 = new DataColumn("Retail price", typeof(double));
            dt.Columns.Add(col1);
            dt.Columns.Add(col2);
            this.dataGridView1.DataSource = dt;
            for (int i = 0; i < CataInitial.catalogues[listBox1.SelectedIndex].numberOfProducts; i++)
            {

                dt.Rows.Add("{0}", "{1}", CataInitial.catalogues[listBox1.SelectedIndex].products[i].ProductName, 
                    CataInitial.catalogues[listBox1.SelectedIndex].products[i].RetailPrice);
                
                //CataInitial.catalogues[listBox1.SelectedIndex].products[i].RetailPrice);

            }*/
        
        
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
            if (CataInitial.NumberOfCatalogue != 0)
            {
                for (int i = 0; i < CataInitial.NumberOfCatalogue; i++)
                {
                    listBox1.Items.Add(CataInitial.catalogues[i].catalogueName);

                }
            }

            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            DataTable dt = new DataTable();
            DataColumn col1 = new DataColumn("Product name", typeof(string));
            DataColumn col2 = new DataColumn("Retail price", typeof(double));
            dt.Columns.Add(col1);
            dt.Columns.Add(col2);
            this.dataGridView1.DataSource = dt;

            for (int i = 0; i < CataInitial.catalogues[listBox1.SelectedIndex].numberOfProducts; i++)
            {
                DataRow row = dt.NewRow();
                row["Product name"] = CataInitial.catalogues[listBox1.SelectedIndex].products[i].ProductName;
                row["Retail price"] = CataInitial.catalogues[listBox1.SelectedIndex].products[i].RetailPrice;
               // dt.Rows.Add("{0}", "{1}", CataInitial.catalogues[listBox1.SelectedIndex].products[i].ProductName,
                 //   CataInitial.catalogues[listBox1.SelectedIndex].products[i].RetailPrice);
                dt.Rows.Add(row);
                //CataInitial.catalogues[listBox1.SelectedIndex].products[i].RetailPrice);

            }

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            listBox1.Items.Remove(listBox1.SelectedIndex);
            CataInitial.catalogues.RemoveAt(listBox1.SelectedIndex);
            CataInitial.NumberOfCatalogue--;
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                DataRowView drv = dataGridView1.SelectedRows[0].DataBoundItem as DataRowView;
                drv.Delete();                   
            }
            
            CataInitial.catalogues[listBox1.SelectedIndex].products.RemoveAt(dataGridView1.CurrentRow.Index);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            listBox1.Sorted = true;
            listBox1.Items.Clear();
            if (CataInitial.NumberOfCatalogue != 0)
            {
                for (int i = 0; i < CataInitial.NumberOfCatalogue; i++)
                {
                    listBox1.Items.Add(CataInitial.catalogues[i].catalogueName);

                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }
    }
}
