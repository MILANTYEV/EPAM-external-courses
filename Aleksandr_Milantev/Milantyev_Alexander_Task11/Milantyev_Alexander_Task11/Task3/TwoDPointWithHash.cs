using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class TwoDPointWithHash : TwoDPoint
    {
        public TwoDPointWithHash(int x, int y)
            : base(x, y)
        { }

        public override int GetHashCode()
        {
            return (x ^ y) != 0 ? x ^ y : x & y;
        }
    }
}
