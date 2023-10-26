using Illuminati.Core.Models.Card;
using MvvmCross.Commands;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Illuminati.Core.ViewModels
{
    public class MainViewModel : MvxViewModel
    {
        public Player1ViewModel p1; 
        public Player1ViewModel p2; 
        public UncontrolledViewModel uncontrolled = new UncontrolledViewModel();
        public Deck d = new Deck();
        Random rnd = new Random();

        public IMvxCommand AttacktoControlCommand { get; set; }
        public IMvxCommand DropGroupCommand { get; set; }
        public IMvxCommand EndTurnCommand { get; set; }

        public MvxObservableCollection<String> messages = new MvxObservableCollection<string>();
        public MvxObservableCollection<String> Messages
        {
            get => messages;
            set => SetProperty(ref messages, value, () => RaisePropertyChanged(() => CurrentView));
        }

        public MvxObservableCollection<GroupViewModel> players = new MvxObservableCollection<GroupViewModel>();
        public MvxObservableCollection<GroupViewModel> Players 
        {
            get => players;
            set => SetProperty(ref players, value, () => RaisePropertyChanged(() => CurrentView));
        }

        private string firstName;
        public string FirstName
        {
            get { return firstName; }
            set { SetProperty(ref firstName, value); }
        }

        private MvxViewModel playerView;
        public MvxViewModel PlayerView
        {
            get { return playerView; }
            set { SetProperty(ref playerView, value);
                RaisePropertyChanged(() => CurrentView);
            }
        }

        public MvxViewModel currentView;
        public MvxViewModel CurrentView
        {
            get { return currentView; }
            set { SetProperty(ref currentView, PlayerView);
            }
        }

        private int selectedplayerindex;
        public int SelectedPlayerIndex
        {
            get { return selectedplayerindex; }
            set
            {
                SetProperty(ref selectedplayerindex, value);
            }
        }

        private int actionCount;
        public int ActionCount
        {
            get { return actionCount; }
            set 
            {
                SetProperty(ref actionCount, value);
                RaisePropertyChanged(() => ButtonEnabled);
            }
        }

        private bool buttonEnabled;
        public bool ButtonEnabled
        {
            get 
            {
                if (actionCount == 0)
                {
                    return false;
                }
                return buttonEnabled; 
            }
            set
            {
                SetProperty(ref buttonEnabled, value);
            }
        }

        private String selectionEnabled;
        public String SelectionEnabled
        {
            get { return selectionEnabled; }
            set
            {
                SetProperty(ref selectionEnabled, value, () => RaisePropertyChanged(() => CurrentView));
            }
        }

        public MvxObservableCollection<GroupViewModel> selectionPlayers = new MvxObservableCollection<GroupViewModel>();
        public MvxObservableCollection<GroupViewModel> SelectionPlayers
        {
            get => selectionPlayers;
            set => SetProperty(ref selectionPlayers, value);
        }

        private GroupViewModel selectionplay;
        public GroupViewModel SelectionPlay
        {
            get { return selectionplay; }
            set
            {
                SetProperty(ref selectionplay, value);
            }
        }

        private String sliderEnabled;
        public String SliderEnabled
        {
            get
            {
                return sliderEnabled;
            }
            set
            {
                SetProperty(ref sliderEnabled, value);
            }
        }

        private int slidervalue;
        public int SliderValue
        {
            get { return slidervalue; }
            set
            {
                SetProperty(ref slidervalue, value);
            }
        }

        private int cardvalue;
        public int CardValue
        {
            get { return cardvalue; }
            set
            {
                SetProperty(ref cardvalue, value);
            }
        }

        public void sliderOff()
        {
            SliderEnabled = "Collapsed";
        }

        public void sliderOn()
        {
            SliderEnabled = "Visible";
        }

        public MainViewModel() 
        {
            d.ShuffleDeck();
            d.ShuffleIDeck();
            p1 = new Player1ViewModel(d);
            p2 = new Player1ViewModel(d);
            Players.Add(p1);
            Players.Add(p2);
            SelectedPlayerIndex = rnd.Next(Players.Count);
            PlayerView = Players[SelectedPlayerIndex];
            Players.Add(uncontrolled);
            uncontrolled.BoardGrid.Add(d.DrawCard());
            uncontrolled.BoardGrid.Add(d.DrawCard());
            uncontrolled.BoardGrid.Add(d.DrawCard());
            uncontrolled.BoardGrid.Add(d.DrawCard());
            ButtonEnabled = true;
            SelectionEnabled = "Collapsed";
            SliderEnabled = "Collapsed";
            AttacktoControlCommand = new MvxCommand(AttacktoControl);
            DropGroupCommand = new MvxCommand(DropGroup);
            EndTurnCommand = new MvxCommand(EndTurn);
            StartTurn();
        }

        public void StartTurn()
        {
            ActionCount = 2;
            Players[SelectedPlayerIndex].CollectAllIncome();
            if (d.IsDeckNotEmpty())
            {
                uncontrolled.BoardGrid.Add(d.DrawCard());
            }
        }

        public void ButtonOffTest()
        {
            ActionCount--;
        }

        public void SendMessage(String m)
        {
            Messages.Add(m);
        }

        public async void AttacktoDestroy()
        {
            ButtonEnabled = false;
            SendMessage("Select group to attack with");
            int Ap = SelectedPlayerIndex;
            Players[SelectedPlayerIndex].Selection = -1;
            await Task.Run(() => Players[SelectedPlayerIndex].Test());

            if (Players[SelectedPlayerIndex].Selection == 1)
            {
                var temp2 = Players[SelectedPlayerIndex].BoardGrid[Players[SelectedPlayerIndex].SelectedCardIndex];
                Players[SelectedPlayerIndex].Selection = -1;

                for (int x = 0; x < Players.Count - 2; x++)
                {
                    if (Players[x].Controlling == true)
                    {
                        SelectionPlayers.Add(Players[x]);
                    }
                }

                SelectionEnabled = "Visible";

                SendMessage("Select Player to attack");
                await Task.Run(() => Players[SelectedPlayerIndex].Test());
                if (Players[SelectedPlayerIndex].Selection == 1)
                {
                    Players[SelectedPlayerIndex].Selection = -1;

                    SelectionEnabled = "Collapsed";
                    PlayerView = SelectionPlay;
                    SelectedPlayerIndex = Players.IndexOf(SelectionPlay);

                    SendMessage("Select group to attack");
                    await Task.Run(() => Players[SelectedPlayerIndex].Test());

                    if (Players[SelectedPlayerIndex].Selection == 1)
                    {
                        Players[SelectedPlayerIndex].Selection = -1;

                        var temp = Players[SelectedPlayerIndex].BoardGrid[Players[SelectedPlayerIndex].SelectedCardIndex];

                        CardValue = Players[Ap].DisplayCard;
                        sliderOn();
                        SendMessage("How much money to transfer to Power?");
                        await Task.Run(() => Players[SelectedPlayerIndex].Test());
                        if (Players[SelectedPlayerIndex].Selection == 1)
                        {
                            Players[SelectedPlayerIndex].Selection = -1;
                            sliderOff();
                            int sValue = SliderValue;

                            PlayerView = Players[Ap];
                            SelectedPlayerIndex = Ap;

                            int roll = rnd.Next(13);
                            if (roll == 11 || roll == 12)
                            {
                                SendMessage("Attack unsuccessful");
                                Players[Ap].BoardGrid[Players[SelectedPlayerIndex].SelectedCardIndex].RemoveIncome(sValue);
                                ActionCount--;
                            }
                            else if (temp2.GetPower() + sValue - temp.GetPower() >= roll)
                            {
                                SendMessage("Attack successful");
                                Players[Ap].BoardGrid[Players[SelectedPlayerIndex].SelectedCardIndex].RemoveIncome(sValue);
                                Players[SelectedPlayerIndex].BoardGrid.Remove(temp);
                                //Players[SelectedPlayerIndex].OnOffTest();
                                //SendMessage("Select to place group");
                                //await Task.Run(() => Players[SelectedPlayerIndex].Test());

                                //if (Players[SelectedPlayerIndex].Selection == 1)
                                //{
                                //    Players[SelectedPlayerIndex].Selection = -1;
                                //    Players[SelectedPlayerIndex].AddSelectCard(temp);
                                //    Players[SelectedPlayerIndex].OnOffReverse();
                                //    ActionCount--;
                                //}

                                //else
                                //{
                                //    Players[SelectedPlayerIndex].OnOffReverse();
                                //}
                            }
                            else
                            {
                                SendMessage("Attack unsuccessful");
                            }
                        }
                    }

                }
            }

            SelectionPlayers.Clear();

            if (actionCount != 0)
            {
                ButtonEnabled = true;
            }
        }

        public async void AttacktoNeutralize()
        {
            ButtonEnabled = false;
            SendMessage("Select group to attack with");
            int Ap = SelectedPlayerIndex;
            Players[SelectedPlayerIndex].Selection = -1;
            await Task.Run(() => Players[SelectedPlayerIndex].Test());

            if (Players[SelectedPlayerIndex].Selection == 1)
            {
                var temp2 = Players[SelectedPlayerIndex].BoardGrid[Players[SelectedPlayerIndex].SelectedCardIndex];
                Players[SelectedPlayerIndex].Selection = -1;

                for (int x = 0; x < Players.Count - 2; x++)
                {
                    if (Players[x].Controlling == true)
                    {
                        SelectionPlayers.Add(Players[x]);
                    }
                }

                SelectionEnabled = "Visible";

                SendMessage("Select Player to attack");
                await Task.Run(() => Players[SelectedPlayerIndex].Test());
                if (Players[SelectedPlayerIndex].Selection == 1)
                {
                    Players[SelectedPlayerIndex].Selection = -1;

                    SelectionEnabled = "Collapsed";
                    PlayerView = SelectionPlay;
                    SelectedPlayerIndex = Players.IndexOf(SelectionPlay);

                    SendMessage("Select group to attack");
                    await Task.Run(() => Players[SelectedPlayerIndex].Test());

                    if (Players[SelectedPlayerIndex].Selection == 1)
                    {
                        Players[SelectedPlayerIndex].Selection = -1;

                        var temp = Players[SelectedPlayerIndex].BoardGrid[Players[SelectedPlayerIndex].SelectedCardIndex];

                        CardValue = Players[Ap].DisplayCard;
                        sliderOn();
                        SendMessage("How much money to transfer to Power?");
                        await Task.Run(() => Players[SelectedPlayerIndex].Test());
                        if (Players[SelectedPlayerIndex].Selection == 1)
                        {
                            Players[SelectedPlayerIndex].Selection = -1;
                            sliderOff();
                            int sValue = SliderValue;

                            PlayerView = Players[Ap];
                            SelectedPlayerIndex = Ap;

                            int roll = rnd.Next(13);
                            if (roll == 11 || roll == 12)
                            {
                                SendMessage("Attack unsuccessful");
                                Players[Ap].BoardGrid[Players[SelectedPlayerIndex].SelectedCardIndex].RemoveIncome(sValue);
                                ActionCount--;
                            }
                            else if (temp2.GetPower() + sValue - temp.GetPower() >= roll)
                            {
                                SendMessage("Attack successful");
                                Players[Ap].BoardGrid[Players[SelectedPlayerIndex].SelectedCardIndex].RemoveIncome(sValue);
                                Players[SelectedPlayerIndex].BoardGrid.Remove(temp);
                                uncontrolled.BoardGrid.Add(temp);
                                //Players[SelectedPlayerIndex].OnOffTest();
                                //SendMessage("Select to place group");
                                //await Task.Run(() => Players[SelectedPlayerIndex].Test());

                                //if (Players[SelectedPlayerIndex].Selection == 1)
                                //{
                                //    Players[SelectedPlayerIndex].Selection = -1;
                                //    Players[SelectedPlayerIndex].AddSelectCard(temp);
                                //    Players[SelectedPlayerIndex].OnOffReverse();
                                //    ActionCount--;
                                //}

                                //else
                                //{
                                //    Players[SelectedPlayerIndex].OnOffReverse();
                                //}
                            }
                            else
                            {
                                SendMessage("Attack unsuccessful");
                            }
                        }
                    }

                }
            }

            SelectionPlayers.Clear();

            if (actionCount != 0)
            {
                ButtonEnabled = true;
            }
        }

        public async void AttacktoControl()
        {
            ButtonEnabled = false;
            SendMessage("Select group to attack with");
            int Ap = SelectedPlayerIndex;
            Players[SelectedPlayerIndex].Selection = -1;
            await Task.Run(() => Players[SelectedPlayerIndex].Test());

            if (Players[SelectedPlayerIndex].Selection == 1)
            {
                var temp2 = Players[SelectedPlayerIndex].BoardGrid[Players[SelectedPlayerIndex].SelectedCardIndex];
                Players[SelectedPlayerIndex].Selection = -1;
                
                for (int x = 0; x < Players.Count - 2; x++)
                {
                    if (Players[x].Controlling == true)
                    {
                        SelectionPlayers.Add(Players[x]);
                    }
                }
                SelectionPlayers.Add(uncontrolled);
                SelectionEnabled = "Visible";

                SendMessage("Select Player/Uncontrolled to attack");
                await Task.Run(() => Players[SelectedPlayerIndex].Test());
                if (Players[SelectedPlayerIndex].Selection == 1)
                {
                    Players[SelectedPlayerIndex].Selection = -1;

                    SelectionEnabled = "Collapsed";
                    PlayerView = SelectionPlay;
                    SelectedPlayerIndex = Players.IndexOf(SelectionPlay);

                    SendMessage("Select group to attack");
                    await Task.Run(() => Players[SelectedPlayerIndex].Test());

                    if (Players[SelectedPlayerIndex].Selection == 1)
                    {
                        Players[SelectedPlayerIndex].Selection = -1;

                        var temp = Players[SelectedPlayerIndex].BoardGrid[Players[SelectedPlayerIndex].SelectedCardIndex];

                        CardValue = Players[Ap].DisplayCard;
                        sliderOn();
                        SendMessage("How much money to transfer to Power?");
                        await Task.Run(() => Players[SelectedPlayerIndex].Test());
                        if (Players[SelectedPlayerIndex].Selection == 1)
                        {
                            Players[SelectedPlayerIndex].Selection = -1;
                            sliderOff();
                            int sValue = SliderValue;

                            PlayerView = Players[Ap];
                            SelectedPlayerIndex = Ap;

                            int roll = rnd.Next(13);
                            if (roll == 11 || roll == 12)
                            {
                                SendMessage("Attack unsuccessful");
                                Players[Ap].BoardGrid[Players[SelectedPlayerIndex].SelectedCardIndex].RemoveIncome(sValue);
                                ActionCount--;
                            }
                            else if (temp2.GetPower() + sValue - temp.GetPower() >= roll)
                            {
                                SendMessage("Attack successful");
                                Players[Ap].BoardGrid[Players[SelectedPlayerIndex].SelectedCardIndex].RemoveIncome(sValue);
                                Players[SelectedPlayerIndex].BoardGrid.Remove(temp);
                                Players[SelectedPlayerIndex].OnOffTest();
                                SendMessage("Select to place group");
                                await Task.Run(() => Players[SelectedPlayerIndex].Test());

                                if (Players[SelectedPlayerIndex].Selection == 1)
                                {
                                    Players[SelectedPlayerIndex].Selection = -1;
                                    Players[SelectedPlayerIndex].AddSelectCard(temp);
                                    Players[SelectedPlayerIndex].OnOffReverse();
                                    ActionCount--;
                                }

                                else
                                {
                                    Players[SelectedPlayerIndex].OnOffReverse();
                                }
                            }
                            else
                            {
                                SendMessage("Attack unsuccessful");
                            }
                        }
                    }
                    
                }
            }

            SelectionPlayers.Clear();

            if (actionCount != 0)
            {
                ButtonEnabled = true;
            }
        }

        public async void MoveGroup()
        {
            SendMessage("Select group to move");
            Players[SelectedPlayerIndex].OnOffIlluminati();
            await Task.Run(() => Players[SelectedPlayerIndex].Test());

            if (Players[SelectedPlayerIndex].Selection == 1)
            {
                Players[SelectedPlayerIndex].Selection = -1;

                var temp = Players[SelectedPlayerIndex].BoardGrid[Players[SelectedPlayerIndex].SelectedCardIndex];
                Players[SelectedPlayerIndex].DeleteSelectedCard();

                SendMessage("Select to place group");
                if (Players[SelectedPlayerIndex].Selection == 1)
                {
                    Players[SelectedPlayerIndex].Selection = -1;

                    Players[SelectedPlayerIndex].AddSelectCard(temp);
                    Players[SelectedPlayerIndex].OnOffIlluminatiReverse();
                }
                else
                {
                    Players[SelectedPlayerIndex].OnOffIlluminatiReverse();
                }
            }
            else
            {
                Players[SelectedPlayerIndex].OnOffIlluminatiReverse();
            }
        }

        public async void DropGroup()
        {
            SendMessage("Select group to drop");
            Players[SelectedPlayerIndex].OnOffIlluminati();
            await Task.Run(() => Players[SelectedPlayerIndex].Test());

            if (Players[SelectedPlayerIndex].Selection == 1)
            {
                Players[SelectedPlayerIndex].Selection = -1;

                var temp = Players[SelectedPlayerIndex].BoardGrid[Players[SelectedPlayerIndex].SelectedCardIndex];
                Players[SelectedPlayerIndex].DeleteSelectedCard();
                Players[SelectedPlayerIndex].OnOffIlluminatiReverse();
                uncontrolled.BoardGrid.Add(temp);
            }
            else 
            {
                Players[SelectedPlayerIndex].OnOffIlluminatiReverse();
            }
        }

        public int Compare(List<Alignments.Alignment> a, List<Alignments.Alignment> b)
        {
            int total = 0;
            Alignments ali = new Alignments();
            for (int x = 0; x < a.Count; x++)
            {
                if (b.Count == 0)
                {
                    break;
                }
                for (int y = 0; y < b.Count; y++)
                {
                    if (ali.IsOppositeAlignment(a[x], b[y]))
                    {
                        total -= 4;
                        b.Remove(b[y]);
                        break;
                    }
                    else if (ali.IsSameAlignment(a[x], b[y]))
                    {
                        total += 4;
                        b.Remove(b[y]);
                        break;
                    }
                }
            }
            return total;
        }

        public bool DiceRoll(int pow, int res, int comp)
        {
            int total = pow - res + comp;
            if (total < 0)
            {
                return false;
            }

            int roll = rnd.Next(13);

            if (roll == 11 || roll == 12)
            {
                return false;
            }

            else if(roll <= total)
            {
                return true;
            }

            return false;
        }

        public void EndTurn()
        {
            if (actionCount == 2)
            {
                //Players[SelectedPlayerIndex].
            }
            if (SelectedPlayerIndex != Players.Count)
            {
                SelectedPlayerIndex++;
            }
            PlayerView = Players[SelectedPlayerIndex % (Players.Count - 1)];
            if (SelectedPlayerIndex == Players.Count - 1)
            {
                SelectedPlayerIndex = 0;
            }
            StartTurn();
        }
    }
}
