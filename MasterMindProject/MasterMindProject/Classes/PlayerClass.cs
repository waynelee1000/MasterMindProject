using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterMindProject
{
    class PlayerClass
    {
        private string player;
        private string Difficulty;
        private double Time;

        public PlayerClass() {

        }
        public void setTime(double time) {
            Time = time ; 
        }
        public void setDifficulty(string difficulty) {
            Difficulty = difficulty;
        }
        
        public void setName(string name)
        {
            player = name;
        }
        public string getDifficulty()
        {
            return Difficulty;
        }
        public double getTime()
        {
            return Time;
        }
        public string getName()
        {
            return player;
        }

    }
}
