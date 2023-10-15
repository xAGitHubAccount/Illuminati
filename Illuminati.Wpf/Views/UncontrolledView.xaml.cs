using Illuminati.Core.ViewModels;
using MvvmCross.Platforms.Wpf.Presenters.Attributes;
using MvvmCross.Platforms.Wpf.Views;
using MvvmCross.ViewModels;

namespace Illuminati.Wpf.Views
{
    /// <summary>
    /// Interaction logic for UncontrolledView.xaml
    /// </summary>
    [MvxContentPresentation]
    [MvxViewFor(typeof(UncontrolledViewModel))]
    public partial class UncontrolledView : MvxWpfView
    {
        public UncontrolledView()
        {
            InitializeComponent();
        }
    }
}
