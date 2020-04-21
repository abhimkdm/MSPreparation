using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSPreparation.Programs
{
    public class ReveseString
    {
        public ReveseString()
        {
            Console.WriteLine("Iterative");
            iterativeMethod("hello");
            iterativeMethod("");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Recursive");
            recursiveMethod("hello", "hello".Length, "");
            recursiveMethod("", "".Length, "");
        }

        public void iterativeMethod(string str)
        {
            if (str == "")
                Console.WriteLine("Empty String");
            else
            {
                var newStr = "";
                var strArray = str.Length;

                for (int i = strArray -1; i >=0; i--)
                {
                    newStr += str[i];
                }
                Console.WriteLine("Reversed String : " + newStr);
            }
        }

        public void recursiveMethod(string str, int len, string newStr) {
            if (str == "")
                Console.WriteLine("Empty String :");
            else
            {
                if(len == 0)
                    Console.WriteLine("Reversed String : " + newStr);
                else
                    recursiveMethod(str, len-=1, newStr +=str[len]);
            }
        }
    }
}
