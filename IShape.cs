using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces
{
    internal interface IShape
    {
        public interface IShape
        {
            double calculateArea();
            double calculatePerimeter();
        }
    }
    public class Rectangle : IShape
    {
        private double length;
        private double width;

        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }
        public double getArea()
        {
            return length*width;
        }
        public double getPerimeter()
        {
            return 2*(length + width);
        }
    }
    public class Circle : IShape
    {
        private double radius;
        
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public double getArea() {
        return Math.PI * radius * radius;
        }

        public double getPerimeter()
        {
            return 2 * Math.PI * radius;
        }
    }
}
