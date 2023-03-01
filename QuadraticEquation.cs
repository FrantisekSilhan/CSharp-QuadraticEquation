using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class QuadraticEquation
    {
        public QuadraticEquation(float a, float b, float c)
        {
            A = a;
            B = b;
            C = c;
        }

        public float A { get; set; }
        public float B { get; set; }
        public float C { get; set; }


        public void SetParameters(float a, float b, float c)
        {
            A = a;
            B = b;
            C = c;
        }

        public float Discriminant()
        {
            return B * B - 4 * A * C;
        }

        public int RootCount()
        {
            float discriminant = Discriminant();
            if (discriminant > 0) return 2;
            if (discriminant == 0) return 1;
            return 0;
        }

        public float[] Roots()
        {
            int rootCount = RootCount();
            float discriminant = Discriminant();

            if (A == 0)
            {
                return new float[] { -C / B };
            }

            if (rootCount == 0) return new float[] { };

            if (rootCount == 1) return new float[] { -B / (2 * A) };

            return new float[] { (-B + MathF.Sqrt(discriminant)) / (2 * A), (-B - MathF.Sqrt(discriminant)) / (2 * A) };
        }
        public float[] Vertex()
        {
            if (A == 0)
            {
                return new float[] { };
            }

            float x = -B / (2 * A);
            float y = A * x * x + B * x + C;
            return new float[] { x, y };
        }

        public float Value(float x)
        {
            return A * x * x + B * x + C;
        }
    }
}
