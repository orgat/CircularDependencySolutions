using System;
using System.Collections.Generic;
using System.Text;

namespace WithInterface
{
    public class A : IFriendCaller
    {
        public void Run()
        {
            var b = new B();
            b.MakeCoffee(this);
        }

        public void CallFriends()
        {
            Console.WriteLine("Calling friends...");
        }
    }
}
