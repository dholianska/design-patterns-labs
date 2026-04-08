using DesignPatternsLab1.Structural.Flyweight;
using System.Collections.Generic;

namespace DesignPatternsLab1.Structural.Flyweight
{
    public class Backpack
    {
        private readonly List<IAmmo> _items = new();
        private readonly AmmoFactory _factory = new();

        public void AddAmmo(AmmoType type)
        {
            _items.Add(_factory.GetAmmo(type));
        }

        public void ShowInventory()
        {
            for (int i = 0; i < _items.Count; i++)
            {
                _items[i].Display(i + 1); 
            }
        }
    }
}