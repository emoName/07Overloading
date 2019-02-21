using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Overloading
{

    class Angle : IEnumerable, IComparable, IShowAngle, ICloneable
    {


        private Double _degrees = 0;

        private Double _minutes = 0;

        private Double _seconds = 0;

        public Double Degrees
        {
            set
            {
                if (value > 360)
                {
                    throw new IndexOutOfRangeException("Degree Cant be > 360");
                }
                else
                {

                    _degrees = value;
                }
            }
            get
            {
                return _degrees;
            }
        }
        public Double Minutes
        {
            set
            {
                if (value > 60)
                {
                    Degrees = _degrees + (int)value / 60;
                    Minutes = value % 60;

                }
                else
                {
                    _minutes = value;
                }
            }
            get
            {
                return _minutes;
            }
        }
        public Double Seconds
        {
            set
            {
                if (value > 60)
                {
                    Minutes = _minutes + (int)value / 60;
                    Seconds = value % 60;

                }
                else
                {
                    _seconds = value;
                }
            }

            get
            {
                return _seconds;
            }
        }



        private const Double _eps = 0.0000001;


        public static Angle operator +(Angle a, Angle b)
        {
            return new Angle() { Degrees = a.Degrees + b.Degrees, Minutes = a.Minutes + b.Minutes, Seconds = a.Seconds + b.Seconds };
        }

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
                    case 0: return _degrees;
                    case 1: return _minutes;
                    case 2: return _seconds;
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
                    case 0: _degrees = value; break;
                    case 1: _minutes = value; break;
                    case 2: _seconds = value; break;
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

        public int CompareTo(object obj)
        {
            Angle angle = (Angle)obj;

            if (angle.Degrees < this.Degrees) return 1;
            if (angle.Degrees > this.Degrees) return -1;
            return 0;

        }

        public void Show()
        {
            Console.WriteLine($"Angle: {_degrees} ^ {_minutes} \'\' {_seconds} \'  :");
        }

        public object Clone()
        {
            Angle a = new Angle();
            a.Degrees = this.Degrees;
            a.Minutes = this.Minutes;
            a.Seconds = this.Seconds;
            return a;

        }



    }












}
