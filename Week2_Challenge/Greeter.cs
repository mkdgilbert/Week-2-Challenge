using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_Challenge
{
    public class Greeter
    {
        public void HelloGreeting(string personName)
        {
            Console.WriteLine($"Hello, {personName}");
        }
        public void Farewell(string personName)
        {
            Console.WriteLine($"Nice to meet you.");
        }
        public void TimeOfDay(int time)
        {
            if (time > 6 && time < 12)
            {
                Console.WriteLine("Good Morning");
            }
            else if (time > 12 && time < 14)
            {
                Console.WriteLine("Good Afternoon");
            }
            else if (time > 14 && time < 18)
            {
                Console.WriteLine("Good Evening");
            }
            else
            {
                Console.WriteLine("Good Night");
            }
        }

         
    }
}
