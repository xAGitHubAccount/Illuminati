using Illuminati.Core.ViewModels;
using MvvmCross.ViewModels;

namespace Illuminati.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            RegisterAppStart<MainViewModel>();
        }
    }
}
