using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Illuminati.Core.Models.Card.GroupCard
{
    public class AmericanAutoduelAssociation : GroupCard
    {
        public AmericanAutoduelAssociation() : base(new BitmapImage(new Uri(@"C:\Users\iN0va\source\repos\Illuminati\Illuminati.Core\Images\Groups\AmericanAutoduelAssociation.png")), 1, -1, 5, 1,
            new List<Alignments.Alignment>()
            {
                Alignments.Alignment.Violent,
                Alignments.Alignment.Weird
            })
        {
            Title = "AmericanAutoduelAssociation";
        }
    }
}
