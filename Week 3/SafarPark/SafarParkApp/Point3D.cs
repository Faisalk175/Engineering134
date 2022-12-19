using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SafarParkApp
{
    public struct Point3D
    {
        public int x;
        public int y;
        public int z;
        // or public int x, y, x;

        public Point3D(int x, int y, int z = 0)
        {
            this.x = x; this.y = y; this.z = z; 
        }

        public int DistanceFromOrigin()
        {
            double calc = Math.Sqrt(x * x + y * y + z * z);
            return (int)calc;
        }

    }
}
