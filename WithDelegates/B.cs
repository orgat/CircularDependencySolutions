using System;
using System.Collections.Generic;
using System.Text;

namespace WithDelegates
{
    public class B
    {
        public void MakeCoffee(Action callback)
        {
            // Do something...
            Console.WriteLine("Making coffee...");
            if(callback != null)
            {
                callback();
            }

            // Do something...
        }
    }
}
