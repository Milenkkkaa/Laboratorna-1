using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorna_1
{
    internal class House
    {
        public double Width;
        public double Length;
        public double Height;
        public int Room;
        public int Floor;
        public int Price;
        public bool HasForniture;

        public double GetVolume()
        { 
            return (Width * Length) * Height;
        }
    }
}
