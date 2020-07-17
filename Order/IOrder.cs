using PizzaModel;
using System.Collections.Generic;

namespace Order
{
    public interface IOrder
    {
        void GiveOrder(List<IPizza> pizza);
    }
}