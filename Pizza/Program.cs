using System;
using System.Collections.Generic;
using PizzaModel;
using Order;
namespace Pizza
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IPizza> orders = new List<IPizza>();
            orders.Add(new Amerikan(Size.XL, null));
            orders.Add(new Newyork(Size.XXL, null));
            orders.Add(new Newyork(Size.small, null));

            //Order.IOrder _or = new Order.Order();
            //--------------------FARKI NEDIR------------------------------------------
            Order.Order _or = new Order.Order();
            _or.GiveOrder(orders);


        }
    }
}
