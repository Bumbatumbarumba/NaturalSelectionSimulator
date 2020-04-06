using NaturalSelectionSimV2.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaturalSelectionSimV2.services
{
    static class DataService
    {
        public static int Width { get; set; }
        public static int Height { get; set; }
        public static int NumberOfSpecies { get; set; }
        public static int NumberOfCreatures { get; set; }
        public static Space[,] Board { get; set; }
        private static Random randomizer = new Random();


        public static void InitBoard()
        {
            Board = new Space[Width,Height];
        }

        public static void PopulateSpace(Creature child)
        {

        }

        public static int[] FindValidAdjacentSpace(Creature funcCaller)
        {
            int[] result = { };

            

            return result;
        }

        //
        // The losing creature becomes an empty space; fight keeps occuring until
        // a clear winner is determined.
        //
        //public static void SettleCombat(Creature a, Creature b)
        //{
        //    Creature res = new Creature();

        //    if (a.Attack() > b.Attack())
        //    {
        //        res = b;
        //    }
        //    else if (a.Attack() < b.Attack())
        //    {
        //        res = a;
        //    }
        //    else
        //    {
        //        SettleCombat(a, b);
        //    }

        //    CreatureDies(res);
        //}

        //
        // Resets a given space to empty.
        //
        public static void CreatureDies(Creature c)
        {
            Board[c.Xpos, c.Ypos] = null;
        }
    }
}
