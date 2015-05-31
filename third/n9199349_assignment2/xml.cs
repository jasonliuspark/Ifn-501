using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;

namespace n9199349_assignment2
{
  public class xml
    {  
       
        public void xml(int x,string y)
        {
            DirectoryInfo i = new DirectoryInfo(Path.GetFullPath(".."));
            string dir;
            dir = i.Parent.ToString() + "Inventory.xml";
            XmlDocument myXmlDoc = new XmlDocument();
           foreach(object n in CataInitial.catalogues)
           {
           XmlElement rootElement = myXmlDoc.CreateElement("Products");
           myXmlDoc.AppendChild(rootElement);
              
           }
          myXmlDoc.Save(dir);
          //LevelElement1[x].SetAttribute("Products",);
        }
       public  void genXML(int x,int y,string a,string b)
       {
          
     

          
       
       
       }

   
  
  
  }
    
}
