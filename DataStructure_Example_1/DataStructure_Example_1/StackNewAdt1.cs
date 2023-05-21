using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure_Example_1
{
    class StackNewAdt1
    {
        int[] a1, a2;
        int rear1, rear2;
        int max;
        public StackNewAdt1(int size)
        {
            max = size;
            a1 = new int[max];
            a2 = new int[max];
            rear1 = rear2 = -1;
        }
        public bool isEmpty(bool ch)
        {
            if (ch == true)
            {
                return rear1 == -1;
            }
            else
            {
                return rear2 == -1;
            }
        }
        public bool isFull(bool ch)
        {
            if (ch == true)
            {
                return rear1 == max - 1;
            }
            else
            {
                return rear2 == max - 1;
            }
        }
        public int Total()
        {
            return (rear1 + rear2 + 2);
        }
        public void Enqueue(int n)
        {
            if (isFull(true))
            {
                if (isFull(false))
                {
                    Console.WriteLine("\nStack 2 Is Empty Too , Not Added !");
                    return;
                }
                else
                {
                    a2[++rear2] = n;
                    Console.WriteLine($"\n{n} Is Pushed In Array2...");
                }
            }
            else
            {
                a1[++rear1] = n;
                Console.WriteLine($"\n{n} Is Pushed In Array1...");
            }
        }
        public void Dequeue()
        {
            if (isEmpty(true))
            {
                if (isEmpty(false))
                {
                    Console.WriteLine("\nStack 2 Is Empty Too , Not Added !");
                    return;
                }
                else
                {
                    Console.WriteLine($"\n{a2[0]} Is Poped In Array2...");
                    for (int i = 0; i <= rear2; i++)
                    {
                        a2[i] = a2[i++];
                    }
                    rear2--;
                }
            }
            else
            {
                //d = a1[0];
                Console.WriteLine($"{a1[0]} Is Deleted...");
                for (int i = 0; i <= rear1; i++)
                {
                    a1[i] = a1[i + 1];
                }
                rear1--;
            }
        }
        public void print()
        {
            Console.Write("\nArray ( Stack1 Before Stack 2 ) Is : ");
            if (!isEmpty(true))
            {
                for (int i = 0; i <= rear1; i++)
                {
                    Console.Write(a1[i] + " . ");
                }
            }
            else
                Console.Write("Empty  ");
            Console.Write("->  ");
            if (!isEmpty(false))
            {
                for (int j = 0; j <= rear2; j++)
                {
                    Console.Write(a2[j] + " . ");
                }
            }
            else
                Console.Write("Empty");
        }
        public int Len()
        {
            return (rear1 + rear2 + 2);
        }
    }
}
