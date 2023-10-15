using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Illuminati.Core.Models.Card.IlluminatiCard
{
    public class TheGnomesOfZurich : IlluminatiCard
    {
        public TheGnomesOfZurich() : base(new BitmapImage(new Uri(@"C:\Users\iN0va\source\repos\Illuminati\Illuminati.Core\Images\TheGnomesOfZurich.png")), 7, 7, 12, new List<Alignments.Alignment>())
        {
            Title = "TheGnomesOfZurich";
        }
    }
}
