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

	public int GetBalance()
	{
		return Balance;
	}

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
	
	public List<Alignments.Alignment> GetAlignments()
	{
		return alignments;
	}

	}
}
