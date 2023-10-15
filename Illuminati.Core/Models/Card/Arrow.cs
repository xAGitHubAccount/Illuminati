using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Illuminati.Core.Models.Card
{
    public class Arrow
    {
        Dictionary<Direction, Direction> sum = new Dictionary<Direction, Direction>();

        public Arrow()
        { }

        public void AddArrow(Direction a, Direction b)
        {
            sum.Add(a, b);
        }
    }
}
