using System;

namespace mathlib
{
    public struct Vector4 : IEquatable<Vector4>
    {
        public float x;
        public float y;
        public float z;
        public float w;

        public Vector4(float x, float y)
        {
            this.x = x;
            this.y = y;
            this.z = 0;
            this.w = 0;
        }


        public Vector4(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = 0;
        }

        public Vector4(float x, float y, float z, float w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }


        public static Vector4 Zero
        {
            get
            {
                return new Vector4(0, 0, 0, 0);
            }
        }

        public static Vector4 One
        {
            get
            {
                return new Vector4(1, 1, 1, 1);
            }
        }

 

        public Vector4 Normalized
        {
            get
            {
                return this / Magnitude;
            }
        }


        public float Magnitude
        {
            get
            {
                return (float)Math.Sqrt(Math.Pow(this.x, 2) + Math.Pow(this.y, 2) + Math.Pow(this.z, 2) + Math.Pow(this.w, 2));
            }
        }


        public UnityEngine.Vector4 UnityVec4
        {
            get
            {
                return new UnityEngine.Vector4(this.x, this.y, this.z, this.w);
            }
        }


        public bool Equals(Vector4 other)
        {
            return other.x == this.x && other.y == this.y && other.z == this.z && other.w == this.w;
        }

        public static Vector4 operator +(Vector4 a, Vector4 b)
        {
            return new Vector4(a.x + b.x, a.y + b.y, a.z + b.z, a.w + b.w);
        }


        public static Vector4 operator -(Vector4 a, Vector4 b)
        {
            return new Vector4(a.x - b.x, a.y - b.y, a.z - b.z, a.w - b.w);
        }


        public static Vector4 operator -(Vector4 a)
        {
            return new Vector4(-a.x, -a.y, -a.z, -a.w);
        }


        public static Vector4 operator *(Vector4 a, float d)
        {
            return new Vector4(a.x * d, a.y * d, a.z * d, a.w * d);
        }


        public static Vector4 operator *(float d, Vector4 a)
        {
            return new Vector4(a.x * d, a.y * d, a.z * d, a.w * d);
        }


        /// <summary>
        /// dot product
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static float operator *(Vector4 a, Vector4 b)
        {
            return a.x * b.x + a.y * b.y + a.z * b.z + a.w * b.w;
        }



        public static Vector4 operator /(Vector4 a, float d)
        {
            if (d == 0)
            {
                throw new Exception("Division by constant zero");
            }
            float temp = 1 / d;
            return a * temp;
        }


        public static bool operator ==(Vector4 a, Vector4 b)
        {
            return a.x == b.x && a.y == b.y && a.z == b.z && a.w == b.w;
        }


        public static bool operator !=(Vector4 a, Vector4 b)
        {
            return a.x != b.x || a.y != b.y || a.z != b.z || a.w != b.w;
        }

        public override bool Equals(object other)
        {
            if (!(other is Vector4))
            {
                return false;
            }
            Vector4 vec = (Vector4)other;
            return vec.x == this.x && vec.y == this.y && vec.z == this.z && vec.w == this.w;
        }


        public override int GetHashCode()
        {
            return base.GetHashCode();
        }


        public override string ToString()
        {
            return string.Format("({0}, {1}, {2})", this.x, this.y, this.z);
        }



        public static Vector4 Lerp(Vector4 a, Vector4 b, float t)
        {
            t = Math.Max(0, t);
            t = Math.Min(1, t);
            return new Vector4(a.x + (b.x - a.x) * t, a.y + (b.y - a.y) * t, a.z + (b.z - a.z) * t, a.w + (b.w - a.w) * t);
        }

    }
}
