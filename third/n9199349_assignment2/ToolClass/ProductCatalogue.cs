﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n9199349_assignment2
{
    public class ProductCatalogue
    {
        const int MAX_NUM_PRODUCTS = 100;
       public string catalogueName;
       // public ProductData[] products = new ProductData[MAX_NUM_PRODUCTS];
       public List<ProductData> products = new List<ProductData>();
        public int numberOfProducts;


        public ProductCatalogue(string x)
        {
            numberOfProducts = 0;
          
            //x =
            catalogueName=x;


        }

        public void PrintCatalogue( )
        {

            Console.WriteLine("{0}", catalogueName);
            Console.WriteLine("--------------");
            int i = 0;
            while (i < numberOfProducts)
            {
                Console.Write("{0}. ", i + 1);
                products[i].printProduct();
                i++;
            }
            Console.WriteLine("--------------");

        }
        public void InsertProduct(string a,double b)
        {
            
            ProductData product = new ProductData(a,b);
            products.Add(product);
            // products[numberOfProducts].printProduct();s
            numberOfProducts++;
        }


    }
}
