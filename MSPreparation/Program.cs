using MSPreparation.General;
using MSPreparation.Programs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            //01. Find a given number is a Armstrong Number
            //ArmStrongNumber.FindArmStrongNumber();

            //02. Singleton Pattern With Thead Safe
            //var instanace = SingletonPattern.Instance;

            //03. Pass by Value vs pass by Reference parameters
            //var refvalPar = new RefValParameters();
            //refvalPar.RefVal();

            //04. Reverse the given string “ABC” without using inbuilt methods.
            //ReveseString reveseString = new ReveseString();

            //05. Write palindrome logic without using inbuilt for integer 1221 or "1221"?
            Palindrome palindrome = new Palindrome(); 

            Console.ReadKey();
        }
    }
}
