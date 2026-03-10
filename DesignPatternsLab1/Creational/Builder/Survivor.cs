namespace DesignPatternsLab1.Creational.Builder
{
    public class Survivor
    {
        public string Name { get; }
        public string Weapon { get; }
        public string Clothing { get; }
        public bool HasBackpack { get; }

        private Survivor(Builder builder)
        {
            Name = builder.Name;
            Weapon = builder.Weapon;
            Clothing = builder.Clothing;
            HasBackpack = builder.HasBackpack;
        }

        public override string ToString() =>
            $"Survivor: {Name}, Clothes: {Clothing}, Weapon: {Weapon}, Backpack: {(HasBackpack ? "Yes" : "No")}";

        public class Builder
        {
            public string Name { get; private set; }
            public string Weapon { get; private set; } = "Knife";
            public string Clothing { get; private set; } = "Plain shirt";
            public bool HasBackpack { get; private set; } = false;

            public Builder(string name)
            {
                Name = name;
            }

            public Builder WithWeapon(string weapon)
            {
                Weapon = weapon;
                return this; 
            }

            public Builder WithClothing(string clothing)
            {
                Clothing = clothing;
                return this;
            }

            public Builder AddBackpack()
            {
                HasBackpack = true;
                return this;
            }

            public Survivor Build()
            {
                return new Survivor(this);
            }
        }
    }
}