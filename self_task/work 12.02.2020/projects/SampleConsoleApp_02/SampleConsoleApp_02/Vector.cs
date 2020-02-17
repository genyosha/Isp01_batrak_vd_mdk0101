using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isp_1batrak
{
    class Vector
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Vector(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public double Length()
        {
            return Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2) + Math.Pow(Z, 2));
        }

        public double ScalarProduct(Vector vectorXYZ)
        {
            return X * vectorXYZ.X + Y * vectorXYZ.Y + +Z * vectorXYZ.Z;
        }


        public Vector Product(Vector vectorXYZ)
        {
            Vector vectorResult = new Vector(1, 1, 1);
            vectorResult.X = Y * vectorXYZ.Z - Z * vectorXYZ.Y;
            vectorResult.Y = Z * vectorXYZ.X - X * vectorXYZ.Z;
            vectorResult.Z = X * vectorXYZ.Y - Y * vectorXYZ.X;
            return vectorResult;
        }

        public override string ToString()
        {
            return "vec" + "(X: " + X + " " + "Y: " + Y + " " + "Z: " + Z + ")";
        }
    }
}
