using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonThreadSafe
{
    public class ThreadSafe
    {
        private static ThreadSafe _instance;
        private static readonly object _lock = new object();

        private ThreadSafe()
        {
            
        }

        //doble check locking
        public static ThreadSafe GetInstance()
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                        _instance = new ThreadSafe();
                }
            }
            return _instance;
        }
    }

}
