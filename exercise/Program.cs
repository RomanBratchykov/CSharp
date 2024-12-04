using System;
using System.Runtime.CompilerServices;

namespace Program
{

    public class Program
    {
        static void Main(string[] args)
        {
            int money = 0;
            bool amirich = money > 1000;
            if ( !amirich)
            {
                Console.WriteLine("go to work");
            }
            else
            {
                Console.WriteLine("relax");
            }
        }
    }
