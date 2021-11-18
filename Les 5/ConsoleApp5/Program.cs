using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player(340);
            
            Money money = new Money(13);

            HealPotion healPotion = new HealPotion(35);

            Console.WriteLine("U got Money: " + player1.p1Money);
            Console.WriteLine("u got Health: " + player1.p1Health);
        }

        public class Player
        {
            private int startingHealth;

            public int p1Money = 0;
            public int p1Health = 0;

            public Player(int startingHealth)
            {
                this.startingHealth = startingHealth;
                p1Health = startingHealth;
            }

            public void AddMoney(int amount)
            {
                p1Money += amount;
            }

            public void AddHealth(int amount)
            {
                p1Health += amount;
                if (p1Health > startingHealth) p1Health = startingHealth;
            }
        }

        public abstract class Equipment
        {
            public virtual void Equip()
            {
                Console.WriteLine("Item equipped");
            }
        }


        public class Armor : Equipment
        {
            public override void Equip()
            {
                base.Equip();
            }
        }

        public class Weapon : Equipment
        {
            public override void Equip()
            {
                base.Equip();
            }
        }

        public class Money
        {
            public int p1Money;

            public Money(int money)
            {
                this.p1Money = money;
            }
        }

        public class HealPotion
        {
            public int heal;

            public HealPotion(int heal)
            {
                this.heal = heal;
            }
        }
    }
}