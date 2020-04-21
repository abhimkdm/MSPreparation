using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSPreparation.Programs
{
    public static class ArmStrongNumber
    {
        public static void FindArmStrongNumber()
        {
            //Take the input
            Console.Write("Enter the Number : ");
            int number = int.Parse(Console.ReadLine());
            
            //Check whether it is prime number or not
            if (IsArmStrongNumber(number)){
                Console.WriteLine($"The Number {number} is armstrong");
            }
            else{
                Console.WriteLine($"The Number {number} is not armstrong");
            }
            Console.ReadLine();

        }


        /// <summary>
        /// Logic
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        private static bool IsArmStrongNumber(int num) {
            int tempNumber = num;
            int lenNum = num.ToString().Length; // Helps to cal pow
            int reminder;
            int sum=0;

            while (num >0)
            {
                reminder = num % 10;
                num = num / 10;
                sum += (int)Math.Pow(reminder, lenNum); // Eg. Pow(3,len)
            }
            return sum==tempNumber? true: false;
        }

    }
}
