using DesignPatternsLab1.Structural.Flyweight;
using System.Collections.Generic;

namespace DesignPatternsLab1.Structural.Flyweight
{
    public class AmmoFactory
    {
        private readonly Dictionary<AmmoType, IAmmo> _ammoCache = new();

        public IAmmo GetAmmo(AmmoType type)
        {
            if (!_ammoCache.ContainsKey(type))
            {
                _ammoCache[type] = type switch
                {
                    AmmoType.Pistol => new PistolAmmo(),
                    _ => new PistolAmmo()
                };
            }
            return _ammoCache[type];
        }
    }
}