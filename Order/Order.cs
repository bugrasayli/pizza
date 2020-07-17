using System;
using System.Collections.Generic;
using PizzaModel;

namespace Order
{
    public class Order : IOrder
    {
        public void GiveOrder(List<IPizza> pizza)
        {
            foreach (IPizza Order in pizza)
            {
                List<Material> mat = Order.Materials;
                Console.Write($"\n{Order.GetType().ToString().Split('.')[1]}. Materials:");
                foreach (var item in mat)
                {
                    Console.Write($"{item},");
                }
                Console.Write($"Size:{Order.size}");
                
            }
        }
    }
}
