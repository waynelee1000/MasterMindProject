using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterMindProject
{

    //GameSolution class handles everything that deals with the solution

    class GameSolutionClass
    {
       public  HintClass solutionReporting = new HintClass();
       public GuessAreaClass guessArea = new GuessAreaClass();

        RNGClass rngClass = new RNGClass();

        int[] solutionArray = new int [4];

        public void setSolution()
        {
            for (int i = 0; i< 4; i++)
            {
                solutionArray[i] = rngClass.rngColor((int)Global.Color.Red, (int)Global.Color.Pink);
            }

        }
        public string displaySolution()
        {
            string display = "";
            string[] colorArray = new string[4];
            for (int i = 0; i < 4; i++)
            {
                colorArray[i] = Enum.GetName(typeof(Global.Color), solutionArray[i]);
            }

            for (int i = 0; i < 4; i++)
            {
                display += colorArray[i] + " ";
            }
            return display;
        }

        public void blackPegs()
        {
            int pegs = 0;
            for (int i = 0; i < 4; i++)
            {
                if (solutionArray[i] == guessArea.getUserGuess()[i])
                {
                    pegs++;
                }

            }

             solutionReporting.setBlackPegs( pegs);

        }

        public void whitePegs()
        {
            int[] tempList = guessArea.getUserGuess();
            int pegs = 0;

            for (int i = 0; i < 4; i++)
            {
                if (solutionArray[i] != guessArea.getUserGuess()[i])
                {
                    for (int y = 0; y < 4; y++)
                    {
                        if ((solutionArray[i] == tempList[y]) && (tempList[i] != -2))
                        {
                            for (int z = 0; z < 4; z++)
                            {
                                if (tempList[z] == tempList[i])
                                {
                                    tempList[z] = -2;
                                }
                            }
                            tempList[i] = -1;

                        }


                    }

                }
                else if (solutionArray[i] == guessArea.getUserGuess()[i])
                {
                    for (int d = 0; d < 4; d++)
                    {
                        if (solutionArray[d] == solutionArray[i])
                        {
                            tempList[d] = -2;
                        }


                    }

                }

            }
            for (int p = 0; p < tempList.Length; p++)
            {
                if (tempList[p] == -1)
                {
                    pegs++;
                }
            }

            solutionReporting.setWhitePegs(pegs);

        }
    }
}
