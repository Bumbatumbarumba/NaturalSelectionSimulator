using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaturalSelectionSimV2.classes
{
    class Creature
    {
        public int Xpos { get; set; }
        public int Ypos { get; set; }
        public int Size { get; set; }
        public int LifeSpan { get; set; }
        public int MaturityAge { get; set; }
        public int Age { get; set; }
        public string Colour { get; set; }
        public bool HasMated { get; set; }
        public int LowerAttackBound { get; set; }
        public int UpperAttackBound { get; set; }
        private Random randomizer = new Random();


        public void DoThings()
        {
            /*
             0. increase age
             1. check if neighbours are empty
             1.a if not, check if neighbour is friend
             1.a.a if not, attack
             1.a.b if it is, try to produce offspring
             1.b if it is, try to move
             
             */
        }

        public void Move()
        {

        }


        public void Reproduce()
        {

        }

        public Creature GenerateOffSpring()
        {
            Creature child = new Creature();

            // generate stats

            // set the current location to be a parent's location since it
            // will get changed immediately anyways.
            child.Xpos = Xpos;
            child.Ypos = Ypos;

            return child;
        }

        //
        // Pick a random number between LowerAttackBound and UpperAttackBound (inclusively);
        // the winner is the creature with a higher number.
        //
        public int Attack()
        {
            return 7;
        }
    }
}
