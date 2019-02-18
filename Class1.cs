using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Overloading
{

    class Angle : IEnumerable
    {
        private Double _degrees;
        private Double _minutes;
        private Double _seconds;

        protected int DegreeToMin(int degree)
        {

            return (degree * 60);
        }
        protected int MinToSec(int min)
        {

            return (min * 60);
        }
        private const Double _eps = 0.0000001;


        public static Boolean operator ==(Angle a, Angle b)
        {

            if (
               System.Math.Abs(a._degrees - b._degrees) < _eps &&
               System.Math.Abs(a._minutes - b._minutes) < _eps &&
               System.Math.Abs(a._seconds - b._seconds) < _eps
                )
            {
                return true;
            }
            return false;

        }
        public static Boolean operator !=(Angle a, Angle b)
        {
            return !(a == b);
        }


        public Double this[int s]
        {
            get
            {
              //  s = s.ToLower();
                switch (s)
                {
                    case 0 : return _degrees;
                    case 1 : return _minutes;
                    case 2 : return _seconds;
                    default:
                        throw new IndexOutOfRangeException($"Not expected Index :: {s} ::");
                        break;
                }
            }

            set
            {
              //  s = s.ToLower();
                switch (s)
                {
                    case 0 : _degrees = value; break;
                    case 1 : _minutes = value; break;
                    case 2 : _seconds = value; break;
                    default:
                        throw new IndexOutOfRangeException($"Not expected Index :: {s} ::");
                        break;
                }
            }
        }










        public override bool Equals(object obj)
        {
            var angle = obj as Angle;
            return angle != null &&
                   _degrees == angle._degrees &&
                   _minutes == angle._minutes &&
                   _seconds == angle._seconds;
        }

        public override int GetHashCode()
        {
            var hashCode = 1248904213;
            hashCode = hashCode * -1521134295 + _degrees.GetHashCode();
            hashCode = hashCode * -1521134295 + _minutes.GetHashCode();
            hashCode = hashCode * -1521134295 + _seconds.GetHashCode();
            return hashCode;
        }

        public IEnumerator GetEnumerator()
        {
            return new AngleEnumerator(this);
        }
    }












}
