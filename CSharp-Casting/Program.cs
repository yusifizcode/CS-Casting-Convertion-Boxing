using System;
using ClassLibrary;
namespace CSharp_Casting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Notebook notebook1 = new Notebook();
            Notebook notebook2 = new Notebook();
            Notebook notebook3 = new Notebook();
            Store.NotebookLimit = 2;
            Store.PhoneLimit = 2;
            notebook1.Name = "ACER";
            notebook2.Name = "MSI";
            notebook3.Name = "LENOVO";
            notebook1.Price = 4000;
            notebook2.Price = 5000;
            notebook3.Price = 6000;
            notebook1.No = 1;
            notebook2.No = 2;
            notebook3.No = 3;
            Phone phone1 = new Phone();
            Phone phone2 = new Phone();
            Phone phone3 = new Phone();
            phone1.Name = "IPHONE";
            phone2.Name = "SAMSUNG";
            phone3.Name = "XIAOMI";
            phone1.Price = 500;
            phone2.Price = 1000;
            phone3.Price = 1500;
            phone1.No = 1;
            phone2.No = 2;
            phone3.No = 3;
            Store store1 = new Store();
            store1.AddProduct(notebook1);
            store1.AddProduct(notebook2);
            store1.AddProduct(notebook3);
            store1.AddProduct(phone1);
            store1.AddProduct(phone2);
            store1.AddProduct(phone3);
            store1.FindByNo(1);
            Console.WriteLine(store1.CalcNotebookAvg());
            Console.WriteLine(store1.CalcPhoneAvg());
            foreach (var item in store1.Products)
            {
                Console.WriteLine(item.Name);
            }

        }
    }
}
