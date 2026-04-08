using DesignPatternsLab1.Structural.Bridge;

namespace DesignPatternsLab1.Structural.Bridge
{
    public class Machete : IWeapon
    {
        private readonly IUpgrade _upgrade;

        public Machete(IUpgrade upgrade) { _upgrade = upgrade; } 

        public void Prepare()
        {
            Console.WriteLine("The survivor draws the machete.");
            _upgrade.Attach();
        }

        public void Strike()
        {
            Console.WriteLine("Machete swing!");
            _upgrade.ExecuteEffect();
        }

        public void Sheathe()
        {
            Console.WriteLine("Putting the machete back.");
            _upgrade.Detach();
        }

        public IUpgrade GetUpgrade() => _upgrade;
    }
}