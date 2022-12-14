using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace SF2022User00Lib
{
    public class Calculations
    {
        public string[] AvailablePeriods(
            TimeSpan[] startTimes,
            int[] durations,
            TimeSpan beginWorkingTime,
            TimeSpan endWorkingTime,
            int consultationTime)
        {
            //длительность рабочего дня в часах
            TimeSpan hours = endWorkingTime - beginWorkingTime;
            int ch = 60 / consultationTime; //консультаций в час
            string[] periods = new string[hours.Hours * ch];
            TimeSpan i = beginWorkingTime;
            int j = 0;
            while (i < endWorkingTime)
            { 
                TimeSpan ts = TimeSpan.FromMinutes(consultationTime);

                string period = $"{i.ToString().Substring(0, i.ToString().Length - 3)}-{(i + ts).ToString().Substring(0, (i+ts).ToString().Length - 3)}";
                periods[j] = period;
                j++;
                i = i + ts;
            }
            return periods;
        }
    }
}
