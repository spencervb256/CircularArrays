using System;
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
            Demo.delete();
            //Demo.removeFront(); works by itself on a line, the result just doesn't go anywhere.  
            Demo.AddBack("Brian");
            Demo.AddBack("Bonnie");
            Demo.AddBack("Sabine");
            Demo.AddBack("Jamie");
            Demo.AddBack("Wenying");
            Demo.AddBack("Omar");

            Console.WriteLine(Demo.GetFront()); //Should print Richard
            //Demo.RemoveFront(); //***If removing this then GetFront prints nothing
            Console.WriteLine(Demo.GetFront()); //Should print Brian
            Console.ReadLine();
        }
    }
}
