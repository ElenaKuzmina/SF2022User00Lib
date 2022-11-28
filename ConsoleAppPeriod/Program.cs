using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SF2022User00Lib;

namespace ConsoleAppPeriod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculations calc = new Calculations();
            TimeSpan[] interval = new TimeSpan[]{new TimeSpan(10,0,0),
                new TimeSpan(11,0,0),
                new TimeSpan(15,0,0),
                new TimeSpan(15,30,0),
                new TimeSpan(16,50,0) };
            int[] dur = new int[] { 60, 30, 10, 10, 40 };
            string[] result = calc.AvailablePeriods(
               interval, dur, new TimeSpan(8,0,0), 
               new TimeSpan(18,0,0), 30);
            foreach(string s in result)
                Console.WriteLine(s);
            Console.ReadLine();
        }
    }
}
