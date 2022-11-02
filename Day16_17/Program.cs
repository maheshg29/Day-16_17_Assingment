using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16_17
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Wellcome to Day 16 and 17 Assingment Problem");
            Console.WriteLine("*****Solution of questions number 1 *****");
            Que_1 que_1 = new Que_1();
            que_1.permutecombination();
            Console.WriteLine("_________________________________________");
            Console.WriteLine("*****Solution of questions number 2 *****");
            Que_2 que_2 = new Que_2();
            que_2.binarysrch();
            Console.WriteLine("_________________________________________");
            Console.WriteLine("*****Solution of questions number 3 *****");
            Que_3 que_3 = new Que_3();
            que_3.Insertion();
            Console.WriteLine("_________________________________________");
            Console.WriteLine("*****Solution of questions number 4 *****");
            Que_4 que_4 = new Que_4();
            que_4.Bubblesort();
            Console.WriteLine("_________________________________________");
            Console.WriteLine("*****Solution of questions number 5 *****");
            Que_5 que_5 = new Que_5();  
            que_5.Margesort();
            Console.WriteLine("_________________________________________");
            Console.WriteLine("*****Solution of questions number 6 *****");
            Que_6 que_6 = new Que_6();
            que_6.Display();
            Console.WriteLine("_________________________________________");
            Console.WriteLine("*****Solution of questions number 7 *****");
            Que_7 que_7 = new Que_7();
            que_7.PrimeNumber();
            


        }
    }
}