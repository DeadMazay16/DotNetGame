using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;

namespace DotNetGame
{
    public static class Core
    {
        public static void out_message(string msg)
        {
            Console.WriteLine(msg);
        }
        
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, world!");
            World world = new World(100, 100);
            world.init();
        }
    }
}