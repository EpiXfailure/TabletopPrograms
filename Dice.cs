using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabletopPrograms
{
    public class DiceRoller 
    {
        private double avg = 0;
        private int highval = 0;
        private int total = 0;
        private List<Int32> dicelog = new List<Int32>();
        
        public DiceRoller()
        {
            //DiceRoller will roll dice and log results
        }

        public List<Int32> list_success(int limit)
        {
            //limit is the limit threshold.
            //This function will return a list of values of succesfful dice rolls  
            int dice_thrown = dicelog.Count;
            int success = 0;
            List<Int32> succeses = new List<Int32>();
            foreach(int rollvalue in dicelog)
            {
                if (rollvalue >= limit)
                {
                    succeses.Add(rollvalue);
                    success++;
                }
            }
            return succeses;
        }

        public double average()
        {
            return avg;
        }

        public int highest()
        {
            return highval;
        }
        public int sum()
        {
            return total;
        }

        public void roll_dice(int type, int roll_count)
        {
            Random roll = new Random();
            for (int index = 0; index < roll_count; index++)
            {
                int rolledNum = roll.Next(1,type);
                dicelog.Add(rolledNum);
                //Console.WriteLine("Rolled: " + rolledNum);
            }
            avg = dicelog.Average();
            highval = dicelog.Max();
            total = dicelog.Sum();
        }
    }
}