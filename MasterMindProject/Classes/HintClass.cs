using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterMindProject
{
    class HintClass
    {
        
        int blackPegs;
        int whitePegs;
        
        public void setBlackPegs(int pegs)
        {
            blackPegs = pegs;
        }

        public void setWhitePegs(int pegs)
        {
            whitePegs = pegs;
        }
       

        public int returnBlackPegs()
        {

            return blackPegs;
        }

        public int returnWhitePegs()
        {
            return whitePegs;
        }
    }
}

