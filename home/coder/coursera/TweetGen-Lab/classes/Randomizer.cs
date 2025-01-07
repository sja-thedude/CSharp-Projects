using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace TweetGen
{
    public  class Randomizer
    {

        public  int GenerateRandomNumber(int max)
        {
            long milliseconds = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
            if (max == 1) return 0;
            var rand = (int)milliseconds % (max-1);
            if (rand <0) rand *= -1;
            System.Threading.Thread.Sleep(345);
            return rand;
          
        }

    

    }
}