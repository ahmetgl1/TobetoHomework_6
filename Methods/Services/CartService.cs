using Methods.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods.Services
{
     class CartService
    {


        public void Add(Product product)
        {

            Console.WriteLine("Product Added ! " +product.Name );

        }


    }
}
