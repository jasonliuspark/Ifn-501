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
    public partial class AddNewProduct : Form
    {
        public delegate void doaction( int x);
        public doaction refresh;

        
        public AddNewProduct()
        {
            InitializeComponent();
            
        }


        private void AddNewProduct_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < CataInitial.NumberOfCatalogue; i++)
            {
                comboBox1.Items.Add(CataInitial.catalogues[i].catalogueName);
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        public string GetText()
        { 
       return this.textBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double  p;
            try
            {  
                input_arguments.DoubleInputArguement(textBox2.Text, out p);
                CataInitial.catalogues[comboBox1.SelectedIndex].InsertProduct(textBox1.Text, p);
                refresh(comboBox1.SelectedIndex);
                this.Hide();
            }
            catch { }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        } 

    }
}
