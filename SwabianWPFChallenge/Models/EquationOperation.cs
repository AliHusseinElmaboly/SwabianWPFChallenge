using System;
using System.Collections.Generic;

using OxyPlot;

namespace SwabianWPFChallenge.Models
{
    public enum Equation
    {
        Linear,
        Exponential,
        PowerFunction
    }
    public class EquationOperation
    {
        static double[] xVariables = { 1,2,3,4,5,7};
        public static List<DataPoint> Points { get; private set; }

        public EquationOperation()
        {
            Points = new List<DataPoint>();
            ReadData();
        }

        //this function for UnitTest
        public void SetDefaultData()
        {
            xVariables =new double[]{ 1,2,3,4,5,7};
        }

        #region Load File
        public void ReadData()
        {
            try
            {         
                string[] lines = System.IO.File.ReadAllLines(@"C:\Users\ali.elmadboly\Source\Repos\SwabianWPFChallenge\SwabianWPFChallenge\Models\Data.txt");
                Random random = new Random();
                int index = random.Next(0, lines.Length);

                string[] numbers = lines[index].Split(',');
                xVariables = new double[numbers.Length];
                for(int i = 0; i< numbers.Length; i++)
                {
                    xVariables[i] = Double.Parse(numbers[i]);
                }
              
            }
            catch(Exception e)
            {
                SetDefaultData();
                throw e;
            }
        }

        public List<DataPoint> GetPoints()
        {
            return Points;
        }
        #endregion

        #region Operation
        public bool OperationFunction(Equation op, double a, double b)
        {
            bool isDone = false;
            Points.Clear();
            try
            { 
                foreach(double x in xVariables)
                {
                    double y = CalculateFunction(op, x, a, b);
                    Points.Add(new DataPoint(x,y));
                }
                isDone = true;
            }
            catch (Exception e)
            {
                throw e;
            }
            return isDone;
        }

        private double CalculateFunction(Equation op,double x,double a,double b)
        {
            double y = 0;
            switch (op)
            {
                case Equation.Linear:
                     y = (a * x) + b;
                    break;
                case Equation.Exponential:
                    y = a * Math.Exp(b * x);
                    break;
                case Equation.PowerFunction:
                    y = a * Math.Pow(x, b);
                    break;
                default:
                    y = (a * x) + b;
                    break;
            }
            return y;
        }

        internal string FunctionName(Equation equation)
        {
            switch (equation)
            {
                case Equation.Linear:
                    return "Linear";
                case Equation.Exponential:
                    return "Exponential";
                case Equation.PowerFunction:
                    return "Power Function";
                default: return "Linear";
            }
        }
        #endregion
    }
}
