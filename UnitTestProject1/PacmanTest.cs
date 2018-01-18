using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pacman_Challenge;

namespace Pacman_Challenge.test
{
    [TestClass]
    public class PacmanTest
    {
        [TestMethod]
        public void ShouldReturn5110ForExample()
        {
            var example = @"Dot,Dot,Dot,Dot,Dot,Dot,Dot,Dot,Dot,Dot,Dot";

            var result = new Program(example).SolvePoints();

            Assert.AreEqual(5110, result);
        }
    }
}
