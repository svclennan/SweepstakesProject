using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    static class UserInterface<T>
    {
        public static string GetUserInputFor(string prompt)
        {
            Console.WriteLine(prompt);
            return Console.ReadLine();
        }
        public static void Print(T message)
        {
            Console.WriteLine(message);
        }
    }
}
