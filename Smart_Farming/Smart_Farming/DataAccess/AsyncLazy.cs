using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;// allows the use of the TaskAwaiter 
using System.Text;
using System.Threading.Tasks; // allows the use of the Lazy and AsyncLazy

namespace Smart_Farming.DataAccess
{
    public class AsyncLazy<T>
    {
        readonly Lazy<Task<T>> instance;

        public AsyncLazy(Func<T> factory)
        {
            instance = new Lazy<Task<T>>(() => Task.Run(factory));
        }

        public AsyncLazy(Func<Task<T>> factory)
        {
            instance = new Lazy<Task<T>>(() => Task.Run(factory));
        }

        public TaskAwaiter<T> GetAwaiter()
        {
            return instance.Value.GetAwaiter();
        }
    }
}
