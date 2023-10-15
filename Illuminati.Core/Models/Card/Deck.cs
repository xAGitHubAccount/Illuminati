using Illuminati.Core.Models.Card.GroupCard;
using Illuminati.Core.Models.Card.IlluminatiCard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Illuminati.Core.Models.Card
{
    public class Deck
    {
        List<GroupCard.GroupCard> deck = new List<GroupCard.GroupCard>();
        List<GroupCard.GroupCard> iDeck = new List<GroupCard.GroupCard>();
        
        public Deck()
        {
            deck.Add(new Airlines());
            deck.Add(new AlienAbductors());
            deck.Add(new AmericanAutoduelAssociation());
            deck.Add(new Antifa());
            deck.Add(new AntiNuclearActivists());
            deck.Add(new AntiwarActivists());
            deck.Add(new ArmsSmugglers());
            deck.Add(new BigMedia());
            iDeck.Add(new TheBavarianIlluminati());
            iDeck.Add(new TheBermudaTriangle());
            iDeck.Add(new TheDiscordianSociety());
            iDeck.Add(new TheGnomesOfZurich());
            iDeck.Add(new TheNetwork());
            iDeck.Add(new TheServantsOfCthulhu());
            iDeck.Add(new TheSocietyOfAssassins());
            iDeck.Add(new TheUFOs());
        }

        public List<GroupCard.GroupCard> GetDeck()
        {
            return deck;
        }

        public GroupCard.GroupCard DrawCard()
        {
            GroupCard.GroupCard tem = deck[deck.Count - 1];
            deck.RemoveAt(deck.Count - 1);
            return tem;
        }

        public void ShuffleDeck()
        {
            Random random = new Random();

            for (int i = deck.Count - 1; i > 1; i--)
            {
                int rnd = random.Next(i + 1);

                GroupCard.GroupCard value = deck[rnd];
                deck[rnd] = deck[i];
                deck[i] = value;
            }
        }

        public GroupCard.GroupCard DrawICard()
        {
            GroupCard.GroupCard tem = iDeck[iDeck.Count - 1];
            iDeck.RemoveAt(iDeck.Count - 1);
            return tem;
        }

        public void ShuffleIDeck()
        {
            Random random = new Random();

            for (int i = iDeck.Count - 1; i > 1; i--)
            {
                int rnd = random.Next(i + 1);

                GroupCard.GroupCard value = iDeck[rnd];
                iDeck[rnd] = iDeck[i];
                iDeck[i] = value;
            }
        }
    }
}
