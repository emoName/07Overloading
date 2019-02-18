using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Overloading
{
    class AngleEnumerator : IEnumerator
    {
        Angle _angle;

        public AngleEnumerator(Angle a)
        {
            _angle = a;
        }


        int _curentPoz = -1;
        public object Current
        {
            get
            {

                return _angle[_curentPoz];

            }

        }



        public bool MoveNext()
        {
            _curentPoz++;
            return _curentPoz < 3 ? true : false;
        }

        public void Reset()
        {
            _curentPoz = -1;
        }
    }
}
