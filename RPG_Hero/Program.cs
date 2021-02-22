using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Hero
{
    class Program
    {
        static public void take_weapon(ITakeWeapon take)
        {
            take.Equip_weapon();
        }
        static Hero process_create_hero()
        {
            int x = 0;
            Hero hero = new Hero();
            int[] checked_pos = new int[4];
            while (x != 5)
            {
                Console.WriteLine("Выберите действие:\n1.Выберите класс вашего героя \n2.Выберите расу вашего класса\n3.Выберите пол\n4.Введите имя\n5.Выйти\n");
                try
                {
                    x = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    continue;
                }
                switch (x)
                {
                    case 1:
                        Console.WriteLine("Выберите класс:\n1.Воин \n2.Лучник\n3.Друил\n4.Некромант\n5.Маг\n");
                        hero.Set_param(new ChooseClass());
                        checked_pos[0] = 1;
                        break;
                    case 2:
                        Console.WriteLine("Выберите расу:\n1.Кентавр \n2.Человек\n3.Эльф\n4.Хоббит\n5.Орк\n6.Гном\n");
                        hero.Set_param(new ChooseRace());
                        checked_pos[1] = 2;
                        break;
                    case 3:
                        Console.WriteLine("Выберите пол:\n1.Мужчина \n2.Женщина\n");
                        hero.Set_param(new ChooseGender());
                        checked_pos[2] = 3;
                        break;
                    case 4:
                        hero.set_name(Console.ReadLine());
                        checked_pos[3] = 4;
                        break;
                    default:
                        if(x==5)
                        {
                            int res = 1 + 2 + 3 + 4;
                            for(int i=0;i<checked_pos.Length;i++)
                            {
                                res -= checked_pos[i];
                            }
                            if (res == 0)
                                break;
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Вы не ввели все необходимые данные для вашего персонажа\n");
                                x = 4;
                            }
                        }
                        continue;
                }
                Console.Clear();
               
            }
            x = 0;
            Console.WriteLine("Выберите действие:\n1.Взять одноручный мед \n2.Взять двуручный меч\n3.Взять топор\n4.Взять копье\n5.Взять лук\n6.Выйти\n");
            while (x != 6)
            {
                try
                {
                    x = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    continue;
                }
                switch (x)
                {
                    case 1:
                        take_weapon(new TakeOneHandedSword());
                        break;
                    case 2:
                        take_weapon(new TakeTwoHandedSword());
                        break;
                    case 3:
                        take_weapon(new TakeAxe());
                        break;
                    case 4:
                        take_weapon(new TakeSpear());
                        break;
                    case 5:
                        take_weapon(new TakeBow());
                        break;
                    default:
                        break;
                }

            }
            Console.Clear();
            return hero;

        }

        static void Main(string[] args)
        {
            Dictionary<int, Hero> dictionary = new Dictionary<int, Hero>();
            int x = 0;
            int count = 0;
            while (x != 3)
            {
               
                Console.WriteLine("Выберите действие:\n1.Создать нового героя \n2.Просмотреть существующих героев\n3.Выйти\n");
                try
                {
                    x = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка!Некорректно введен запрос\n");
                    continue;
                }
                Console.Clear();
                switch (x)
                {
                    case 1:
                        Hero hero=process_create_hero();
                        dictionary.Add(count++, hero);
                        break;
                    case 2:
                        if (dictionary.Count() == 0)
                        {
                            Console.WriteLine("У вас еще нету персонажа\n");
                        }
                        else
                        {
                            for (int i = 0; i < dictionary.Count(); i++)
                            {
                                Console.WriteLine("Номер персонажа:" + i + dictionary[i].get_info() + "\n");
                            }
                        }
                        break;
                    case 3:
                        break;
                    default:
                        Console.WriteLine("Ошибка!Некорректно введен запрос\n");
                        break;

                }
                
            }
          
        }
    }
}
