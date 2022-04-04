using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Store
    {
        Product[] _products = new Product[0];
        public Product[] Products { get=>_products; }
        public static int NotebookLimit { get; set; }
        public static int PhoneLimit { get; set; }
        Product[] notebooks = new Notebook[0];
        Product[] phones = new Phone[0];
        public void AddProduct(Product product)
        {


            if (product is Notebook)
            {
                Array.Resize(ref notebooks, notebooks.Length+1);
                notebooks[notebooks.Length - 1] = product;
            }
            else if (product is Phone)
            {
                Array.Resize(ref phones, phones.Length + 1);
                phones[phones.Length - 1] = product;
            }
            if ((product is Notebook && notebooks.Length <= NotebookLimit))
            {
                Array.Resize(ref _products, _products.Length + 1);
                _products[_products.Length - 1] = product;
            }
            else if ((product is Phone && phones.Length <= PhoneLimit))
            {
                Array.Resize(ref _products, _products.Length + 1);
                _products[_products.Length - 1] = product;
            }

        }
        public void FindByNo(int no)
        {
            for (int i = 0; i < Products.Length; i++)
            {
                if (Products[i].No==no)
                {
                    Console.WriteLine($"{no} nomreli product -> {Products[i].Name}");
                }
            }
        }
        public double CalcNotebookAvg()
        {
            int count = 0;
            double sum = 0;
            for (int i = 0; i < Products.Length; i++)
            {
                if (Products[i] is Notebook)
                {
                    Notebook notebook = (Notebook)Products[i];
                    count++;
                    sum += notebook.Price;
                }
            }
            return sum / count;
        }
        public double CalcPhoneAvg()
        {
            int count = 0;
            double sum = 0;
            for (int i = 0; i < Products.Length; i++)
            {
                if (Products[i] is Phone)
                {
                    Phone phone = (Phone)Products[i];
                    count++;
                    sum += phone.Price;
                }
            }
            return sum / count;
        }
    }
}
