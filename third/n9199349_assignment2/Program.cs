using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n9199349_assignment2
{







    class Program
    {
        const int MAX_NUM_PRODUCTS = 100;
        static ProductCatalogue[] catalogues = new ProductCatalogue[10];
        public static int NumberOfCatalogue = 0;
        static void Main(string[] args)
        {
            int a = 1;
            // int b;
            string x;
            //   ConsoleKey y;
            do
            {
                Console.WriteLine("please input your option ");
                Console.WriteLine(" 1.Add new product and price.\n 2. Update existing product price.\n 3. Calculate totals.\n 4. CreatNewCata\n 5. Exit");
                // Console.ReadLine();
                x = Console.ReadLine();
                //y= Console.ReadKey().Key;
                Console.WriteLine("\n");
                if (x == "1" || x == "2" || x == "3" || x == "4" || x == "5")
                // if (y == ConsoleKey.D1 || y == ConsoleKey.D2 || y == ConsoleKey.D3 || y == ConsoleKey.D4||y==ConsoleKey.D5 ||y==ConsoleKey.D6)
                {
                    switch (x)
                    {
                        case "1": AddNewProductAndPrice(); break;
                        case "2": UpadatingExistingProductPrice(); break;
                        case "3": CalculateTotals(); break;
                        case "4": CreatNewProcductCatalogue(); break;
                        case "5": Exit(); break;
                        default: break;
                    }
                }
                else
                {
                    Console.WriteLine("you must choose from 1-5\n");
                }
            } while (a == 1);
        }



        public static void CreatNewProcductCatalogue()
        {
            string catalogueName="";

            ProductCatalogue catalogue = new ProductCatalogue(catalogueName);
            //for (int i = 0; i <= NumberOfCatalogue; i++)              
            catalogues[NumberOfCatalogue] = catalogue;
            Console.WriteLine("you have added {0}", catalogue.catalogueName);
            Console.WriteLine("\n");
            NumberOfCatalogue++;
        }
        public static void AddNewProductAndPrice()
        {
            if (NumberOfCatalogue != 0)
            {
                int x;
                string a = "";
                Console.WriteLine("we have catas:");
                displayCatas();
                Console.WriteLine("please choose which catalogue you want to insert");
                intInputArguement(a, out x);
                if (x < NumberOfCatalogue)
                {

                    //Console.WriteLine("you have input the catalogue{0}",catalogue[x].cataname());

                    catalogues[x].InsertProduct();
                    Console.WriteLine("------------------");
                    DisplayItems();
                }
                else
                {
                    Console.WriteLine("you have to insert the right catalogue");

                }
            }
            else
            {
                Console.WriteLine("currently there are no product, pls insert new catalogue");
            }
        }
        public static void displayCatas()
        {
            for (int i = 0; i < NumberOfCatalogue; i++)
            {

                Console.WriteLine("{0}.{1}", i + 1, catalogues[i].catalogueName);
            }
        }
        public static void UpadatingExistingProductPrice()
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

        public static void CalculateTotals()
        {
            Console.WriteLine("please choose which your option\n 1.calculate the average value per catalogue\n 2.calculate the product price across all catalogues");
            switch (Console.ReadLine())
            {
                case "1": avgcata(); break;
                case "2": avgall(); break;
            }
        }
        public static void avgcata()
        {
            string x = "";
            int p;
            double avg = 0;
            double sum = 0;
            Console.WriteLine("please choose which cata you want to calculate");
            displayCatas();
            intInputArguement(x, out p);
            for (int i = 0; i < catalogues[p].numberOfProducts; i++)
            {
                sum = sum + catalogues[p].products[i].RetailPrice;
            }
            avg = sum / catalogues[p].numberOfProducts;
            Console.WriteLine("the avearge for catalogue is {0}", avg);
        }
        public static void avgall()
        {
            int numPro = 0;
            double avg = 0;
            double sum = 0;
            DisplayItems();

            for (int n = 0; n < NumberOfCatalogue; n++)
            {
                for (int i = 0; i < catalogues[n].numberOfProducts; i++)
                {
                    sum = sum + catalogues[n].products[i].RetailPrice;

                }
            }
            for (int i = 0; i < NumberOfCatalogue; i++)
            {
                numPro = numPro + catalogues[i].numberOfProducts;
            }
            avg = sum / numPro;
            Console.WriteLine("the avearge for ALL products is {0}", avg);


        }

        public static void DoubleInputArguement(string x, out double p)
        {
            while (double.TryParse(Console.ReadLine(), out p) == false)
            {
                Console.WriteLine("plese input the right number");
                // break;
                continue;
            }

        }
        public static void intInputArguement(string x, out int p)
        {

            while (int.TryParse(Console.ReadLine(), out p) == false)
            {
                Console.WriteLine("plese input the right number");
                //break;
                continue;
            }
            p = p - 1;
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


        }

        public static void DisplayItems()
        {

            for (int i = 0; i < NumberOfCatalogue; i++)
            {
                Console.Write("{0}> ", i + 1);
                catalogues[i].PrintCatalogue();


            }
        }


    }
}
