using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace day3program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // animal cow = new animal();
            Cow cow = new Cow();
            cow.WhatIeat();
            cow.WhatIeat("straw");
            cow.WhatIeat("straw", "grass");
            Console.ReadKey();
            //try
            //{
            //    Console.WriteLine("Enter a number");
            //    string givenString = Console.ReadLine();
            //    int myNumber = Convert.ToInt32(givenString);
            //    Console.WriteLine(myNumber);
            //    string[] names = new string[3];
            //    names[0] = "Melina";
            //    names[1] = "Anju";
            //    names[2] = "Mana";
            //    //    names[3] = "Ranju";
            //    foreach (string item in names)
            //    {
            //        Console.WriteLine(item);
            //        Console.ReadKey();
            //    }
            //    //  } catch (Exception ex)
            //    //  {
            //    //     Console.WriteLine(ex.Message);
            //    //  }
            //}
            //catch (InsufficientMemoryException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            ////}
            //catch (InvalidCastException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //Console.ReadKey();
        }
    }
}
