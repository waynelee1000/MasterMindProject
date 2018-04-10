using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterMindProject
{
    class RNGClass
    {
        int rngNumbner = 0;

        Random rng = new Random();

        public int rngColor(int min, int max)
        {
            rngNumbner = rng.Next(min, max + 1);
            return rngNumbner;
        }
    }
}
