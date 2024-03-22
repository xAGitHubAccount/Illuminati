using Illuminati.Core.Models.Card;
using Illuminati.Core.Models.Card.GroupCard;
using MvvmCross.ViewModels;
using System;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Illuminati.Core.ViewModels
{
    public class GroupViewModel : MvxViewModel
    {
        private MvxObservableCollection<GroupCard> _boardGrid = new MvxObservableCollection<GroupCard>();
        public MvxObservableCollection<GroupCard> BoardGrid
        {
            get => _boardGrid;
            set => SetProperty(ref _boardGrid, value, () => RaisePropertyChanged(() => BoardGrid));
        }

        public GroupViewModel()
        {
        }

        private Card selectedcard;
        public Card SelectedCard
        {
            get { return selectedcard; }
            set
            {
                selectedcard = value;
                RaisePropertyChanged(() => DisplayCard);
            }
        }

        private int selectedcardindex;
        public int SelectedCardIndex
        {
            get { return selectedcardindex; }
            set
            {
                SetProperty(ref selectedcardindex, value);
            }
        }

        private bool controlling;
        public bool Controlling
        {
            get { return controlling; }
            set
            {
                SetProperty(ref controlling, value);
            }
        }

        private int displayCard;
        public int DisplayCard
        {
            get {
                if (selectedcard == null)
                {
                    return 0;
                }
                else
                {
                    return SelectedCard.Balance;
                }
            }
            set
            {
                SetProperty(ref displayCard, value);
            }
        }

        private int selection;
        public int Selection
        {
            get { return selection; }
            set
            {
                SetProperty(ref selection, value);
            }
        }

        private String conCan;
        public String ConCan
        {
            get
            {
                return conCan;
            }
            set
            {
                SetProperty(ref conCan, value);
            }
        }

        public void ConfirmClicked()
        {
            Selection = 1;
        }

        public void CancelClicked()
        {
            Selection = 0;
        }

        public void Test()
        {
            while (Selection == -1)
            {
                if (Selection == 0)
                {
                    Selection = -1;
                    break;
                }
                if (Selection == 1)
                {
                    break;
                }
            }
        }

        public void OnOffTest()
        {
            for (int x = 0; x < BoardGrid.Count; x++)
            {
                if (BoardGrid[x].OnOff == true)
                {
                    BoardGrid[x].OnOff = false;
                }
                else
                {
                    BoardGrid[x].OnOff = true;
                }
            }
        }

        public void OnOffReverse()
        {
            for (int x = 0; x < BoardGrid.Count; x++)
            {
                if (BoardGrid[x].OnOff == false)
                {
                    BoardGrid[x].OnOff = true;
                }
                else
                {
                    BoardGrid[x].OnOff = false;
                }
            }
        }

        public void OnOffIlluminati()
        {
            for (int x = 0; x < BoardGrid.Count; x++)
            {
                if (BoardGrid[x].cType == CardType.Illuminati)
                {
                    BoardGrid[x].OnOff = false;
                }
            }
        }

        public void OnOffIlluminatiReverse()
        {
            for (int x = 0; x < BoardGrid.Count; x++)
            {
                if (BoardGrid[x].cType == CardType.Illuminati)
                {
                    BoardGrid[x].OnOff = true;
                }
            }
        }

        public void AddSelectCard(GroupCard c)
        {
            BoardGrid[SelectedCardIndex] = c;
        }

        public void DeleteSelectedCard()
        {
            BoardGrid[SelectedCardIndex] = new Blank();
        }

        public GroupCard DeleteSelectReturnCard()
        {
            var temp = BoardGrid[SelectedCardIndex];
            BoardGrid[SelectedCardIndex] = new Blank();
            return temp;
        }

        public void RotateRightSelectedCard()
        {
            var test = new TransformedBitmap(BoardGrid[SelectedCardIndex].ImageSource, new RotateTransform(90));
            BoardGrid[SelectedCardIndex].ImageSource = test;
        }

        public void RotateLeftSelectedCard()
        {
            var test = new TransformedBitmap(BoardGrid[SelectedCardIndex].ImageSource, new RotateTransform(270));
            BoardGrid[SelectedCardIndex].ImageSource = test;
        }

        public void CollectAllIncome()
        {
            for (int x = 0; x < BoardGrid.Count; x++)
            {
                BoardGrid[x].CollectIncome();
            }
        }
    }
}
