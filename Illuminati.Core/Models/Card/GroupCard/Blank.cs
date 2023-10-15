using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Illuminati.Core.Models.Card.GroupCard
{
	public class Blank : GroupCard
	{
		public Blank(): base(new BitmapImage(new Uri(@"C:\Users\iN0va\source\repos\Illuminati\Illuminati.Core\Images\Blank.png")), -1, -1, -1, -1, new List<Alignments.Alignment>())
		{
			Title = "";
			OnOff = false;
		}
	}
}
