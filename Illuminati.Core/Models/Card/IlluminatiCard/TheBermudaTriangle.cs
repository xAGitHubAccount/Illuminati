using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Illuminati.Core.Models.Card.IlluminatiCard
{
    public class TheBermudaTriangle : IlluminatiCard
    {
        public TheBermudaTriangle() : base(new BitmapImage(new Uri(@"C:\Users\iN0va\source\repos\Illuminati\Illuminati.Core\Images\TheBermudaTriangle.png")), 8, 8, 9, new List<Alignments.Alignment>())
        {
            Title = "TheBermudaTriangle";
        }
    }
}
