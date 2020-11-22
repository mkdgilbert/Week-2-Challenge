using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Week2_Challenge
{
    [TestClass]
    public class Week2
    {
        [TestMethod]
        public void TestMethod1()
        {
            /*Console.WriteLine("What is your name");
            string personName = Console.ReadLine();*/

            Greeter testGreeting = new Greeter();
            testGreeting.HelloGreeting("Michael");

            testGreeting.Farewell("Michael");

            testGreeting.TimeOfDay(4);
            
        }
    }
}
