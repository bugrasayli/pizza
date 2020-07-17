using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaModel
{
    public class Amerikan : IPizza
    {
        public Size size { get ; set; }
        public List<Material> Materials { get ; set ; }
        public List<Material> Extra { get ; set ; }

        public Amerikan(Size size,List<Material> ExtraMaterials)
        {
            this.size = size;
            this.Extra = ExtraMaterials;
            Materials = materialsinPizza();
            AddExtraMaterial(Extra);
        }

        public List<Material> materialsinPizza()
        {
            Materials = new List<Material>();
            Materials.Add(Material.bbq);
            Materials.Add(Material.onion);
            Materials.Add(Material.ketchup);
            Materials.Add(Material.tomatoes);
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
    }
}
