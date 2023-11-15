using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using State_Design_Pattern.State.Status;

namespace State_Design_Pattern.State
{
    public class CarStatusMachin
    {

        private Dictionary<int, Istate> _state;


        // you can inject these dependencies through DI like that:
        // public StateFactory(StartingState startingState, 
        //     MiddleState middleState, FinalState finalState, 
        //     PersistenceService persistenceService)
        public CarStatusMachin()
        {
            _state = new Dictionary<int, Istate>()
        {
            { 1, new Driverless() },
            { 2, new WithPassenger() }

        };
        }

        public void GoToNextStatus(int input)
        {

            _state[input].NextStatus();
        }

        public void OnState(int input)
        {

            _state[1].On();
        }
        public void OffState(int input)
        {

            _state[1].Off();
        }
    }
}