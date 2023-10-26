using Illuminati.Core.Models.Card;
using Illuminati.Core.Models.Card.GroupCard;
using MvvmCross.Commands;
using MvvmCross.ViewModels;
using System;
using System.Threading.Tasks;

namespace Illuminati.Core.ViewModels
{
    public class PlayerViewModel : GroupViewModel
    {
        public IMvxCommand DeleteSelectedCardCommand { get; set; }
        public IMvxCommand AddSelectedCardCommand { get; set; }
        public IMvxCommand TurnRightCommand { get; set; }
        public IMvxCommand TurnLeftCommand { get; set; }
        public IMvxCommand OnOffCommand { get; set; }
        public IMvxCommand ButtonOffCommand { get; set; }
        public IMvxCommand ConfirmCommand { get; set; }
        public IMvxCommand CancelCommand { get; set; }

        private string pName;
        public string PName
        {
            get { return pName; }
            set { SetProperty(ref pName, value); }
        }

        public PlayerViewModel(Deck d)
        {
            int length = 15;
            int middle = (int)Math.Round((double)length / 2);

            for (int x = 0; x < length; x++)
            {
                if (x == middle)
                {
                    BoardGrid.Add(d.DrawICard());
                }
                else
                {
                    BoardGrid.Add(new Blank());
                }
            }
            Controlling = false;
            Selection = -1;
            TurnRightCommand = new MvxCommand(RotateRightSelectedCard);
            TurnLeftCommand = new MvxCommand(RotateLeftSelectedCard);
            DeleteSelectedCardCommand = new MvxCommand(DeleteSelectedCard);
            AddSelectedCardCommand = new MvxCommand(RotateLeftSelectedCard);
            //OnOffCommand = new MvxCommand(OnOffTest);
            //ButtonOffCommand = new MvxCommand(ButtonOffTest);
            ConfirmCommand = new MvxCommand(ConfirmClicked);
            CancelCommand = new MvxCommand(CancelClicked);
        }

        public async void TransferMoney(MvxObservableCollection<String> M, int ac)
        {
            M.Add("Select group to transfer money from");
            await Task.Run(() => Test());

            if (Selection == 1)
            {
                Selection = -1;
                int money = BoardGrid[SelectedCardIndex].ReturnRemoveIncome(0);

                M.Add("Select group to transfer money to");
                await Task.Run(() => Test());

                if (Selection == 1)
                {
                    Selection = -1;
                    BoardGrid[SelectedCardIndex].AddIncome(money);
                    ac--;
                }
            }
        }

        public async void MoveGroup(MvxObservableCollection<String> M, int ac)
        {
            M.Add("Select group to move");
            await Task.Run(() => Test());

            if (Selection == 1)
            {
                Selection = -1;
                var temp = BoardGrid[SelectedCardIndex];
                DeleteSelectedCard();

                M.Add("Select where to place group");
                await Task.Run(() => Test());

                if (Selection == 1)
                {
                    Selection = -1;
                    AddSelectCard(temp);
                    ac--;
                }
            }
        }

        public override string ToString()
        {
            return pName;
        }
    }
}
