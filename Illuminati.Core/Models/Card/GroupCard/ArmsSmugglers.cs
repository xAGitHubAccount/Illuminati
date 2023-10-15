using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Illuminati.Core.Models.Card.GroupCard
{
    public class ArmsSmugglers : GroupCard
    {
        public ArmsSmugglers() : base(new BitmapImage(new Uri(@"C:\Users\iN0va\source\repos\Illuminati\Illuminati.Core\Images\Groups\ArmsSmugglers.png")), 2, -1, 6, 3,
            new List<Alignments.Alignment>()
        {
            Alignments.Alignment.Violent,
            Alignments.Alignment.Criminal
        })
        {
            Title = "ArmsSmugglers";
        }
    }
}
