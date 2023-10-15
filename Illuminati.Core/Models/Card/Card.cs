using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Illuminati.Core.Models.Card
{
    public abstract class Card : INotifyPropertyChanged
    {
        private BitmapSource _imagesource;
        public BitmapSource ImageSource 
        {
            get { return _imagesource; }
            set 
            {   _imagesource = value;
                OnPropertyChanged();
            }
        }

        public CardType cType;

        private bool onOff;
        public bool OnOff
        {
            get { return onOff; }
            set 
            {
                onOff = value;
                OnPropertyChanged();
            }
        }

        public string Title { get; set; }
        public int Balance { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}