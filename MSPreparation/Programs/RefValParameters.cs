using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSPreparation.Programs
{
   public class RefValParameters
    {
        public void RefVal() {
            int arg = 10;

            PassByVal(arg);
            Console.WriteLine("PassByVal " + arg);

            PassByRef(ref arg);
            Console.WriteLine("PassByRef " + arg);
        }

        private void PassByRef(ref int arg)
        {
            arg = 100;
        }

        private void PassByVal(int arg)
        {
            arg = 50;
        }
    }
}
