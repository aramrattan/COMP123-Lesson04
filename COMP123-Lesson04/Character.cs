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
        protected string name;
        
        //****************************************Constructor*************************************
        public Character(string name, int health, int smarts, string gender)
        {
            this.health = health;
            this.smarts = smarts;
            this.gender = gender;
            this.name = name;
        }

        //Protected Methods
        protected void showProfile()
        {
            Console.WriteLine("Here are your character's stats:");
            Console.WriteLine("Name: {0}", this.name);
            Console.WriteLine("Health: {0}", this.health);
            Console.WriteLine("Smarts: {0}", this.smarts);
            Console.WriteLine("Gender: {0}", this.gender);
            
        }
    }
}
