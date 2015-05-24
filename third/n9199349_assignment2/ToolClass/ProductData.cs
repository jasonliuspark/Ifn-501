using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n9199349_assignment2
{
    public class ProductData
    {

        public string ProductName;
        public double RetailPrice;

        public void printProduct()
        {
            Console.WriteLine("{0} retail price is {1}", ProductName, RetailPrice);

        }
        public ProductData(string x, double p)
        {

           // Console.WriteLine("input the productname");
          
            ProductName = x;
           // Console.WriteLine("input the retailprice");
            RetailPrice = p;


        }

       /* public void DoubleInputArguement(out double p)
        {
            while (double.TryParse(Console.ReadLine(), out p) == false)
            {
                Console.WriteLine("plese input the right number");
                // break;
                continue;
            }

        }*/

    }
}
