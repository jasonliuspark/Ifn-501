using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n9199349_assignment2
{
    static class input_arguments
    {
        public static void DoubleInputArguement( string x ,out double p)
        {
            while (double.TryParse(x, out p) == false)
            {
               // Console.WriteLine("plese input the right number");
                 break;
                //continue;
            }
            

        }
        public static void intInputArguement(string x ,out int p)
        {

            while (int.TryParse(x, out p) == false)
            {
               // Console.WriteLine("plese input the right number");
                break;
                //continue;
            }
            p = p - 1;
        }

    }
}
