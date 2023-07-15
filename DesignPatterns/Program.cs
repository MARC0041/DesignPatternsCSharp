//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using DotNetDesignPatternDemos.SOLID;

namespace DesignPatterns
{
    public class MyClass
    {
        static void Main()
        {
            DesignPatterns.one.one.hello();// Call hello() from DesignPatterns.one
            string[] input = new string[] { };
            DotNetDesignPatternDemos.SOLID.SRP.Demo.Main_(input);

        }
    }
}
namespace DesignPatterns.one
{
    public class one
    {
        public static void hello()
        {
            accessibleOnlyInsideClass();
        }
        static void accessibleOnlyInsideClass()
        {
            Console.WriteLine("one");
        }
    }
}
namespace DesignPatterns.two
{
    public class two
    {
        public static void hello()
        {
            accessibleOnlyInsideClass();
        }
        static void accessibleOnlyInsideClass()
        {
            Console.WriteLine("two");
        }
    }
}