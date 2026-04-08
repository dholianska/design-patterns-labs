using DesignPatternsLab1.Structural.Adapter;
using DesignPatternsLab1.Structural.Bridge;
using DesignPatternsLab1.Structural.Composite;
using DesignPatternsLab1.Structural.Decorator;
using DesignPatternsLab1.Structural.Facade;
using DesignPatternsLab1.Structural.Flyweight;
using DesignPatternsLab1.Structural.Proxy;
using System;

namespace DesignPatternsLab1.Structural
{
    public class StructuralRunner
    {
        public static void Run()
        {
            Console.WriteLine("---------- Adapter start ----------");
            var quietMotorboat = new MotorboatAdapter();
            var joel = new Survivor(quietMotorboat);
            joel.ScoutArea();
            Console.WriteLine("---------- Adapter end ----------");


            Console.WriteLine();
            Console.WriteLine("----------Bridge start----------");
            Console.WriteLine("Upgrading a Machete at the workbench...");
            var moddedMachete = new Machete(new SawBladeUpgrade());
            moddedMachete.Prepare();
            moddedMachete.Strike();
            moddedMachete.Sheathe();
            Console.WriteLine();
            Console.WriteLine("Reinforcing a Lead Pipe...");
            var heavyPipe = new Machete(new ReinforcedUpgrade());
            heavyPipe.Prepare();
            heavyPipe.Strike();
            heavyPipe.Sheathe();
            Console.WriteLine("----------Bridge end----------");


            Console.WriteLine();
            Console.WriteLine("----------Composite start----------");
            var ellie = new Citizen("Ellie");
            var joel2 = new Citizen("Joel");
            var tommy = new Citizen("Tommy");
            var patrolSquad = new SurvivorGroup("Patrol Squad");
            patrolSquad.Add(ellie);
            patrolSquad.Add(joel2);
            var jacksonCity = new SurvivorGroup("Jackson Settlement");
            jacksonCity.Add(tommy); 
            jacksonCity.Add(patrolSquad);
            jacksonCity.ExecuteOrder("Secure the perimeter");
            Console.WriteLine("----------Composite end----------");


            Console.WriteLine();
            Console.WriteLine("----------Decorator start----------");
            IMeleeWeapon machete = new SimpleMachete();
            machete.Attack();
            Console.WriteLine("Power: " + machete.GetAttackPower());
            Console.WriteLine("--- After upgrading at the workbench ---");
            var upgradedMachete = new ReinforcedMachete(machete);
            upgradedMachete.Attack();
            upgradedMachete.FleeBattle();
            Console.WriteLine("Upgraded Power: " + upgradedMachete.GetAttackPower());
            Console.WriteLine("----------Decorator end----------");


            Console.WriteLine();
            Console.WriteLine("----------Facade start----------");
            var settlement = new JacksonSettlementFacade();
            settlement.StartDay();
            settlement.MaintainSafety();
            settlement.EndDay();
            Console.WriteLine("----------Facade end----------");


            Console.WriteLine();
            Console.WriteLine("----------Flyweight start----------");
            var myBackpack = new Backpack();
            myBackpack.AddAmmo(AmmoType.Pistol);
            myBackpack.AddAmmo(AmmoType.Pistol);
            myBackpack.AddAmmo(AmmoType.Pistol);
            myBackpack.ShowInventory();
            Console.WriteLine("----------Flyweight end----------");


            Console.WriteLine();
            Console.WriteLine("----------Proxy start----------");
            IArmory armory = new ArmoryProxy();
            armory.Enter("Joel"); 
            armory.Enter("Tommy");
            armory.Enter("Ellie");
            armory.Enter("Maria");
            Console.WriteLine("----------Proxy end----------");
        }
    }
}