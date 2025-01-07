using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace MadLibs
{
    /// <summary>
    /// A class to handle randomizations needed to generate combination of sentences.
    /// </summary>
    public  class Randomizer
    {
        /// <summary>
        /// Generates a random number 
        /// </summary>
        /// <param name="max">The maximum value of the generated number </param>
        /// <returns></returns>
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