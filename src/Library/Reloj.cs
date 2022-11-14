using System;
using System.Threading;

namespace Full_GRASP_And_SOLID
{

    public class Reloj :TimerClient
    {
        private Recipe timepo;
        public Reloj(Recipe r)
        {
            this.timepo = r;
            
        }
        public void TimeOut()
        {
            this.timepo.FinishCook();
        }
    }
}