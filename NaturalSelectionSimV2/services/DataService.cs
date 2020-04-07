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

        //
        // Init a board object to be a Width by Height 2D array.
        //
        public static void InitBoard()
        {
            Board = new Space[Width,Height];
        }

        //
        // Randomly populate spaces with creatures.
        //
        public static void PopulateSpace(Creature child)
        {

        }

        //
        // Find a list of adjacent spaces to interact with.
        //
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

        //
        // When a creature dies or moves, a space space is set to be "empty".
        //
        public static void MakeSpaceEmpty(int xpos, int ypos)
        {
            Board[xpos, ypos].HasCreature = false;
            Board[xpos, ypos].CurrentCreature = null;
        }
    }
}
