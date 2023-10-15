using Illuminati.Core.ViewModels;
using MvvmCross.Platforms.Wpf.Presenters.Attributes;
using MvvmCross.Platforms.Wpf.Views;
using MvvmCross.ViewModels;
using System;
using System.Windows.Controls;

namespace Illuminati.Wpf.Views
{
    /// <summary>
    /// Interaction logic for MainView.xaml
    /// </summary>
    [MvxContentPresentation]
    [MvxViewFor(typeof(MainViewModel))]
    public partial class MainView : MvxWpfView
    {
        public MainView()
        {
            InitializeComponent();
        }
    }
}
