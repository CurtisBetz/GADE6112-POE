using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTSGame
{
    class Map
    {
        private string[,] feild = new string[20, 20];
        MeleeUnit[] m = new MeleeUnit[100];
        RangedUnit[] r = new RangedUnit[100];
        Random rnd = new Random();
        private int size;
       

        public void generateFeild()
        {
            size = rnd.Next(25, 51);
            int xPosition = rnd.Next(0, 19);
            int yPosition = rnd.Next(0, 19);
            string faction;

            if(rnd.Next(0,2) % 2 == 0)
            {
                faction = "Red";
            }
            else
            {
                faction = "Blue";
            }

            for (int i = 0; i < size; i++)
            {
                m[i] = new MeleeUnit(xPosition, yPosition, 100, 1, 1, 1, faction, 'M');
                for (int j = 0; j < size; j++)
                {
                    r[j] = new RangedUnit(xPosition, yPosition, 100, 1, 1, 5, faction, 'R');
                }
            }
        }
        
        
        






    }
}
