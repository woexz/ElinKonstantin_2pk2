namespace thebestgameintheworld
{
    internal class Program
    {
        static char ending_fight = 'w';
        static int money = 0;
        static int playerHp = 100;
        static int playerDamage = 10;
        static int maxHp = 100;
        static Random rnd = new Random();
        static string[] name_of_mobs = { "Волк", "Паук", "Змей", "Зомби", "Страж", "Охотник" };
        static Tuple<int, int> Choose_where_to_go(int current_position_x, int current_position_y, int[,] map)
        {
            while (true)
            {
                Console.Write("Введите направление, куда нам двигаться дальше:(вводить цифру)\n" +
                    "1. Север\n" +
                    "2. Восток\n" +
                    "3. Запад\n" +
                    "4. Юг\n");
                string direction = Console.ReadLine();
                if (direction == "1" || direction == "2" || direction == "3" || direction == "4")
                {
                    //for (int y = 4; y >= 0; y--)
                    //{
                    //    for (int x = 0; x < 5; x++)
                    //    {
                    //        Console.Write(map[x, y]);
                    //    }
                    //    Console.WriteLine();
                    //}
                    //Console.WriteLine(map[current_position_x, current_position_y]);
                    if (direction == "1" && current_position_y < 4 && map[current_position_x, current_position_y + 1] != 0)
                    {
                        current_position_y++;
                        Console.WriteLine("Вы продвинулись на север...");
                        break;
                    }
                    else if (direction == "2" && current_position_x < 4 && map[current_position_x + 1, current_position_y] != 0)
                    {
                        current_position_x++;
                        Console.WriteLine("Вы продвинулись на восток...");
                        break;
                    }
                    else if (direction == "3" && current_position_x > 0 && map[current_position_x - 1, current_position_y] != 0)
                    {
                        current_position_x--;
                        Console.WriteLine("Вы продвинулись на запад...");
                        break;
                    }
                    else if (direction == "4" && current_position_y > 0 && map[current_position_x, current_position_y - 1] != 0)
                    {
                        current_position_y--;
                        Console.WriteLine("Вы продвинулись на юг...");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Дальше тупик, прохода нет. Стоит выбрать другое направление");
                    }
                }
                else
                {
                    Console.WriteLine("Проверьте корректность ввода направления");
                }
            }
            return Tuple.Create(current_position_x, current_position_y);
        }


        static int Fight_room(string playerName, string enemyName, int enemyHp, int enemyDamage)
        {
            int timeDamage;
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
                            timeDamage = rnd.Next(playerDamage / 2, playerDamage);
                            enemyHp -= timeDamage;
                            enemyHp = enemyHp < 0 ? (0) : (enemyHp);
                            Console.WriteLine($"Вы нанесли врагу {timeDamage} урона. \n" +
                                $"Здоровье врага: {enemyHp} единиц.");
                            if (enemyHp <= 0)
                            {
                                flag = false;
                                int reward = rnd.Next(1, 2);
                                ending_fight = 'w';
                                Console.WriteLine($"Вы убили врага и получили {reward} шардс");
                                money += reward;
                            }
                            actionFlag = false;
                            break;
                        case "2":
                            Console.WriteLine("Вы убежали. Бой окончен.");
                            actionFlag = false; flag = false;
                            ending_fight = 'r';
                            break;
                        default:
                            Console.WriteLine("Неизвестная команда.");
                            break;
                    }
                }
                if (flag)
                {
                    Console.WriteLine("Теперь ход врага.");
                    int actionEnemy = rnd.Next(1, 5);
                    switch (actionEnemy)
                    {
                        case 1:
                            Console.WriteLine("Враг промазал.");
                            break;

                        default:
                            timeDamage = rnd.Next(1, enemyDamage);
                            playerHp -= timeDamage;
                            playerHp = playerHp < 0 ? (0) : (playerHp);
                            Console.WriteLine($"{enemyName} нанес вам {timeDamage} урона. \n" +
                                $"Ваше здоровье: {playerHp} единиц.");
                            if (playerHp <= 0)
                            {
                                flag = false;
                                ending_fight = 'd';
                                Console.WriteLine("Вы умерли.");
                            }
                            else
                            {
                                Console.WriteLine($"1. Удар \n" +
                                $"2. Убежать");
                            }
                            break;
                    }
                }

            }
            return playerHp;
        }


        static void Chest_room(string playerName)
        {
            int mimik_damage = 25;
            bool flag = true; 
           
            int chance = rnd.Next(0, 10);
            while (flag)
            {
                Console.WriteLine($"Вы видите сундук, который светится изнутри и манит вас его открыть. Что вы собираетесь делать. \n" +
               $"1. Открыть сундук \n" +
               $"2. Сомневаться \n" +
               $"3. Пройти мимо \n");

                string action = Console.ReadLine();
                int first_mimik_damage = 25;
                switch (action)
                {
                    case "1":
                        Console.WriteLine("Вы подходите к сундуку, пытаетесь его открыть.");
                        if (chance < 3)
                        {
                            if (playerHp < 5)
                                Console.WriteLine("Приносим глубочайшие соболезнования...(0_0)");

                            Console.WriteLine($"Рука из сундука крепко схватила вас за горло, и нанес {first_mimik_damage} урона.");
                            
                            playerHp -= mimik_damage;
                            Console.WriteLine($"Ваше здоровье {playerHp} единиц");
                            playerHp = Fight_room(playerName, "Мимик", 50, 10);
                            Console.WriteLine($"Эссенция жизни мимика покидает его тело и вселяется в вас.\n" +
                                $"Ваше здоровье восстановлено на 50 единиц.");
                            playerHp = playerHp + 50 > maxHp ? (maxHp) : (playerHp);
                            flag = false;
                        }
                        else if (chance >= 3 && chance <= 6)
                        {
                            Console.WriteLine($"Вы нашли старые пыльные бинты, ваше здоровье востановилось на 30 единиц.");
                            playerHp = playerHp + 30 > maxHp ? (maxHp) : (playerHp);
                            flag = false;
                        }
                        else
                        {
                            Console.WriteLine($"В сундуке вы находите затупленный железный меч. Все лучше чем ничего.\n" +
                                $"Ваш урон увеличился на 5 единиц.");
                            playerDamage += 5;
                            flag = false;
                        }
                        break;

                    case "2":
                        Console.WriteLine("Вы чуете что то неладное... Медлить, пожалуй, не стоит...");
                        first_mimik_damage += 5;
                        break;

                    case "3":
                        Console.WriteLine("Вы проходите мимо сундука, и слышите какой то странный звук, однако вам до него нет дела.");
                        flag = false;
                        break;

                    default:
                        break;
                }
            }
            
        }


        static void Merchant_room(string playerName, ref int playerHp, ref int playerDamage, ref int maxHp, ref int money)
        {
            bool merchant_flag = true;
            while (merchant_flag)
            {
                Console.WriteLine("После дальнейших похождений вы услышали скрежет колёс вдалеке. Через некоторое время, вы заметили телегу, запряженную тройкой лошадей.\n" +
                "Что вы будете делать?\n" +
                "1. Поговорить с торговцем\n" +
                "2. Пройти мимо");
                string action = Console.ReadLine();
                switch (action)
                {
                    case "1":
                        bool dialog_flag = true;
                        while (dialog_flag)
                        {
                            Console.WriteLine("После недолгого разговора, он предложил вам поторговаться. Вы можете также расспросить его о чём-либо.\n" +
                           "Что вы будете делать?\n" +
                           "1. Поторговать\n" +
                           "2. Спросить\n" +
                           "3. Закончить разговор");
                            string dialogue_action = Console.ReadLine();
                            switch (dialogue_action)
                            {
                                case "1":
                                    bool buy_flag = true;
                                    while (buy_flag)
                                    {
                                        Console.WriteLine("Блуждающий торговец представил вам его ассортимент:\n" +
                                            $"Ваш баланс: {money} шардс\n" +
                                        "1. Поношенная куртка из кожи пещерного Змея (+5 постоянных хп) - 1 шардс\n" +
                                        "2. Зелье здоровья (полное восстановления вашего запаса хп) - 1 шардс\n" +
                                        "3. Ржавый охотничий кинжал (+3 урона игрока) - 1 шардс\n" +
                                        "4. Ничего не покупать");
                                        string buy_action = Console.ReadLine();
                                        switch (buy_action)
                                        {
                                            case "1":
                                                if (money >= 1)
                                                {
                                                    maxHp += 5;
                                                    Console.WriteLine($"Вы надели поношенную куртку из кожи пещерного Змея. Ваше максимальное здооровье: {maxHp} единиц");
                                                    money -= 1;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("У вас недостаточно денег");
                                                }
                                                break;
                                            case "2":
                                                if (money >= 1)
                                                {
                                                    playerHp = maxHp;
                                                    Console.WriteLine($"Вы востанавлиеваете все свое здоровьею. Ваше здоровье {playerHp}");
                                                    money -= 1;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("У вас недостаточно денег");
                                                }
                                                break;

                                            case "3":
                                                if (money >= 1)
                                                {
                                                    playerDamage += 3;
                                                    Console.WriteLine($"Вы повесили кинжал на пояс. Ваш урон: {playerDamage} единиц");
                                                    money -= 1;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("У вас недостаточно денег");
                                                }
                                                break;

                                            case "4":
                                                Console.WriteLine("Вы закончили торговать");
                                                buy_flag = false;
                                                break;

                                            default:
                                                Console.WriteLine("Неизвестная команда");
                                                break;
                                        }

                                    }
                                    break;

                                case "2":
                                    Console.WriteLine("Рассказал о мире");
                                    break;

                                case "3":
                                    Console.WriteLine("Вы отходите от торговца");
                                    dialog_flag = false;
                                    break;

                                default:
                                    Console.WriteLine("Неизвестная команда");
                                    break;
                            }
                        }
                        break;

                    case "2":
                        Console.WriteLine("Вы проигнорировали торговца и пошли дальше.");
                        merchant_flag = false;
                        break;
                    default:
                        Console.WriteLine("Неизвестная команда");
                        break;
                }
            }
        }


        static void Boss_room(string playerName)
        {
            Console.WriteLine("Мирно шагая по дороге к северу, вы услышали громкий звук, издавшийся перед вами. Интерес сильнее страха, поэтому вы решаете проверить что там произошло.\n" +
                "...Просто так такой звук появиться не мог... Вы видите перед собой огромный силуэт, который настроен к вам явно не дружелюбно. Придётся драться...");
            Fight_room(playerName, "Грозный Орк", 150, 15);
            if (ending_fight == 'w')
            {
                Console.WriteLine("Вы наносите смертельный удар и существо падает. Вы видите на его шее сверкаюший амулет. Надев его, вы ощущаете прилив сил.\n" +
                    "Максимальное здоровье увеличено на 10 единиц\n" +
                    "Урон увеличен на 5 единиц\n" +
                    "Ваше здоровье полностью восстановлено");
                maxHp += 10;
                playerDamage += 5;
                playerHp = maxHp;
            }
            else if (ending_fight == 'r')
            {
                Console.WriteLine("Вы едва унесли ноги... ");
            }
        }

        static void Main(string[] args)
        {
            Random random = new Random();
            int count_of_games = 0;
            Console.Write("Игра в жанре ЛитРПГ, с большой картой, монстрами и захватывающим геймплеем!!!");
            Console.WriteLine("Если желаете начать игру, введите команду start");
            while (true)
            {
                if (count_of_games > 0)
                {
                    break;
                }
                else
                {
                    string start_command = Console.ReadLine();
                    if (start_command == "start")
                    {
                        bool win_flag = false;
                        int[,] map = new int[5, 5];
                        for (int x = 0; x < 5; x++)
                        {
                            for (int y = 4; y >= 0; y--)
                            {
                                if (x == 2)
                                {
                                    map[x, y] = y + 1;
                                }
                                else
                                {
                                    map[x, y] = 0;
                                }
                            }
                        }
                        int current_position_x = 2;
                        int current_position_y = 0;
                        Console.Write("Вы проснулись в пещере и плохо помните, что с вами происходило ранее.\n" +
                            "В попытках вспомнить свое имя, у вас заболела голова.\nВведите свое имя: ");
                        string playerName = Console.ReadLine();
                        Console.WriteLine("Вы можете осмотреться рядом или начать путь:\n" +
                            "1. Осмотреться\n" +
                            "2. Начать путь");
                        while (win_flag == false)
                        {
                            if (map[current_position_x, current_position_y] == 1)
                            {
                                while (true)
                                {
                                    string start_action = Console.ReadLine();
                                    if (start_action == "1")
                                    {
                                        Console.WriteLine("После недолгих поисков вы обнаружили какой-то блокнот. Вы сразу же открываете его и начинаете читать, пытаясь обнаружить хоть какую-то информацию. Этот блокнот оказался " +
                                            "собственностью местных исследователей, на 27 странице которого вы прочли, что они направляются на север. Также вы немного узнали о местной валюте, которая называется шардс.");
                                        Console.WriteLine("Может вам стоит пойти по их следам?");
                                        Tuple<int, int> tuple = Choose_where_to_go(current_position_x, current_position_y, map);
                                        current_position_x = tuple.Item1;
                                        current_position_y = tuple.Item2;
                                        break;
                                    }
                                    else if (start_action == "2")
                                    {
                                        Tuple<int, int> tuplee = Choose_where_to_go(current_position_x, current_position_y, map);
                                        current_position_x = tuplee.Item1;
                                        current_position_y = tuplee.Item2;
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Проверьте корректность ввода команды");
                                    }
                                }
                            }
                            else if (map[current_position_x, current_position_y] == 2)
                            {
                                playerHp = Fight_room(playerName, name_of_mobs[new Random().Next(0, name_of_mobs.Length)], random.Next(15, 30), random.Next(9, 12));
                                if(ending_fight == 'w')
                                {
                                    map[current_position_x, current_position_y] = 9;
                                    Console.WriteLine($"Ваше оставшееся здоровье: {playerHp}");
                                    Tuple<int, int> tuple = Choose_where_to_go(current_position_x, current_position_y, map);
                                    current_position_x = tuple.Item1;
                                    current_position_y = tuple.Item2;
                                }
                                else if(ending_fight == 'r')
                                {
                                    Console.WriteLine($"Ваше оставшееся здоровье: {playerHp}");
                                    Tuple<int, int> tuple = Choose_where_to_go(current_position_x, current_position_y, map);
                                    current_position_x = tuple.Item1;
                                    current_position_y = tuple.Item2;
                                }
                            }
                            else if (map[current_position_x, current_position_y] == 3)
                            {
                                Chest_room(playerName);
                                Tuple<int, int> tuple = Choose_where_to_go(current_position_x, current_position_y, map);
                                current_position_x = tuple.Item1;
                                current_position_y = tuple.Item2;
                            }
                            else if (map[current_position_x, current_position_y] == 4)
                            {
                                Merchant_room(playerName, ref playerHp, ref playerDamage, ref maxHp, ref money);
                                Tuple<int, int> tuple = Choose_where_to_go(current_position_x, current_position_y, map);
                                current_position_x = tuple.Item1;
                                current_position_y = tuple.Item2;
                            }
                            else if (map[current_position_x, current_position_y] == 5)
                            {
                                Boss_room(playerName);
                                Console.WriteLine("Вы ненадолго сели передохнуть после тяжелой схватки и продолжаете свой путь...");
                                Console.WriteLine("Игра окончена!!!");
                                win_flag = true;
                                count_of_games++;
                            }
                            else if (map[current_position_x, current_position_y] == 9)
                            {
                                Console.WriteLine("Кажется, здесь вы уже были...");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Неизвестная команда, проверьте корректность ввода");
                    }
                }
            }

            Console.ReadKey();   
        }
        
    }
}