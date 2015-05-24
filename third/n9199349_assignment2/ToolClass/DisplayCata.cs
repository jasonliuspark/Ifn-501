using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n9199349_assignment2
{
    class DisplayCata
    {

        public static void displayCatas()
        {
            for (int i = 0; i < CataInitial.NumberOfCatalogue; i++)
            {

                Console.WriteLine("{0}.{1}", i + 1, CataInitial.catalogues[i].catalogueName);
            }
        }
        public static void DisplayItems()
        {

            for (int i = 0; i < CataInitial.NumberOfCatalogue; i++)
            {
                Console.Write("{0}> ", i + 1);
                CataInitial.catalogues[i].PrintCatalogue();


            }
        }
    }
}
