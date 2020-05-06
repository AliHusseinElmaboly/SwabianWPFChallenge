using Caliburn.Micro;
using System.Windows;
using SwabianWPFChallenge.ViewModels;
namespace SwabianWPFChallenge
{
    public class Bootstrapper : BootstrapperBase
    {
        public Bootstrapper()
        {
            Initialize();
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewFor<EquationViewModel>();
        }
    }
}
