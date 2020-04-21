using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSPreparation.General
{
    #region Sealed Class
    /*
     * A sealed class cannot be inherited.
     * We can create and object of sealed class.
    */
    public sealed class SealedClass
    {

    }

    //if we derive 'ChildClass' from 'SealedClass' we will get
    //compiler error :'ChildClass': cannot derive from sealed type 'SealedClass'
    //class ChildClass : SealedClass
    //{
    //}
    #endregion

    #region Sealed Method
    public class A
    {
        public virtual void X()
        {
            Console.WriteLine("A::X()");
        }
        public virtual void Y()
        {
            Console.WriteLine("A::Y()\n");
        }
    }
    public class B : A
    {
        sealed public override void X()
        {
            Console.WriteLine("B::X()");
        }
        public override void Y()
        {
            Console.WriteLine("B::Y()\n");
        }
    }

    //This C class can not overrid X()
    //as it is sealed in B class.

    //C will use class B, same X()implementation
    //and it cannot implements it's own.

    public class C : B
    {
        //Can not override X function or else
        //compiler error : 'C.X()': cannot override inherited member
        //'B.X()' because it is sealed.
        //sealed public override void X()
        //{
        //    Console.WriteLine("B::X()");
        //}
        public override void Y()
        {
            Console.WriteLine("C::Y()");
        }

    }
    #endregion

    public class SealedExample
    {
        /*
         Output:
            A::X()
            A::Y()

            B::X()
            B::Y()

            B::X()
            C::Y()
             */
        public void SealedMethodTest() {
            //Seald Method Test
            A a = new A();
            a.X();
            a.Y();

            B b = new B();
            b.X();
            b.Y();

            C c = new C();
            c.X();
            c.Y();
        }

    }
}
