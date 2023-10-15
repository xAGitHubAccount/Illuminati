using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Illuminati.Core.Models.Card
{
    public class Alignments
    {
        public enum Alignment
        {
            Government, Communist, Liberal, Conservative, Peaceful,
            Violent, Straight, Weird, Media, Criminal, Fanatic
        }
        public bool IsOppositeAlignment(Alignment a, Alignment b)
        {
            if (a == Alignment.Liberal && b == Alignment.Conservative)
            {
                return true;
            }

            if (b == Alignment.Liberal && a == Alignment.Conservative)
            {
                return true;
            }

            if (a == Alignment.Peaceful && b == Alignment.Violent)
            {
                return true;
            }

            if (b == Alignment.Peaceful && a == Alignment.Violent)
            {
                return true;
            }

            if (a == Alignment.Straight && b == Alignment.Weird)
            {
                return true;

            }

            if (b == Alignment.Straight && a == Alignment.Weird)
            {
                return true;
            }

            if (a == Alignment.Fanatic && b == Alignment.Fanatic)
            {
                    return true;

            }
            return false;
        }
        public bool IsSameAlignment(Alignment a, Alignment b)
        {
            if (a == b)
            {
                return true;
            }
            return false;
        }
    }

}
