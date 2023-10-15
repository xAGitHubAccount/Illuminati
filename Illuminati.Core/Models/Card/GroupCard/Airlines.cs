using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Illuminati.Core.Models.Card.GroupCard
{
    public class Airlines : GroupCard
    {
        public Airlines() : base(new BitmapImage(new Uri(@"C:\Users\iN0va\source\repos\Illuminati\Illuminati.Core\Images\Groups\Airlines.png")), 1, -1, 3, 1, 
            new List<Alignments.Alignment>()
        {
            Alignments.Alignment.Straight
        })
        {
            Title = "Airlines";
		}
	}
}
