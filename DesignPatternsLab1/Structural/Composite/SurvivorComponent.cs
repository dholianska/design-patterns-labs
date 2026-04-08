using System;
using System.Collections.Generic;

namespace DesignPatternsLab1.Structural.Composite
{
    public abstract class SurvivorComponent
    {
        protected readonly List<SurvivorComponent> Children = new(); 

        public void Add(SurvivorComponent component) => Children.Add(component); 

        public abstract void ExecuteOrder(string order);
    }
}