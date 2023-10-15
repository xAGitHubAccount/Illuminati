using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Illuminati.Core.Models.Card.GroupCard
{
    public class AntiwarActivists : GroupCard
    {
        public AntiwarActivists() : base(new BitmapImage(new Uri(@"C:\Users\iN0va\source\repos\Illuminati\Illuminati.Core\Images\Groups\AntiwarActivists.png")), 0, -1, 3, 1,
            new List<Alignments.Alignment>()
        {
            Alignments.Alignment.Liberal,
            Alignments.Alignment.Peaceful
        })
        {
            Title = "AntiwarActivists";
        }
    }
}
