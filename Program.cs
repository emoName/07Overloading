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

            MyClass myClass = new MyClass();
           

        
            
            foreach(var i in angles)
            {

                Console.WriteLine(i);

            }
            Console.WriteLine("======================================================");
            foreach (var item in myClass)
            {
             
                Console.WriteLine(item);
                Console.WriteLine("=====================================================");
                foreach (var item1 in myClass)
                {
                    Console.WriteLine(item1);
                }
                Console.WriteLine("==================================");
            }

            Console.WriteLine("-------------------------------------------------------------------");
            while (myClass.MoveNext())
            {
                Console.WriteLine(myClass.Current);
            }
            myClass.Reset();



            Console.ReadLine();
        }

    }



    class MyClass : IEnumerable ,IEnumerator
    {
      public  int a;

        public int b;

        int _curentPosition = -1;

        public MyClass()
        {
            a = 2;
            b = 5;
        }

        public MyClass(MyClass myClass)
        {
            this.a = myClass.a;
            this.b = myClass.b;
                
                
                }

        public object Current
        {
            get
            {
                switch (_curentPosition)
                {
                    case 0: return this.a;
                    case 1: return this.b;

                    default:
                        throw new IndexOutOfRangeException();
                        break;
                }
            }

        }

        public IEnumerator GetEnumerator()
        {
            return (IEnumerator)  new MyClass(this)  ;
        }

        public bool MoveNext()
        {
            _curentPosition++;
            return _curentPosition < 2 ? true : false;
        }

        public void Reset()
        {
            _curentPosition = -1;
        }
    }
}
