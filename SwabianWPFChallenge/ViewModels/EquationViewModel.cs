using System.Collections.Generic;
using OxyPlot;
using SwabianWPFChallenge.Commands;
using SwabianWPFChallenge.Models;
using Caliburn.Micro;

namespace SwabianWPFChallenge.ViewModels
{
    public class EquationViewModel : Conductor<object>
    {
        private EquationOperation Operation;
        public EquationViewModel()
        {
            Operation = new EquationOperation();
            linearCommand = new EquationCommand(Linear);
            powerFunctionCommand = new EquationCommand(PowerFunc);
            exponentialCommand = new EquationCommand(Exponential);
        }
        public List<DataPoint> Points { get; private set; }

        #region LoadData and Message
        private string message;
        public string Message
        {
            get { return message; }
            set { message = value; NotifyOfPropertyChange(() => Message);}
        }

        private void LoadData()
        {
            this.Points = Operation.GetPoints();
        }
        #endregion

        #region Coefficients 
        private double a;
        public object A
        {
            get { return a; }
            set {
                //in this cond it's set the A and validate it
                if (!double.TryParse(value.ToString(), out a))
                    Message = "A is not valid";
                else
                    Message = "";
                      
            }
        }

        private double b;
        public object B
        {
            get { return b; }
            set {
                //in this cond it's set the B and validate it
                if (!double.TryParse(value.ToString(), out b))
                    Message = "B is not valid";
                else
                    Message = "";
            }
        }
        #endregion

        #region Linear
        private EquationCommand linearCommand;
        public EquationCommand LinearCommand
        {
            get { return linearCommand; }
        }

        private void Linear()
        {
            OperationFunction(Equation.Linear);
        }
        #endregion

        #region Exponential
        private EquationCommand exponentialCommand;
        public EquationCommand ExponentialCommand
        {
            get { return exponentialCommand; }
        }
        private void Exponential()
        {
            OperationFunction(Equation.Exponential);
        }
        #endregion

        #region Power Function
        private EquationCommand powerFunctionCommand;
        public EquationCommand PowerFunctionCommand
        {
            get { return powerFunctionCommand; }
        }
        private void PowerFunc()
        {
            OperationFunction(Equation.PowerFunction);
        }
        #endregion

        #region Operation liner-exponential-power
        //Common Function for doing the required operation liner-exponential-power
        private void OperationFunction(Equation equation)
        {
            bool isDone = Operation.OperationFunction(equation, (double)A, (double)B);
            string functionName = Operation.FunctionName(equation);
            if (isDone)
            {
                LoadData();
                Message = functionName + " is Done";
                ActivateItem(new GraphViewModel(functionName, this.Points));

            }
            else
                Message = functionName + " is failed";
        }
        #endregion
    }
}
