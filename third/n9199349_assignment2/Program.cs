using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace n9199349_assignment2
{







   public class Program
    {

       
        static void Main(string[] args)
        {
            Application.Run(new ProductInventory());
           
        }



       
      
        /*public static void UpadatingExistingProductPrice()
        {
            if (NumberOfCatalogue != 0)
            {
                int y;
                int x;
                string a = "";
                string b = "";

                double p;
                DisplayItems();
                Console.WriteLine("please enter which catalogue of the product, you would like to update:");
                intInputArguement(a, out x);

                Console.WriteLine("plese input the product number you want to change ");
                intInputArguement(b, out y);
                Console.WriteLine("you have selected {0} , the current retail price is {1}.\n please enter a new price:", catalogues[x].products[y].ProductName, catalogues[x].products[y].RetailPrice);
                DoubleInputArguement(a, out p);
                catalogues[x].products[y].RetailPrice = p;
            }
            else 
            { 
                Console.WriteLine("pls add a new catalogue first");
                Console.WriteLine("\n");
            
            
            }

        }

      

        
        public static void Exit()
        {

            Environment.Exit(0);
        }

        public static void Delete()
        {
            string a = "";
            int b;
            DisplayItems();
            Console.WriteLine("please enter the item that you want to delete");
            intInputArguement(a, out b);


        }*/

       


    }
}
