using Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<ProductModel>));
            string path = @"C:\Users\B  A  R  E  V\source\repos\Market\Products.XML";
            List<ProductModel> products = null;
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                products = (List<ProductModel>)serializer.Deserialize(fs);
            }

            foreach (var product in products)
            {
                Console.WriteLine(product.ProductName);
                Console.WriteLine(product.Price+ "\n");
            }

            Console.ReadKey();
        }
    }
}
//class obshi
//{
//    void flan()
//    {
//        string path = @"c:\users\ugeek\desktop\test\product.xml";

//        product product1 = new product(1, "banan", "fruit", 720, 1);
//        product product2 = new product(2, "parmalat", "milk", 960, 1);
//        product product3 = new product(3, "brownie", "cake ", 1200, 1);
//        product product4 = new product(4, "matnaqash", "bread ", 280, 1);
//        product product5 = new product(5, "axe", "desodorante ", 1500, 1);
//        product product6 = new product(6, "aplle", "fruit", 360, 1);
//        product product7 = new product(7, "tide", "washing powder", 850, 1);
//        product product8 = new product(8, "new zerland", "butter", 1800, 1);
//        product product9 = new product(9, "sloboda", "oil", 860, 1);
//        product product10 = new product(10, "roshen", "candy", 450, 1);

//        list<product> products = new list<product> { product1, product2, product3, product4, product5,
//                                                    product6, product7, product8, product9, product10 };



//        xmlserializer sl = new xmlserializer(typeof(list<product>), new xmlrootattribute("vle").namespace = "sdghskldghdkshkgj");

//        using (filestream fs = new filestream(path, filemode.openorcreate))
//        {
//            sl.serialize(fs, products);
//        }
//        list<product> newproducts = null;
//        using (filestream fs = new filestream(path, filemode.openorcreate))
//        {
//            newproducts = (list<product>)sl.deserialize(fs);


//        }
//    }
//}