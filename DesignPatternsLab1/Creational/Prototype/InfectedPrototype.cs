namespace DesignPatternsLab1.Creational.Prototype
{
    public class ClickerPrototype : IPrototype<ClickerPrototype>
    {
        public string Strain { get; set; }
        public int AggressionLevel { get; set; }

        public ClickerPrototype(string strain, int aggression)
        {
            Strain = strain;
            AggressionLevel = aggression;
        }

        public ClickerPrototype Clone()
        {
            return (ClickerPrototype)this.MemberwiseClone();
        }
        public override bool Equals(object obj)
        {
            if (obj is ClickerPrototype other)
            {
                return this.Strain == other.Strain && this.AggressionLevel == other.AggressionLevel;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return (Strain, AggressionLevel).GetHashCode();
        }

        public override string ToString() =>
            $"Clicker [Strain: {Strain}, Agression: {AggressionLevel}]";
    }
}