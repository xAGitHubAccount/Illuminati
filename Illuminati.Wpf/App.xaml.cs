using Microsoft.Extensions.Logging;
using MvvmCross.Core;
using MvvmCross.Platforms.Wpf.Core;
using MvvmCross.Platforms.Wpf.Views;
using Serilog;
using Serilog.Extensions.Logging;

namespace Illuminati.Wpf
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : MvxApplication
    {
        protected override void RegisterSetup()
      {
            this.RegisterSetupType<Setup>();
        }
    }
}
