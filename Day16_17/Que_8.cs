using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Day16_17
{
    public class Que_8
    {
        public void AnagramAndPallindrom(int num)
        {
            int rem, sum = 0, temp;
            temp = num;
            while (num > 0)
            {
                rem = num % 10;
                num = num / 10;
                sum = sum * 10 + rem;

            }

            if (temp == sum)
            {
                Console.WriteLine(temp + "Number is Palindrome \n\n");
            }

        } 
        
    }
}
