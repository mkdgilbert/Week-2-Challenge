using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WeeklyChallenges
{
    [TestClass]
    public class Week1
    {
        [TestMethod]
        public void MaryPoppins()
        {
            string song = "Supercalifragilisticexpialidocious";

            foreach (char letter in song)
            {
                Console.WriteLine(letter);

            }
            foreach (char letter in song)
            {
                if (letter == 'i')
                {
                    Console.WriteLine('i');
                }

                else if (letter == 'l')
                {
                    Console.WriteLine('l');
                }
                else
                {
                    Console.WriteLine("You are not an i");
                }

            }
            Console.WriteLine(song.Length);

        }
        [TestMethod]
        public void Surname()
        {
            string first = "Mike";
            string last = "Gilbert";
            int age = 31;

            string[] books = { "sonic", "souleater", "bourne", "hollows", "twilight" };
            string[] movies = { "bourne", "Marvel", "DC" };

            Console.WriteLine(age + 7);
            Console.WriteLine(age - 7);
            Console.WriteLine(age * 7);
            Console.WriteLine(age / 7);
            Console.WriteLine(age % 7);

        }

        [TestMethod]

        public void Dates()
        {

            List <DateTime> date_str = new List<DateTime>();
            DateTime today = DateTime.Today;
            date_str.Add(today);
            date_str.Add(new DateTime(1989, 4, 7));
            date_str.Add(new DateTime(1960, 8, 16));
            date_str.Add(new DateTime(1997, 11, 7));
        }

        [TestMethod]
        public void HoursSlept()
        {
            Console.WriteLine("How many hours of sleep did you get????");
            int sleep = 11;

            if (sleep >= 10)
            {
                Console.WriteLine("Wow that's alot of sleep!");
                sleep = 9;
            }
            else if (sleep > 8 && sleep < 10)
            {
                Console.WriteLine("You should be pretty rested");
                sleep = 6;
            }
            else if (sleep > 4 && sleep < 8)
            {
                Console.WriteLine("Bummer");
            }
            else
            {
                Console.WriteLine("Oh man, get some sleep!");
            }
        }

        [TestMethod]
        public void Daytest()
        {
            string day = "Great";

            switch (day)
            {
                case "Great":
                    Console.WriteLine("So happy for you");
                    break;
                case "Good":
                    Console.WriteLine("Thats good to hear");
                    break;
                case "Okay":
                    Console.WriteLine("Sure it'll get better");
                    break;
                case "bad":
                    Console.WriteLine("That's sad to hear");
                    break;
                default:
                    Console.WriteLine("Really?!");
                    break;
            }
    }
}
