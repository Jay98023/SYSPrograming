using System;

namespace ConsoleApp1
{
    class Program
    {
        private class Enemy
        {
            public int enemyHealth = 500;

            public Enemy(int _enemyHealth)
            {
                enemyHealth = _enemyHealth;
            }

            public void TakeDamage(int damage)
            {
                if (enemyHealth > 0)
                {
                    enemyHealth -= damage;
                    if (enemyHealth <= 0)
                    {
                        Console.WriteLine("U DIED!!");
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            Enemy enemy = new Enemy(1);

            Random rnd = new Random();

            while (1 == 1)
            {
                enemy.TakeDamage(rnd.Next(50, 300));

                Console.WriteLine("Enemy health: " + enemy.enemyHealth);

                if (enemy.enemyHealth <= 0)
                {
                    break;
                }
            }
        }
    }
}