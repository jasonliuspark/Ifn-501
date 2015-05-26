using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace n9199349_assignment2
{
  public class xml
    {  
        string MyXmlfilePath = "c:\\Inventory_output.xml";
        public void xml(int x,string y)
        { 
          XmlDocument myXmlDoc=new XmlDocument();
          XmlElement rootElement = myXmlDoc.CreateElement("Products");
          myXmlDoc.AppendChild(rootElement);
       
          XmlElement [] LevelElement1= new XmlElement();

          //LevelElement1[x].SetAttribute("Products",);
        }
       public  void genXML(int x,int y,string a,string b)
       {
          
     

          
       
       
       }

   
  
  
  }
}
