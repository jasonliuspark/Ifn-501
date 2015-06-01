using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n9199349_assignment2
{
   public static class retrival_handle
    {
       static public void handle()
        {
            int i = 0;
        foreach(string str in CataInitial.xmlretrival)
        {
            try
            {
                if (CataInitial.xmlretrival[i] != CataInitial.xmlretrival[i + 1])
                {
                    CataInitial.retrivalresult.Add(CataInitial.xmlretrival[i]);
                    i++;

                }
                else
                {
                    i++;
                }
            }
            catch
            {
               
            }
        }
        
        
        
        }
       static public void cata()
       { 
           foreach(string str in CataInitial.retrivalresult)
           {
               ProductCatalogue catalogue = new ProductCatalogue(str);
               CataInitial.catalogues.Add(catalogue);
               CataInitial.NumberOfCatalogue++;
                     
           }
       
       
       }

    }
}
