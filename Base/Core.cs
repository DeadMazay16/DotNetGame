using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;

namespace DotNetGame
{
    internal class Core
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, world!");
            World world = new World(100, 100);
            world.init();
        }
    }
}