//Que 1 Write static functions to return all permutations of a String using iterative method and
//Recursion method.Check if the arrays returned by two string functions are equal.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16_17
{
    public class Que_1
    {
       
            public static void permute(String str, int l, int r)
            {
                if (l == r)
                    Console.WriteLine(str);
                else
                {
                    for (int i = l; i <= r; i++)
                    {
                        str = swap(str, l, i);
                        permute(str, l + 1, r);
                        str = swap(str, l, i);
                    }
                }
            
            }
          
            public static String swap(String a, int i, int j)
            {
                char temp;
                char[] charArray = a.ToCharArray();
                temp = charArray[i];
                charArray[i] = charArray[j];
                charArray[j] = temp;
                string s = new string(charArray);
                return s;
            }
         public void permutecombination()
           {
                String str = "LZM";
                int n = str.Length;
                n--;
                Que_1 que_1 = new Que_1();
                permute(str, 0, n);
            }
                
            
        

    }

}

