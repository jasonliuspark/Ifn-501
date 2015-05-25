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

        }


   
        public static void avgcata()
        {
            string x = "";
            int p;
            double avg = 0;
            double sum = 0;
           // Console.WriteLine("please choose which cata you want to calculate");
            
           input_arguments.intInputArguement(x, out p);
            for (int i = 0; i < CataInitial.catalogues[p].numberOfProducts; i++)
            {
                sum = sum + CataInitial.catalogues[p].products[i].RetailPrice;
            }
            avg = sum / CataInitial.catalogues[p].numberOfProducts;
            Console.WriteLine("the avearge for catalogue is {0}", avg);
        }
        public static void avgall()
        {
            int numPro = 0;
            double avg = 0;
            double sum = 0;


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
            Console.WriteLine("the avearge for ALL products is {0}", avg);


        }
 

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
        private void CalculateMedian_Load(object sender, EventArgs e)
        {
            
        }
    }
}
