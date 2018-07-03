using System;

namespace Human
{
    class Program
    {
        static void Main(string[] args)
        {
            // Human player1=new Human("player1");
            // Human player2 = new Human("player2");

            // player1.attack(player2);
            // Console.WriteLine(player2.ToString());
            // Console.WriteLine(player1.ToString());
            // player1.attack("sss");
            Wizard w1= new Wizard("gandalf");
            // Console.WriteLine(w1.ToString());
            Ninja n1 = new Ninja("Ninja1");
            // Console.WriteLine(n1.ToString());
            w1.fireBall(n1);
            // Console.WriteLine(n1.ToString());
            n1.stealth(w1);
            // Console.WriteLine(n1.ToString());
            Console.WriteLine(w1.ToString());
            Samurai s1=new Samurai("Jack");
            Console.WriteLine(s1.ToString());
            s1.death_blow(w1);
            Console.WriteLine(w1.ToString());

        }
    }
}
