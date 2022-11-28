using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SF2022User00Lib;

namespace SF2022User00LibUnitTest
{
    [TestClass]
    public class UnitTestSF2022
    {
        Calculations calc;

        [TestMethod]
        public void TestMethodIsNotNull()
        {
            calc = new Calculations();
            Assert.IsNotNull(calc);

        }
        [TestMethod]
        public void TestMethodAllIntervals()
        {
            TimeSpan[] interval = new TimeSpan[]{new TimeSpan(10,0,0),
                new TimeSpan(11,0,0),
                new TimeSpan(15,0,0),
                new TimeSpan(15,30,0),
                new TimeSpan(16,50,0) };
            int[] dur = new int[] { 60, 30, 10, 10, 40 };
            calc = new Calculations();
            string[] result = calc.AvailablePeriods(
               interval, dur, new TimeSpan(8, 0, 0),
               new TimeSpan(18, 0, 0), 30);
            string[] expected = new string[] { "08:00 - 08:30", "08:30 - 09:00",
            "09:00 - 09:30", "09:30 - 10:00", "11:30 - 12:00", "12:00 - 12:30",
            "12:30 - 13:00", "13:00 - 13:30", "13:30 - 14:00", "14:00 - 14:30",
            "14:30 - 15:00", "15:40 - 16:10", "16:10 - 16:40","17:30 - 18:00" };
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestMethod3()
        {
            TimeSpan[] interval = new TimeSpan[]{new TimeSpan(10,0,0),
                new TimeSpan(11,0,0),
                new TimeSpan(15,0,0),
                new TimeSpan(15,30,0),
                new TimeSpan(16,50,0) };
            int[] dur = new int[] { 60, 30, 10, 10, 40 };
            calc = new Calculations();
            string[] result = calc.AvailablePeriods(
               interval, dur, new TimeSpan(8, 0, 0),
               new TimeSpan(18, 0, 0), 30);
            string[] expected = new string[] {"08:00-08:30", "08:30-09:00",
            "09:00-09:30", "09:30-10:00","10:00-10:30","10:30-11:00",
            "11:00-11:30","11:30-12:00","12:00-12:30","12:30-13:00",
            "13:00-13:30","13:30-14:00","14:00-14:30","14:30-15:00",
            "15:00-15:30","15:30-16:00","16:00-16:30","16:30-17:00",
            "17:00-17:30","17:30-18:00" };
            CollectionAssert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestMethod4()
        {
        }
        [TestMethod]
        public void TestMethod5()
        {
        }
    }
}
