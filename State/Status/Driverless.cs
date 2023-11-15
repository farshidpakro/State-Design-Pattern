using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace State_Design_Pattern.State.Status
{
    public class Driverless : Istate
    {
        public void Broken()
        {
            Console.WriteLine("this is the broken state");
        }

        public void Moving()
        {
            Console.WriteLine("this is the moving state");
        }

        public void NextStatus()
        {
            Console.WriteLine("this is the Next state");
        }

        public void Off()
        {
           Console.WriteLine("this is the off state");
        }

        public void On()
        {
            Console.WriteLine("this is the on state");
        }

        public void Park()
        {
            throw new NotImplementedException();
        }
    }
}