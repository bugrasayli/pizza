using System;
using System.Collections.Generic;

namespace PizzaModel
{
    public interface IPizza
    {
        Size size { get; set; }
        List<Material> Materials{ get; set; }
        List<Material> materialsinPizza();
        List<Material> Extra{ get; set; }
        void AddExtraMaterial(List<Material> materials);
        
    }
}
