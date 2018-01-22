using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman_Challenge
{
    public class Program
    {
        public static string Input { get; set; }

        static void Main(string[] args)
        {
            int counter = 0;
            string line;

            System.IO.StreamReader file =
                new System.IO.StreamReader(@"c:\test.txt");
            while ((line = file.ReadLine()) != null)
            {
                System.Console.WriteLine(line);
                counter++;
            }

            file.Close();
            System.Console.WriteLine("There were {0} lines.", counter);
            System.Console.ReadLine();
        }
    }
}

//TODO
//read input
//parse input (remove commmas)
//convert to array
//assign moves to points
//interate over array

//track points(start with 5000)
//track gained lives (start with 0)
//print to console