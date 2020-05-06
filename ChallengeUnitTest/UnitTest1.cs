using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SwabianWPFChallenge.Models;
using System.Collections.Generic;
using OxyPlot;

namespace ChallengeUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_LinearMethod()
        {
            EquationOperation Operation = new EquationOperation();
            bool cond = Operation.OperationFunction(Equation.Linear, 1.0, 2.0);
            Assert.AreEqual(cond, true);
        }
        [TestMethod]
        public void Test_ExponentialMethod()
        {
            EquationOperation Operation = new EquationOperation();
            bool cond = Operation.OperationFunction(Equation.Exponential, 1.0, 2.0);
            Assert.AreEqual(cond, true);
        }
        [TestMethod]
        public void Test_PowerMethod()
        {
            EquationOperation Operation = new EquationOperation();
            bool cond = Operation.OperationFunction(Equation.PowerFunction, 1.0, 2.0);
            Assert.AreEqual(cond, true);
        }

        [TestMethod]
        public void Test_LinearMethodData()
        {
            EquationOperation Operation = new EquationOperation();
            Operation.SetDefaultData();
            bool cond = Operation.OperationFunction(Equation.Linear, 1.0, 2.0);
            List<DataPoint> data = Operation.GetPoints();
            Assert.AreEqual(data[0].X, 1);
            Assert.AreEqual(data[0].Y, 3);
            Assert.AreEqual(cond, true);
        }

        public void Test_PowerMethodData()
        {
            EquationOperation Operation = new EquationOperation();
            Operation.SetDefaultData();
            bool cond = Operation.OperationFunction(Equation.Linear, 1.0, 2.0);
            List<DataPoint> data = Operation.GetPoints();
            Assert.AreEqual(data[0].X, 1);
            Assert.AreEqual(data[0].Y, 3);
            Assert.AreEqual(cond, true);
        }
        public void Test_ExponentialMethodData()
        {
            EquationOperation Operation = new EquationOperation();
            Operation.SetDefaultData();
            bool cond = Operation.OperationFunction(Equation.Linear, 0,0);
            List<DataPoint> data = Operation.GetPoints();
            Assert.AreEqual(data[0].X, 1);
            Assert.AreEqual(data[0].Y, 1);
            Assert.AreEqual(cond, true);
        }
    }
}
