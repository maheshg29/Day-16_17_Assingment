using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16_17
{
    public class Que_4
    {
        public void Bubblesort()
        {
            int[] arr = { 88, 57, 63, 87, 23 };
            int temp;
            for (int j = 0; j <= arr.Length - 2; j++)
            {
                for (int i = 0; i <= arr.Length - 2; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }

                }
                Console.WriteLine("Sorted:");
                foreach (int p in arr)
                    Console.Write(p + " ");

            }
        }
    }

}