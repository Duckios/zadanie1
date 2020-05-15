using System;
using static System.Console;
using static System.Convert;
using Library;

namespace zadanie1
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine(lib1.stpow("ha", 4));
            WriteLine(lib1.rev("hello"));
            WriteLine(lib1.remov("aHeallao","a"));
            WriteLine(lib1.leng("Hello, friends!"));
        }
    }
}
