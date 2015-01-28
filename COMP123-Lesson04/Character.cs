using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_Lesson04
{
    //Character super class
    class Character
    {
        //****************************************Protected Properties******************************
        protected int health;
        protected int smarts;
        protected string gender;
        
        //****************************************Constructor*************************************
        public Character(int health, int smarts, string gender)
        {
            this.health = health;
            this.smarts = smarts;
            this.gender = gender;
        }
    }
}
