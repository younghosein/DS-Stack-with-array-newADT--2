using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure_Example_1
{
    class Program
    {
        static void Main(string[] args)
        {
            StackNewAdt1 s = new StackNewAdt1(4);
            s.Enqueue(12);
            s.Enqueue(9);
            s.Enqueue(7);
            s.Enqueue(24);
            s.print();
            s.Enqueue(12);
            s.Enqueue(92);
            s.Enqueue(77);
            s.print();
            s.Dequeue();
            s.Dequeue();
            //s.Dequeue();
            //s.Dequeue();
            s.print();



            Console.ReadKey();
        }
    }
}
