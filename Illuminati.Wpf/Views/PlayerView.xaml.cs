using MvvmCross.Platforms.Wpf.Presenters.Attributes;
using MvvmCross.Platforms.Wpf.Views;
using MvvmCross.ViewModels;
using Illuminati.Core.ViewModels;
using System;
using System.Windows.Controls;

namespace Illuminati.Wpf.Views
{
    /// <summary>
    /// Interaction logic for PlayerView.xaml
    /// </summary>
    [MvxContentPresentation]
    [MvxViewFor(typeof(PlayerViewModel))]
    public partial class PlayerView : MvxWpfView
    {
        public PlayerView()
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
