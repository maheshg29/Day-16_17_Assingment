using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16_17
{
    public class Que_2
    {

        static int binarySearch(String[] arr, String x)
        {
            int l = 0, r = arr.Length - 1;
            while (l <= r)
            {
                int m = l + (r - l) / 2;

                int res = x.CompareTo(arr[m]);

               
                if (res == 0)
                    return m;

                if (res > 0)
                    l = m + 1;

                else
                    r = m - 1;
            }

            return -1;
        }

        public void binarysrch()
        {
            String[] arr = { "mahesh", "gangurde", "india", "bridgelabz" };
            String x = "mahesh";
            int result = binarySearch(arr, x);

            if (result == -1)
                Console.WriteLine("Element not present");
            else
                Console.WriteLine("Element found at "  + "index " + result);
        }
    }
}
