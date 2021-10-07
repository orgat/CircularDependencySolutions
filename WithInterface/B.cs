using System;
using System.Collections.Generic;
using System.Text;

namespace WithInterface
{
    public class B
    {
        public void MakeCoffee(IFriendCaller friendCaller)
        {
            // Do something...
            Console.WriteLine("Making coffee...");

            friendCaller.CallFriends();

            // Do something...
        }
    }
}
