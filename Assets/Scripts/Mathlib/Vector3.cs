using System;

namespace mathlib {
    public struct Vector3 : IEquatable<Vector3>
    {
        public float x;
        public float y;
        public float z;

        public Vector3(float x, float y)
        {
            this.x = x;
            this.y = y;
            this.z = 0;
        }


        public Vector3(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }


        public static Vector3 Zero
        {
            get
            {
                return new Vector3(0, 0, 0);
            }
        }

        public static Vector3 One
        {
            get
            {
                return new Vector3(1, 1, 1);
            }
        }

        public static Vector3 Forward
        {
            get
            {
                return new Vector3(0, 0, 1);
            }
        }

        public static Vector3 Back
        {
            get
            {
                return new Vector3(0, 0, -1);
            }
        }

        public static Vector3 Right
        {
            get
            {
                return new Vector3(1, 0, 0);
            }
        }

        public static Vector3 Down
        {
            get
            {
                return new Vector3(0, -1, 0);
            }
        }

        public static Vector3 Left
        {
            get
            {
                return new Vector3(-1, 0, 0);
            }
        }

        public static Vector3 Up
        {
            get
            {
                return new Vector3(0, 1, 0);
            }
        }


        public Vector3 Normalized {
            get {
                return this / Magnitude;
            }
        }


        public float Magnitude {
            get {
                return (float)Math.Sqrt(Math.Pow(this.x, 2) + Math.Pow(this.y, 2) + Math.Pow(this.z, 2));
            }
        }


        public UnityEngine.Vector3 UnityVec3 {
            get {
                return new UnityEngine.Vector3(this.x, this.y, this.z);
            }
        }


        public bool Equals(Vector3 other)
        {
            return other.x == this.x && other.y == this.y && other.z == this.z;
        }

        public static Vector3 operator +(Vector3 a, Vector3 b)
        {
            return new Vector3(a.x + b.x, a.y + b.y, a.z + b.z);
        }


        public static Vector3 operator -(Vector3 a, Vector3 b)
        {
            return new Vector3(a.x - b.x, a.y - b.y, a.z - b.z);
        }


        public static Vector3 operator -(Vector3 a) {
            return new Vector3(-a.x, -a.y, -a.z);
        }


        public static Vector3 operator *(Vector3 a, float d)
        {
            return new Vector3(a.x * d, a.y * d, a.z * d);
        }


        public static Vector3 operator *(float d, Vector3 a)
        {
            return new Vector3(a.x * d, a.y * d, a.z * d);
        }


        /// <summary>
        /// dot product
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static float operator *(Vector3 a, Vector3 b) {
            return a.x * b.x + a.y * b.y + a.z * b.z;
        }


        public static Vector3 Cross(Vector3 a, Vector3 b) {
            return new Vector3(a.y * b.z - a.z * b.y, a.z * b.x - a.x * b.z, a.x * b.y - a.y * b.x);
        }


        public static Vector3 operator /(Vector3 a, float d)
        {
            if (d == 0)
            {
                throw new Exception("Division by constant zero");
            }
            float temp = 1 / d;
            return a * temp;
        }


        public static bool operator ==(Vector3 a, Vector3 b)
        {
            return a.x == b.x && a.y == b.y && a.z == b.z;
        }


        public static bool operator !=(Vector3 a, Vector3 b)
        {
            return a.x != b.x || a.y != b.y || a.z != b.z;
        }

        public override bool Equals(object other)
        {
            if (!(other is Vector3))
            {
                return false;
            }
            Vector3 vec = (Vector3)other;
            return vec.x == this.x && vec.y == this.y && vec.z == this.z;
        }


        public override int GetHashCode()
        {
            return base.GetHashCode();
        }


        public override string ToString()
        {
            return string.Format("({0}, {1}, {2})", this.x, this.y, this.z);
        }


        public static float Angle(Vector3 a, Vector3 b) {
            double radian = Math.Acos(a * b / (a.Magnitude * b.Magnitude));
            return (float)(radian * 180 / Math.PI);
        }


        public static Vector3 Lerp(Vector3 a, Vector3 b, float t) {
            t = Math.Max(0, t);
            t = Math.Min(1, t);
            return new Vector3(a.x + (b.x - a.x) * t, a.y + (b.y - a.y) * t, a.z + (b.z - a.z) * t);
        }

        public static Vector3 Reflect(Vector3 inDirection, Vector3 inNormal) {
            Vector3 res = inDirection + 2 * (-inDirection) * inNormal * inNormal;
            return res;
        } 


        public static Vector3 Project(Vector3 vector, Vector3 onNormal)
        {
            return onNormal * (onNormal * vector / (float)(Math.Pow(onNormal.x, 2) + Math.Pow(onNormal.y, 2) + Math.Pow(onNormal.z, 2)));
        }


        public static Vector3 Slerp(Vector3 a, Vector3 b, float t) {
            
            return Vector3.Zero;
        }

    }
}
