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
        
        static void Main(string[] args)
        {
            Hero hero = new Hero();
            int x = 0;
            Console.WriteLine("Выберите действие:\n1.Выберите класс вашего героя \n2.Выберите расу вашего класса\n3.Выберите пол\n4.Введите имя\n5.Выйти\n");
            while (x != 5)
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
                        Console.WriteLine("Выберите класс:\n1.Воин \n2.Лучник\n3.Друил\n4.Некромант\n5.Маг\n");
                        hero.Set_param(new ChooseClass());
                        break;
                    case 2:
                        Console.WriteLine("Выберите расу:\n1.Кентавр \n2.Человек\n3.Эльф\n4.Хоббит\n5.Орк\n6.Гном\n");
                        hero.Set_param(new ChooseRace());
                        break;
                    case 3:
                        Console.WriteLine("Выберите пол:\n1.Мужчина \n2.Женщина\n");
                        hero.Set_param(new ChooseGender());
                        break;
                    case 4:
                        hero.set_name(Console.ReadLine());
                        break;
                    default:
                        break;
                }
            }
            x = 0;
            Console.WriteLine("Выберите действие:\n1.Взять одноручный мед \n2.Взять двуручный меч\n3.Взять топор\n4.Взять копье\n5.Взять лук\n6.Выйти\n");
            while (x!=6)
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

        }
    }
}
