using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Illuminati.Core.Models.Card.IlluminatiCard
{
    public class TheNetwork : IlluminatiCard
    {
        public TheNetwork() : base(new BitmapImage(new Uri(@"C:\Users\iN0va\source\repos\Illuminati\Illuminati.Core\Images\TheNetwork.png")), 7, 7, 9, new List<Alignments.Alignment>())
        {
            Title = "TheNetwork";
        }
    }
}
