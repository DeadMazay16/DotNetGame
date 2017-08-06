using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using DotNetGame.Creatures;
using DotNetGame.Creatures.Hero;

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
            out_message("This shit kicked off");
            
            World world = new World(100, 100);
            world.init();
            
            var d_inv = new Inventory(100, 100);
            
            Hero hero = new Hero(world, "Vasya", 100, d_inv, 0, 0);
            
            d_inv.assignOwner(hero);
            
            hero.gotoLocation("down");

            foreach (var log in hero.getLog())
            {
                Console.WriteLine(log);
            }
            
        }
    }
}