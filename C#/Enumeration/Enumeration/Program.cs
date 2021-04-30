using System;

namespace Enumeration
{
    enum pickupType {health, invulnerability, score, speedboost}
    class player
    {
        public int health = 100;
        public int score = 0;
        public int speed = 5;
        public bool invulnerable = false;
    }
    class Program
    {
        static player p1 = new player();

        static void getPickup(pickupType typeJustPickedUp)
        {
            switch (typeJustPickedUp)
            {
                case pickupType.health:
                    p1.health += 10;
                    Console.WriteLine("Health is now: " + p1.health);
                    break;
                case pickupType.invulnerability:
                    p1.invulnerable = true;
                    Console.WriteLine("Player is invulnerable!");
                    break;
                case pickupType.score:
                    p1.score += 10;
                    Console.WriteLine("Picked up 10 points! Score: " + p1.score);
                    break;
                case pickupType.speedboost:
                    p1.speed += 5;
                    Console.WriteLine("Zoooooom, player is speed is now " + p1.speed);
                    break;
            }
        }

        static void Main(string[] args)
        {
            getPickup(pickupType.health);
            getPickup(pickupType.health);
            getPickup(pickupType.health);
            getPickup(pickupType.invulnerability);
            getPickup(pickupType.speedboost);
            getPickup(pickupType.speedboost);
            Console.ReadLine();
        }
    }
}
