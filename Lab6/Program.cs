﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {

            CircularArray<String> Demo;
            int numelemnts = 10;
            Demo = new CircularArray<String>(numelemnts);

            Demo.AddBack("Richard");
            String deleted = Demo.RemoveFront();
            Console.WriteLine("The following was just removed: " + deleted);
            //Demo.removeFront(); works by itself on a line, the result just doesn't go anywhere.  
            Demo.AddBack("Brian");
            Demo.AddBack("Bonnie");
            Demo.AddBack("Sabine");
            Demo.AddBack("Jamie");
            Demo.AddBack("Wenying");
            Demo.AddBack("Omar");

            Console.WriteLine(Demo.GetFront());
            Console.ReadLine();
        }
    }
}