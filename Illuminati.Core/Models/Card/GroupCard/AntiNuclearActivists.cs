using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Illuminati.Core.Models.Card.GroupCard
{
    public class AntiNuclearActivists : GroupCard
    {
        public AntiNuclearActivists() : base(new BitmapImage(new Uri(@"C:\Users\iN0va\source\repos\Illuminati\Illuminati.Core\Images\Groups\Anti-NuclearActivists.png")), 2, -1, 5, 1,
            new List<Alignments.Alignment>()
        {
            Alignments.Alignment.Liberal
        })
        {
            Title = "AntiNuclearActivists";
        }
    }
}
