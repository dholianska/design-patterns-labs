using DesignPatternsLab1.Structural.Facade;
using System.Collections.Generic;

namespace DesignPatternsLab1.Structural.Facade
{
    public class JacksonSettlementFacade
    {
        private readonly List<JacksonWorker> _workers;

        public JacksonSettlementFacade()
        {
            _workers = new List<JacksonWorker>
            {
                new Electrician("Bill"),
                new Guard("Joel"),
                new Guard("Tommy")
            };
        }

        public void StartDay()
        {
            Console.WriteLine("--- Jackson is waking up ---");
            Execute(ActionType.WakeUp, ActionType.GoToPost);
        }

        public void MaintainSafety()
        {
            Console.WriteLine("--- Settlement operations in progress ---");
            Execute(ActionType.Work);
        }

        public void EndDay()
        {
            Console.WriteLine("--- Jackson is going to rest ---");
            Execute(ActionType.GoToSleep);
        }

        private void Execute(params ActionType[] actions)
        {
            foreach (var worker in _workers)
            {
                worker.PerformAction(actions);
            }
        }
    }
}