using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace State_Design_Pattern.State
{
    public interface Istate
    {
        void NextStatus();
        void Off();
        void On();
        void Moving();
        void Broken();
         void Park();
    }
}