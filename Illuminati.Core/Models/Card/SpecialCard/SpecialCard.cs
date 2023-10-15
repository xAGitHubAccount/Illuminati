using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Illuminati.Core.Models.Card.SpecialCard
{
	public abstract class SpecialCard : Card
	{ 
		String description;


	public SpecialCard(String name, String desc)
	{
		this.description = desc;
	}

	public String getDescription()
	{
		return description;
	}
}
}
