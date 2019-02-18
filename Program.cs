using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Overloading
{
    class Program
    {
        static void Main(string[] args)
        {

            Angle angles = new Angle();

            angles[0] = 3;
            angles[1] = 4;
            angles[2] = 1;

        
            
            foreach(var i in angles)
            {

                Console.WriteLine(i);

            }




            Console.ReadLine();
        }

    }



    class MyClass : IEnumerable
    {
      public  int a;
        private MyClass Next;
        public object Current => throw new NotImplementedException();

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}
