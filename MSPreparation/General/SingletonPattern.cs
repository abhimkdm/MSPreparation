using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSPreparation.General
{
    //The singleton pattern returns the single instance of object.
    public sealed class SingletonPattern
    {
        private static SingletonPattern _instance=null;
        private static object threadSafe = new object();

        private SingletonPattern() { }

        public static SingletonPattern Instance
        {
            get
            {
                if (_instance == null)
                {
                    // To make thread safe 
                    lock(threadSafe)
                    {
                        // check again as multiple threads 
                        // can reach above step 
                        if (_instance == null)
                            _instance = new SingletonPattern();
                    }
                }
                return _instance;
            }
        }
    }
}
