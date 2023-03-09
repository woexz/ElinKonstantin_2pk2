using System.Linq.Expressions;

namespace GAME
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите свое имя.");
            string playerName = Console.ReadLine();
            Fight(playerName, "Волк", 25, 10, 100, 10);
        }

        static void Fight(string playerName, string enemyName, int enemyHp, int enemyDamage, int playerHp, int playerDamage)
        {
            int timeDamage;
            Random rnd = new Random();
            Console.WriteLine($"{playerName}, Вы видете перед собой {enemyName} \n" +
                $"Здоровье моба: {enemyHp} \n" +
                $"Что вы будете делать? \n" +
                $"1. Удар \n" +
                $"2. Убежать");

            bool flag = true;
            while (flag)
            {             
                bool actionFlag = true;
                while (actionFlag)
                {
                    string action = Console.ReadLine();
                    switch (action)
                    {
                        case "1":
                            timeDamage = rnd.Next(1, playerDamage);
                            enemyHp -= timeDamage;
                            Console.WriteLine($"Вы нанесли врагу {timeDamage} урона. \n" +
                                $"Здоровье врага: {enemyHp} единиц.");
                            if (enemyHp <= 0)
                            {
                                flag = false;
                                Console.WriteLine("Вы убили врага.");
                            }
                            actionFlag = false;
                            break;
                        case "2":
                            Console.WriteLine("Вы убежали. Бой окончен.");
                            actionFlag = false; flag = false;
                            break;
                        default:
                            Console.WriteLine("Неизвестная команда.");
                            break;
                    }
                }
                if (flag) 
                {
                    Console.WriteLine("Теперь ход врага.");
                    int actionEnamy = rnd.Next(1,3);
                    switch (actionEnamy)
                    {
                        case 1:
                            timeDamage = rnd.Next(1, enemyDamage);
                            playerHp -= timeDamage;
                            Console.WriteLine($"{enemyName} нанес вам {timeDamage} урона. \n" +
                                $"Ваше здоровье: {playerHp} единиц.");
                            if (playerHp <= 0)
                            {
                                flag = false;
                                Console.WriteLine("Вы умерли.");
                            }
                            else 
                            {
                                Console.WriteLine($"1. Удар \n" +
                                $"2. Убежать");
                            }    
                            break;

                        case 2:
                            Console.WriteLine("Враг промазал.");
                            break;

                        default:
                            break;
                    }
                }
                
            }
            
        }
    }
}