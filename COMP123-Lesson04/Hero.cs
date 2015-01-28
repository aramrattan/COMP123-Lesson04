using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_Lesson04
{
    //hero based of character
    class Hero : Character
    {
        //pRIVATE pROPERTIES*********************************************
        bool bravery = true;
       
        //CONSTRUCTOR
        public Hero(string name, int health, int smarts, string gender) :base(name,health, smarts, gender)
        {
            this.showProfile();

        }

        //PUBLIC METHODS
        public void doesGoodThings()
        {
            Console.WriteLine("Doing good things... YEAH!");
        }
    }
}
