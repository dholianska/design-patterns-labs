using System;

namespace DesignPatternsLab1.Structural.Bridge
{
    public interface IUpgrade
    {
        void Attach();
        void ExecuteEffect();
        void Detach();
    }
}