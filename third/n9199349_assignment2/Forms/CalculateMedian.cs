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
    public partial class CalculateMedian : Form
    {
        public CalculateMedian()
        {
            InitializeComponent();
            CalculateMedian_Load( );

        }


   
        public static void avgcata()
        {
           
        }
      

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {



        }
        private void CalculateMedian_Load()
        {
            for (int i = 0; i < CataInitial.NumberOfCatalogue; i++)
            {
                comboBox1.Items.Add(CataInitial.catalogues[i].catalogueName);
            }
        
        
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int numPro = 0;
            double avg = 0;
            double sum = 0;
            string c;

            for (int n = 0; n < CataInitial.NumberOfCatalogue; n++)
            {
                for (int i = 0; i < CataInitial.catalogues[n].numberOfProducts; i++)
                {
                    sum = sum + CataInitial.catalogues[n].products[i].RetailPrice;

                }
            }
            for (int i = 0; i < CataInitial.NumberOfCatalogue; i++)
            {
                numPro = numPro + CataInitial.catalogues[i].numberOfProducts;
            }
            avg = sum / numPro;
            c = "the median of all products are";
            MessageBox.Show( avg.ToString(),c);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string c;
            //string x = "";
           // int p;
            double avg = 0;
            double sum = 0;
            // Console.WriteLine("please choose which cata you want to calculate");

           // input_arguments.intInputArguement(x, out p);
            for (int i = 0; i < CataInitial.catalogues[comboBox1.SelectedIndex].numberOfProducts; i++)
            {
                sum = sum + CataInitial.catalogues[comboBox1.SelectedIndex].products[i].RetailPrice;
            }
            avg = sum / CataInitial.catalogues[comboBox1.SelectedIndex].numberOfProducts;
            //textBox1.Text = avg.ToString();
            c = "median of cata:" + CataInitial.catalogues[comboBox1.SelectedIndex].catalogueName + "is";
            MessageBox.Show(avg.ToString(),c);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
 
        
    }
}
