using DesignPatternsLab1.Structural.Bridge;

namespace DesignPatternsLab1.Structural.Bridge
{
    public interface IWeapon
    {
        void Prepare();
        void Strike();
        void Sheathe();
        IUpgrade GetUpgrade();
    }
}