using NaturalSelectionSimV2.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaturalSelectionSimV2.services
{
    class SimulatorEngine
    {
        public static int SimSpeed { get; set; }
        public static SimState CurrentState { get; set; }


        // We shuffle a list of indexes that we wish to visit in order to give an organic
        // simulation; visiting each index linearly (i.e., i++, j++) will give a very
        // structured result, but visiting a shuffled list will allow us to pick a "random"
        // cell to move.
        private static int[] visitX = new int[DataService.Width];
        private static int[] visitY = new int[DataService.Height];
        private static Random randomizer = new Random();

        public static void InitSim()
        {
            DataService.InitBoard();
            PopulateVisitLists();
            ShuffleIndexes();
            CurrentState = SimState.Paused;

        }

        public static void PopulateVisitLists()
        {
            for (int i = 0; i < DataService.Width; i++)
            {
                visitX[i] = i;
            }

            for (int i = 0; i < DataService.Height; i++)
            {
                visitY[i] = i;
            }
        }

        public static void ShuffleIndexes()
        {
            visitX = visitX.OrderBy(x => randomizer.Next()).ToArray();
            visitY = visitY.OrderBy(y => randomizer.Next()).ToArray();
        }

        public static void RunSim()
        {
            // CREATE AN EVENT HANDLER THAT CAN CHANGE THE STATE OF CurrentState AND LINK IT TO A BUTTON
            // HAVE IT BREAK THE LOOP; 
            while (CurrentState == SimState.Running)
            {
                for (int i = 0; i < DataService.Width; i++)
                {
                    for (int j = 0; j < DataService.Height; j++)
                    {
                        if (CurrentState != SimState.Paused)
                        {
                            break; // Have it be restarted by a control on the simulator window by calling RunSim()
                        }
                        else
                        {
                            int x = visitX[i];
                            int y = visitY[j];

                            if (DataService.Board[x,y].HasCreature)
                            {
                                DataService.Board[x, y].CurrentCreature.DoThings();
                            }
                        }
                    }
                }
            }

        }
    }

    public enum SimState
    {
        Paused = 0,
        Running = 1,
        Terminated = 2
    }
}
