using Methods.Entities;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            Product asus = new Product();    
            asus.Id = 1;
            asus.Name = "Laptop";
            asus.Description = "Asus Notebook";
            asus.Price = 14500;

            Product hp = new Product();
            hp.Id = 2;
            hp.Name = "Laptop";
            hp.Description = "Hp Notebook";
            hp.Price = 9800;


            Product[] products = new Product[] {asus , hp};



            foreach (Product item in products)
            {
                Console.WriteLine(item.Name +" "+ item.Price);

                Console.WriteLine("----------------");
                
            }




        }
    }
}