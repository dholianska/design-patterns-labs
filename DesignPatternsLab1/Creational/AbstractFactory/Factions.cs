namespace DesignPatternsLab1.Creational.AbstractFactory
{
    public class FedraSoldier : ISurvivor { public string GetDescription() => "FEDRA warrior in blue uniform"; }
    public class AssaultRifle : IWeapon { public string GetStats() => "Submachine gun: high damage, low accuracy"; }
    public class MilitaryZone : IBase { public string GetLocation() => "Boston Quarantine Zone"; }

    public class FireflyRebel : ISurvivor { public string GetDescription() => "Firefly rebel with a yellow headband"; }
    public class HuntingRifle : IWeapon { public string GetStats() => "Rifle: high accuracy, slow firing"; }
    public class SecretLab : IBase { public string GetLocation() => "St. Mary's Hospital"; }
}