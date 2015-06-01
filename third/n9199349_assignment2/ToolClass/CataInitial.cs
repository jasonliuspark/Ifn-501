using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;

namespace n9199349_assignment2
{
     static class CataInitial
    {
        const int MAX_NUM_PRODUCTS = 100;
      //  public static ProductCatalogue[] catalogues = new ProductCatalogue[10];
        public static List<ProductCatalogue> catalogues = new List<ProductCatalogue>();
        public static int NumberOfCatalogue = 0;
        public static List<string> xmlretrival = new List<string> { };
         public static int xmlretrivalCount=0;
         public static List<string> retrivalresult = new List<string> { };
    }
}
