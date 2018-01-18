using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman_Challenge
{
    public class Program
    {
        private string input = @"Dot,Dot,Dot,Dot,Dot,Dot,Dot,Dot,Dot,Dot,Dot";

        //needs static void Main(string[] args) since this is a console app

        public Program(string input)
        {
            this.input = input;
        }
        
        public int SolvePoints()
        {
            var points = 5000;

            var replaceInput = input.Replace("Dot","10");

            var inputClean = replaceInput.Split(',');

            foreach (var moves in inputClean)
            {
                var movePoint = moves.Select(move => Convert.ToInt32(move)).ToArray();

                var sum = movePoint.Sum();

                points += sum;
            }

            return points;

        }

        //public int SolveLives()
        //{
            //var livesGained = 0;

            //return livesGained;

        //}
        
    }
    //Console.WriteLine($"Total points: {points}, Lives gained: {livesGained}");
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

