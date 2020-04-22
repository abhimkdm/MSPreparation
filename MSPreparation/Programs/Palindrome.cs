using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSPreparation.Programs
{
    public class Palindrome
    {
        public Palindrome()
        {
            strPal("1221");
            intPal(1221);
            intPal(1234);
        }


        /// <summary>
        /// Check whether given int is palindrome or not
        /// </summary>
        /// <param name="num"></param>
        private void intPal(int num) {
            if (num <= 0)
                Console.WriteLine("Enter min four digit");
            else {
                var sum = "";
                var rem = 0;
                var oldNum = num;
                while (num > 0)
                {
                    rem = num % 10;
                    num = num / 10;
                    sum += rem;
                }
                isPal(oldNum, int.Parse(sum));
            }

        }

        /// <summary>
        /// Check whether given string is palindrome or not
        /// </summary>
        /// <param name="curStr"></param>
        private void strPal(string curStr) {
            if (curStr == "")
                Console.WriteLine("Empty String");
            else
            {
                var rvsStr = "";
                for (int i = curStr.Length-1; i >= 0; i--)
                {
                    rvsStr += curStr[i];
                }
                isPal(curStr, rvsStr);
            }
        }

        private void isPal(object oldPar, object newPar) {
            if (oldPar.Equals(newPar)) 
                Console.WriteLine(oldPar +" is Palindrome");
            else
                Console.WriteLine(oldPar + " is Not A Palindrome");
        }
    }
}
