using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Illuminati.Core.Models.Card.GroupCard
{
    public class Antifa : GroupCard
    {
        public Antifa() : base(new BitmapImage(new Uri(@"C:\Users\iN0va\source\repos\Illuminati\Illuminati.Core\Images\Groups\Antifa.png")), 0, 1, 6, 1,
            new List<Alignments.Alignment>()
        {
            Alignments.Alignment.Violent,
            Alignments.Alignment.Criminal,
            Alignments.Alignment.Fanatic
        })
        {
            Title = "Antifa";
        }
    }
}
