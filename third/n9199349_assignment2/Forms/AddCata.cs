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
      

       

    public partial class AddCata : Form
    {
        
           public delegate void DoAction();
           public DoAction FatherRefresh;
        public AddCata()
        {
            InitializeComponent();
            
            
        }
     

        private void label1_Click(object sender, EventArgs e)
        {
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
     

        private void button1_Click(object sender, EventArgs e)
        {
            
            ProductCatalogue catalogue = new ProductCatalogue(textBox1.Text);
            CataInitial.catalogues.Add(catalogue);
            CataInitial.NumberOfCatalogue++;
            FatherRefresh();
            this.Hide();
            

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        } 
    }
}
