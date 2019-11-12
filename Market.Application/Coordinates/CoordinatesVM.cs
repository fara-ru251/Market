using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Market.Application.Coordinates
{
    public class CoordinatesVM
    {
        public double X { get; private set; }
        public double Y { get; private set; }

        public void ReWrite(double? x = null, double? y = null)
        {
            this.X = x ?? this.X;
            this.Y = y ?? this.Y;
        }

        public CoordinatesVM(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        public static implicit operator CoordinatesVM(object[] list)
        {
            return new CoordinatesVM((double)list[0], (double)list[1]);
        }

    }
}
