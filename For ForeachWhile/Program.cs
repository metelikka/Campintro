using System;

namespace For_ForeachWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.Name = "Mause";
            product1.Price = 2500;

            Product product2 = new Product();
            product2.Id = 2;
            product2.Name = "LCD TV";
            product2.Price = 35;

            Product product3 = new Product();
            product3.Id = 3;
            product3.Name = "Keyboard";
            product3.Price = 300;

            Product[] products = new Product[] { product1, product2, product3 };
            //array 
            
            Console.WriteLine("\n -----------FOR---------- \n");
            //for ile dön
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine(products[i].Id + " : " + products[i].Name + " : " + products[i].Price) ;
            }

            Console.WriteLine("\n -----------FOREACH-----------  \n");

            //foreach ile dön
            foreach (Product product in products)
            {
                Console.WriteLine(product.Id + " : " + product.Name + " : " + product.Price);
            }

            Console.WriteLine("\n ----------WHİLE---------- \n");

            //while ile dön
            int j = 0;
            while (j < products.Length)
            {
                Console.WriteLine(products[j].Id + " : " + products[j].Name + " : " + products[j].Price);
                j++;
            }
        }
    }

    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }
}
        
     

