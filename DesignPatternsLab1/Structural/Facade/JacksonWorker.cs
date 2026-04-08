using System;

namespace DesignPatternsLab1.Structural.Facade
{
    public abstract class JacksonWorker
    {
        public string Name { get; }

        protected JacksonWorker(string name) => Name = name;

        public void WakeUp() => Console.WriteLine($"{Name} wakes up.");
        public void GoToPost() => Console.WriteLine($"{Name} goes to their duty station.");
        public void GoToSleep() => Console.WriteLine($"{Name} goes to sleep.");

        public abstract void DoWork();
        public void PerformAction(params ActionType[] actions)
        {
            foreach (var action in actions)
            {
                switch (action)
                {
                    case ActionType.WakeUp: WakeUp(); break;
                    case ActionType.GoToPost: GoToPost(); break;
                    case ActionType.Work: DoWork(); break;
                    case ActionType.GoToSleep: GoToSleep(); break;
                }
            }
        }
    }
    public enum ActionType { WakeUp, GoToPost, Work, GoToSleep }
}