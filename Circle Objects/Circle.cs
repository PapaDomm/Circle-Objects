using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle_Objects
{
    public class Circle
    {
        private double radius;

        public Circle(double Uradius)
        {
            radius = Uradius;
        }

        public double CalculateDiameter()
        {
            return radius * 2;
        }
        public double CalculateCircumference()
        {
            return radius * 2 * System.Math.PI;
        }
        public double CalculateArea()
        {
            return radius * radius * System.Math.PI;
        }
        public void Grow()
        {
            radius *= 2;
        }
        public double GetRadius()
        {
            return radius;
        }
    }
}
