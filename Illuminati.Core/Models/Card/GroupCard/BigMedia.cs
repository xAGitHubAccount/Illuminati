using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Illuminati.Core.Models.Card.GroupCard
{
    public class BigMedia : GroupCard
    {
        public BigMedia() : base(new BitmapImage(new Uri(@"C:\Users\iN0va\source\repos\Illuminati\Illuminati.Core\Images\Groups\BigMedia.png")), 4, 3, 6, 3,
            new List<Alignments.Alignment>()
        {
            Alignments.Alignment.Straight,
            Alignments.Alignment.Liberal,
            Alignments.Alignment.Media
        })
        {
            Title = "BigMedia";
        }
    }
}
