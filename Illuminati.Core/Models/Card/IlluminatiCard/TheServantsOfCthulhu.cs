using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Illuminati.Core.Models.Card.IlluminatiCard
{
    public class TheServantsOfCthulhu : IlluminatiCard
    {
        public TheServantsOfCthulhu() : base(new BitmapImage(new Uri(@"C:\Users\iN0va\source\repos\Illuminati\Illuminati.Core\Images\TheServantsOfCthulhu.png")), 9, 9, 7, new List<Alignments.Alignment>())
        {
            Title = "TheServantsOfCthulhu";
        }
    }
}
