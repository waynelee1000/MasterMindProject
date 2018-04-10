using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterMindProject
{
    class GuessAreaClass
    {
        int[] userArray = new int[4];


        
        public void setUserGuess(string guess)
        {
            for (int i = 0; i < 4; i++)
            {
                string crl = guess.Split()[i];
                Global.Color userColor = (Global.Color)Enum.Parse(typeof(Global.Color), crl);
                userArray[i] = (int)userColor;
            }

        }
        public int[] getUserGuess()
        {
            return userArray;
        }
    }
}
