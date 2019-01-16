using System;
using System.Collections.Generic;
using System.Text;

namespace OperatorOverloading
{
    class Box
    {
        public double Length { get; set; }

        public double Width { get; set; }

        public double Height { get; set; }

        public static Box operator+ (Box box1, Box box2)
        {
            return new Box
            {
                Length = box1.Length + box2.Length,
                Width = box1.Width + box2.Width,
                Height = box1.Height + box2.Height
            };

        }

        public static Box operator+ (Box a,double b)
        {
            return new Box
            {
                Length = a.Length,
                Width = a.Width + b,
                Height = a.Height
            };

        }

        public double Area()
        {
            return Height * Length * Width;
        }

        public static bool operator >(Box a, Box b)
        {
            return (a.Area() > b.Area());
        }

        public static bool operator <(Box a, Box b)
        {
            return (a.Area() < b.Area());
        }

        public static bool operator ==(Box a, Box b)
        {
            return (a.Area() == b.Area());
        }

        public static bool operator !=(Box a, Box b)
        {
            return (a.Area() != b.Area());
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Box)) return false;
            return (this == (obj as Box));
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }


    }
}
