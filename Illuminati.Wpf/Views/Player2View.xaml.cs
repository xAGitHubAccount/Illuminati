using Illuminati.Core.ViewModels;
using MvvmCross.Platforms.Wpf.Presenters.Attributes;
using MvvmCross.Platforms.Wpf.Views;
using MvvmCross.ViewModels;

namespace Illuminati.Wpf.Views
{
    /// <summary>
    /// Interaction logic for Player2View.xaml
    /// </summary>
    [MvxContentPresentation]
    [MvxViewFor(typeof(Player2ViewModel))]
    public partial class Player2View : MvxWpfView
    {
        public Player2View()
        {
            InitializeComponent();
        }
    }
}
