using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Illuminati.Core.Models.Card.IlluminatiCard
{
    public class TheSocietyOfAssassins : IlluminatiCard
    {
        public TheSocietyOfAssassins() : base(new BitmapImage(new Uri(@"C:\Users\iN0va\source\repos\Illuminati\Illuminati.Core\Images\TheSocietyOfAssassins.png")), 8, 8, 8, new List<Alignments.Alignment>())
        {
            Title = "TheSocietyOfAssassins";
        }
    }
}
