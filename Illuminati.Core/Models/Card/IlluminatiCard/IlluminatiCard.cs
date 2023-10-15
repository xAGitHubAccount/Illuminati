using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using static Illuminati.Core.Models.Card.CardType;

namespace Illuminati.Core.Models.Card.IlluminatiCard
{
	public abstract class IlluminatiCard : GroupCard.GroupCard
	{

	public IlluminatiCard(BitmapImage name, int power, int tPower, int income, List<Alignments.Alignment> a) : base(name, power, tPower, 0, income, a)
	{
		this.ImageSource = name;
		this.power = power;
		this.tPower = tPower;
		this.income = income;
			OnOff = true;
			Balance = 0;
			cType = CardType.Illuminati;
		}

	}
}
