using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class MySingleton
    {
        public static MySingleton _instance;
        public Guid Id { get; set; }
        private MySingleton() 
        {
            Id = Guid.NewGuid();
        }   
        public static MySingleton GetInstance()
        {
            if(_instance == null)
            {
                _instance = new MySingleton();
            }
            return _instance;
        }
    }
}
