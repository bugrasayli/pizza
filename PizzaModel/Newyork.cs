using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaModel
{
    public class Newyork : IPizza
    {
        public Size size { get ; set ; }
        public List<Material> Materials { get ; set ; }
        public List<Material> Extra { get ; set; }

        public List<Material> materialsinPizza()
        {
            Materials = new List<Material>();
            Materials.Add(Material.kebab);
            Materials.Add(Material.ketchup);
            Materials.Add(Material.peperoni);

            return Materials;
        }

        public void AddExtraMaterial(List<Material> materials)
        {
            if(Extra!=null)
            {
                foreach (Material item in Extra)
                {
                    Materials.Add(item);
                }
            }
            
        }

        public Newyork(Size _size, List<Material> ExtraMaterials)
        {
            this.size = _size;
            this.Extra = ExtraMaterials;
            Materials = materialsinPizza();
            AddExtraMaterial(Extra);
        }
    }
}
