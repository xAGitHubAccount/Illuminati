using MvvmCross.Commands;

namespace Illuminati.Core.ViewModels
{
    public class UncontrolledViewModel : GroupViewModel
    {
        //public MvxObservableCollection<Card> _boardGrid = new MvxObservableCollection<Card>();
        //public MvxObservableCollection<Card> BoardGrid
        //{
        //    get => _boardGrid;
        //    set => SetProperty(ref _boardGrid, value, () => RaisePropertyChanged(() => BoardGrid));
        //}

        public IMvxCommand ConfirmCommand { get; set; }
        public IMvxCommand CancelCommand { get; set; }

        private string uName = "Uncontrolled Groups";
        public string U1Name
        {
            get { return uName; }
            set { SetProperty(ref uName, value); }
        }

        //private Card selectedcard;
        //public Card SelectedCard
        //{
        //    get { return selectedcard; }
        //    set
        //    {
        //        SetProperty(ref selectedcard, value);
        //    }
        //}

        //private int selectedcardindex;
        //public int SelectedCardIndex
        //{
        //    get { return selectedcardindex; }
        //    set
        //    {
        //        SetProperty(ref selectedcardindex, value);
        //    }
        //}

        public UncontrolledViewModel()
        {
            Selection = -1;
            ConfirmCommand = new MvxCommand(ConfirmClicked);
            CancelCommand = new MvxCommand(CancelClicked);
        }

        public override string ToString()
        {
            return uName;
        }
    }
}
