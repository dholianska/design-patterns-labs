using DesignPatternsLab1.Creational.AbstractFactory;
using DesignPatternsLab1.Creational.Builder;
using DesignPatternsLab1.Creational.Factory;
using DesignPatternsLab1.Creational.FactoryMethod;
using DesignPatternsLab1.Creational.Singleton;
using DesignPatternsLab1.Creational.Prototype;

namespace DesignPatternsLab1.Creational
{
    public static class CreationalRunner
    {
        public static void Run()
        {
            Console.WriteLine("=== CREATIONAL PATTERNS ===");

            Console.WriteLine("\n--- Singleton begin ---");
            RadioStation station = RadioStation.GetInstance();
            Console.WriteLine(station.GetBroadcast());
            RadioStation anotherCheck = RadioStation.GetInstance();
            if (ReferenceEquals(station, anotherCheck))
            {
                Console.WriteLine("[OK] Both survivors hear the same station. Singleton is working.");
            }
            Console.WriteLine("--- Singleton end ---");


            Console.WriteLine("\n--- Simple Factory begin ---");
            var runner = InfectedFactory.CreateInfected(InfectedType.Runner);
            var clicker = InfectedFactory.CreateInfected(InfectedType.Clicker);
            Console.WriteLine($"You hear the sound: {runner.GetWarning()}");
            Console.WriteLine($"You hear the sound: {clicker.GetWarning()}");
            Console.WriteLine("--- Simple Factory end ---");


            Console.WriteLine("\n--- Factory method begin ---");
            InfectedSpawner spawner = new CitySpawner();
            spawner.SpawnEnemy();
            spawner = new SubwaySpawner();
            spawner.SpawnEnemy();
            Console.WriteLine("--- Factory method end ---");


            Console.WriteLine("\n--- Abstract factory begin ---");
            IFactionFactory faction = new FedraFactory();
            var soldier = faction.CreateSurvivor();
            var weapon = faction.CreateWeapon();
            var baseLocation = faction.CreateBase();
            Console.WriteLine($"Character: {soldier.GetDescription()}");
            Console.WriteLine($"Equipment: {weapon.GetStats()}");
            Console.WriteLine($"Location: {baseLocation.GetLocation()}");
            Console.WriteLine("--- Abstract factory end ---");


            Console.WriteLine("\n--- Builder begin ---");
            var character1 = new Survivor.Builder("Joel")
                .WithClothing("Denim Jacket")
                .WithWeapon("Revolver")
                .AddBackpack()
                .Build();
            var character2 = new Survivor.Builder("Ellie")
                .WithWeapon("Switchblade")
                .Build();
            Console.WriteLine(character1);
            Console.WriteLine(character2);
            Console.WriteLine("--- Builder end ---");


            Console.WriteLine("\n--- Prototype begin ---");
            ClickerPrototype patientZero = new ClickerPrototype("Cordyceps-Alpha", 90);
            Console.WriteLine($"Originally infected: {patientZero}");
            ClickerPrototype clickerClone = patientZero.Clone();
            Console.WriteLine($"Cloned infected: {clickerClone}");
            if (!ReferenceEquals(patientZero, clickerClone))
            {
                Console.WriteLine("Objects are not the same! Yeah!");
            }
            if (patientZero.Equals(clickerClone))
            {
                Console.WriteLine("Objects are identical! Yeah!");
            }
            Console.WriteLine("--- Prothotype end ---");
        }
    }
}