using MvvmCross.Platforms.Wpf.Presenters.Attributes;
using MvvmCross.Platforms.Wpf.Views;
using MvvmCross.ViewModels;
using Illuminati.Core.ViewModels;
using System;
using System.Windows.Controls;

namespace Illuminati.Wpf.Views
{
    /// <summary>
    /// Interaction logic for Player1View.xaml
    /// </summary>
    [MvxContentPresentation]
    [MvxViewFor(typeof(Player1ViewModel))]
    public partial class Player1View : MvxWpfView
    {
        public Player1View()
        {
            InitializeComponent();
        }

        //private void AtC_Click(object sender, EventArgs e)
        //{
        //    Button tButton = (sender as Button);
        //    if (tButton != null && tButton == AttacktoControl)
        //    {
        //        SPlayers.Visibility = System.Windows.Visibility.Collapsed;
        //        Add.Visibility = System.Windows.Visibility.Collapsed;
        //        Delete.Visibility = System.Windows.Visibility.Collapsed;
        //        EndTurn.Visibility = System.Windows.Visibility.Collapsed;
        //        confirm.Visibility = System.Windows.Visibility.Visible;
        //    }
        //}
    }
}
