using System;
using System.Collections.Generic;
using System.Text;

namespace WithDelegates
{
    public class A
    {
        public void Run()
        {
            var b = new B();
            b.MakeCoffee(CallFriends);
        }

        public void CallFriends() {
            Console.WriteLine("Calling friends...");
        }
    }
}
