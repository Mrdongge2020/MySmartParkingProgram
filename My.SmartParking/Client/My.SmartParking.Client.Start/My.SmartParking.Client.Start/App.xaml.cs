using My.SmartParking.Client.Start.Views;
using Prism.Ioc;
using Prism.Unity;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Windows;

namespace My.SmartParking.Client.Start
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void InitializeShell(Window shell)
        {
            if (Container.Resolve<LoginView>().ShowDialog() == false)
            {
                Application.Current?.Shutdown() ;
            }
            else 
            {
                base.InitializeShell(shell);
            }
           
        }
        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
           //containerRegistry.Register(typeof(MainWindow));
        }
    }

}
