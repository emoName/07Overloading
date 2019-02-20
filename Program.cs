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

            Angle a = new Angle();

            a[0] = 3;
            a[1] = 4;
            a[2] = 1;
            Angle b = new Angle() { [0] = 6, [1] = 3, [2] = 30 };
            Angle c;

            MyClass myClass = new MyClass();


            myClass.MoveNext();

            foreach (var i in a)
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

            //-------------------------------------------------------------------------------------------------
            c = a + b;

            a.Show();
            b.Show();
            Console.Write("a + b = ");
            c.Show();

            Angle[] angles = new Angle[] { a, b, c };

            angles.Reverse();

            Show(angles);

            Array.Sort(angles);
            Console.WriteLine("-----------------------------------------------------------");

            Show(angles);

            Array.Sort(angles, new CustomCompare());

            Show(angles);



            Console.ReadLine();
        }

        public static void Show(Angle[] angles)
        {
      foreach (var item in angles)
            {
                item.Show();
            }

        }

    }




}
