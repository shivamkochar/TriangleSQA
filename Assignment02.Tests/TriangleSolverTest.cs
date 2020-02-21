using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace Assignment02.Tests
{
    [TestFixture]
    public class TriangleSolverTest
    {
        [Test]
        public void CheckEquilateral_Input_10_10_10_Output_Equilateral()
        { 
            String result = TriangleSolver.Analyze(10, 10, 10);
            Assert.AreEqual("It's a equilateral triangle", result);
        }

        [Test]
        public void CheckTriangleValid_Input_0_0_0_Output_TriangleNotValid()
        {
            String result = TriangleSolver.Analyze(0, 0, 0);
            Assert.AreEqual("Triangle not formed", result);
        }

        [Test]
        public void CheckIsoceles_Input_20_10_20_Output_IsocelesTriangle()
        {
            String result = TriangleSolver.Analyze(20, 10, 20);
            Assert.AreEqual("It's a isoceles triangle", result);
        }

        [Test]
        public void CheckScalene_Input_13_14_9_Output_ScaleneTriangle()
        {
            String result = TriangleSolver.Analyze(13, 14, 9);
            Assert.AreEqual("It's a scalene triangle", result);
        }

        [Test]
        public void CheckEquilateral_Input_25_25_25_Output_Equilateral()
        {
            String result = TriangleSolver.Analyze(25, 25, 25);
            Assert.AreEqual("It's a equilateral triangle", result);
        }

        [Test]
        public void CheckIsoceles_Input_30_20_30_Output_IsocelesTriangle()
        {
            String result = TriangleSolver.Analyze(30, 20, 30);
            Assert.AreEqual("It's a isoceles triangle", result);
        }

        [Test]
        public void CheckScalene_Input_2_3_4_Output_ScaleneTriangle()
        {
            String result = TriangleSolver.Analyze(2, 3, 4);
            Assert.AreEqual("It's a scalene triangle", result);
        }

        [Test]
        public void CheckIsoceles_Input_40_10_40_Output_ScaleneTriangle()
        {
            String result = TriangleSolver.Analyze(40, 10, 40);
            Assert.AreEqual("It's a isoceles triangle", result);
        }



    }
}
