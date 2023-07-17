//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using DotNetDesignPatternDemos.SOLID.SRP;
using namespace1.sub1.sub2;

namespace DesignPatterns
{
    public class MyClass
    {
        static void Main()
        {
            string[] input = new string[] { };
            //DotNetDesignPatternDemos.SOLID.SRP.Demo.Main_(input);
            //DotNetDesignPatternDemos.SOLID.OCP.Demo.Main_(input);
            //DotNetDesignPatternDemos.SOLID.LiskovSubstitutionPrinciple.Demo.Main_(input);

        }
        public static void notes()
        {
            // note 1: to call methods from other classes, the method's access modifier needs to be public or equivalent
            DesignPatterns.one.one.hello();// Call hello() from DesignPatterns.one

            // note 2: if using namespace1.sub1 only, calling sub2.EmptyClass does not allow the reference to be called..
            EmptyClass ec = new EmptyClass();

            // note 3: always remember to add a "new" keyword for ctors that are not the default strings, floats etc. 
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