using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Summary description for Class1
/// </summary>
public class DiceRoller 
{
	public DiceRoller()
	{
        #DiceRoller will roll dice and log results
        static List<Int32> dicelog = new List<Int32>();
        private double average = 0;
        private int highval = 0;
        private int sum = 0;
        
	}
    public int list_success(int limit)
    {
        #limit is the limit threshold.
        #This function will return a list of values of succesfful dice rolls  
        int sum = 0;
        int dice_thrown = dicelog.Count;
        int success = 0;
        List<Int32> succeses = new List<Int32>
        foreach(int rollvalue in self.dicelog)
        {
            int rollvalue = dicelog.Pop();
            sum += rollvalue;
            if (rollvalue >= limit)
            {
                successes.Add(rollvalue)
                success++;
            }
        }
        return successes;
    }
    public void average()
    {
        self.avg = dicelog.Average();
    }
    public int highest()
    {
        self.high = dicelog.Max();
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
    }
}
