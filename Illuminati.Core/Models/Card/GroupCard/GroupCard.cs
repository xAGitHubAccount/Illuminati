using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Illuminati.Core.Models.Card.GroupCard
{
	public class GroupCard : Card
    {

	// Card properties
	protected int power;
	protected int tPower;
	protected int resistance;
		List<Alignments.Alignment> alignments = new List<Alignments.Alignment>();
		public int income { get; set; }
		//protected ArrayList<Alignments> alignments;

		// Attached cards
		protected GroupCard topCard;
	protected GroupCard rightCard;
	protected GroupCard bottomCard;
	protected GroupCard leftCard;

		//protected HashMap<SourceDirection, ArrowDirection> defaultControl;
		//protected HashMap<SourceDirection, ArrowDirection> control;
		//protected SourceDirection source = SourceDirection.NONE;
		//protected ArrowDirection point = ArrowDirection.NONE;

		//Arrow arrows = new Arrow();

	/*
	 * If card does not have a certain attribute (the card doesn't have a power or resistance
	 * for example) enter a -1 for that value. Note: there is a difference between a card not
	 * having a power and a card having a power of 0. If it has a 0 enter 0. Remember to add
	 * group card you made to deck at bottom of Game.java
	 */
	public GroupCard(BitmapImage i, int power, int tPower, int resistance, int income, List<Alignments.Alignment> a)
	{
		
		ImageSource = i;
		this.power = power;
		this.tPower = tPower;
		this.resistance = resistance;
		this.income = income;
		Balance = 0;
		cType = CardType.Group;
			alignments = a;
			//alignments = new ArrayList<Alignments>();
			//control = new HashMap<SourceDirection, ArrowDirection>();
			//defaultControl = control;
		}

	public void SetPower(int p)
	{
		this.power = p;
	}

	public void SetTPower(int tp)
	{
		this.tPower = tp;
	}

	public void SetResistance(int r)
	{
		this.resistance = r;
	}

	public void SetIncome(int i)
	{
		this.income = i;
	}

	//public void addAlignment(Alignments a)
	//{
	//	alignments.add(a);
	//}

	//public void addControl(SourceDirection c, ArrowDirection d)
	//{
	//	control.put(c, d);
	//}

	public int GetPower()
	{
		return power;
	}

	public int GetResistance()
	{
		return resistance;
	}

	public int GetIncome()
	{
		return income;
	}

	//public int GetBalance()
	//{
	//	return balance;
	//}

	public void CollectIncome()
	{
		Balance += income;
	}

	public void RemoveIncome()
	{
		Balance -= income;
	}

		public int ReturnRemoveIncome(int x)
		{
			Balance -= x;
			return x;
		}

		public void AddIncome(int x)
	{
		Balance += x;
	}

	public void RemoveIncome(int x)
	{
		Balance -= x;
	}

        //public ArrayList<Alignments> getAlignments()
        //{
        //	return alignments;
        //}

        //public HashMap<SourceDirection, ArrowDirection> getControl()
        //{
        //	return control;
        //}

 //       public void attachTop(GroupCard card)
	//{
	//	topCard = card;
	//}

	//public void attachRight(GroupCard card)
	//{
	//	rightCard = card;
	//}

	//public void attachBottom(GroupCard card)
	//{
	//	bottomCard = card;
	//}

	//public void attachLeft(GroupCard card)
	//{
	//	leftCard = card;
	//}

	//public void dettachCards()
	//{
	//	topCard = null;
	//	rightCard = null;
	//	bottomCard = null;
	//	leftCard = null;

	//	Iterator Iter = control.entrySet().iterator();

	//	while (Iter.hasNext())
	//	{
	//		Map.Entry mapElement = (Map.Entry)Iter.next();
	//		if (mapElement.getValue().equals(ArrowDirection.NONE))
	//		{
	//			control.put((SourceDirection)mapElement.getKey(), ArrowDirection.OUT);
	//		}
	//	}
	//}

	//public void turnClockWise()
	//{
	//	HashMap<SourceDirection, ArrowDirection> temp = new HashMap<SourceDirection, ArrowDirection>();
	//	Iterator Iter = control.entrySet().iterator();

	//	while (Iter.hasNext())
	//	{
	//		Map.Entry mapElement = (Map.Entry)Iter.next();
	//		if (mapElement.getKey().equals(SourceDirection.TOP))
	//		{
	//			temp.put(SourceDirection.RIGHT, (ArrowDirection)mapElement.getValue());
	//		}
	//		else if (mapElement.getKey().equals(SourceDirection.RIGHT))
	//		{
	//			temp.put(SourceDirection.BOTTOM, (ArrowDirection)mapElement.getValue());
	//		}
	//		else if (mapElement.getKey().equals(SourceDirection.BOTTOM))
	//		{
	//			temp.put(SourceDirection.LEFT, (ArrowDirection)mapElement.getValue());
	//		}
	//		else if (mapElement.getKey().equals(SourceDirection.LEFT))
	//		{
	//			temp.put(SourceDirection.TOP, (ArrowDirection)mapElement.getValue());
	//		}
	//	}

	//	if (temp.size() != 0)
	//	{
	//		control = temp;
	//	}
	//}

	//public void turnCounterClockWise()
	//{
	//	HashMap<SourceDirection, ArrowDirection> temp = new HashMap<SourceDirection, ArrowDirection>();
	//	Iterator Iter = control.entrySet().iterator();

	//	while (Iter.hasNext())
	//	{
	//		Map.Entry mapElement = (Map.Entry)Iter.next();
	//		if (mapElement.getKey().equals(SourceDirection.TOP))
	//		{
	//			temp.put(SourceDirection.LEFT, (ArrowDirection)mapElement.getValue());
	//		}
	//		else if (mapElement.getKey().equals(SourceDirection.LEFT))
	//		{
	//			temp.put(SourceDirection.BOTTOM, (ArrowDirection)mapElement.getValue());
	//		}
	//		else if (mapElement.getKey().equals(SourceDirection.BOTTOM))
	//		{
	//			temp.put(SourceDirection.RIGHT, (ArrowDirection)mapElement.getValue());
	//		}
	//		else if (mapElement.getKey().equals(SourceDirection.RIGHT))
	//		{
	//			temp.put(SourceDirection.TOP, (ArrowDirection)mapElement.getValue());
	//		}
	//	}

	//	if (temp.size() != 0)
	//	{
	//		control = temp;
	//	}
	//}

	//public void turnOneEighty()
	//{
	//	HashMap<SourceDirection, ArrowDirection> temp = new HashMap<SourceDirection, ArrowDirection>();
	//	Iterator Iter = control.entrySet().iterator();

	//	while (Iter.hasNext())
	//	{
	//		Map.Entry mapElement = (Map.Entry)Iter.next();
	//		if (mapElement.getKey().equals(SourceDirection.TOP))
	//		{
	//			temp.put(SourceDirection.BOTTOM, (ArrowDirection)mapElement.getValue());
	//		}
	//		else if (mapElement.getKey().equals(SourceDirection.RIGHT))
	//		{
	//			temp.put(SourceDirection.LEFT, (ArrowDirection)mapElement.getValue());
	//		}
	//		else if (mapElement.getKey().equals(SourceDirection.BOTTOM))
	//		{
	//			temp.put(SourceDirection.TOP, (ArrowDirection)mapElement.getValue());
	//		}
	//		else if (mapElement.getKey().equals(SourceDirection.LEFT))
	//		{
	//			temp.put(SourceDirection.RIGHT, (ArrowDirection)mapElement.getValue());
	//		}
	//	}

	//	if (temp.size() != 0)
	//	{
	//		control = temp;
	//	}
	//}

	//public void restoreDefaultControl()
	//{
	//	control = defaultControl;
	//}

	//public GroupCard getTopCard()
	//{
	//	return topCard;
	//}

	//public GroupCard getRightCard()
	//{
	//	return rightCard;
	//}

	//public GroupCard getBottomCard()
	//{
	//	return bottomCard;
	//}

	//public GroupCard getLeftCard()
	//{
	//	return leftCard;
	//}
	}
}
