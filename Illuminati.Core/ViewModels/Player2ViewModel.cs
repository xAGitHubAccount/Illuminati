using MvvmCross.ViewModels;

namespace Illuminati.Core.ViewModels
{
    public class Player2ViewModel : GroupViewModel
    {
        private string firstName;
        public string FirstName
        {
            get { return firstName; }
            set { SetProperty(ref firstName, value); }
        }

        private string p2Name = "Player2";
        public string P2Name
        {
            get { return p2Name; }
            set { SetProperty(ref p2Name, value); }
        }

        public override string ToString()
        {
            return p2Name;
        }
    }
}
