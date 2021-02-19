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
            Console.WriteLine(" ");
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
                        hero.Set_param(new ChooseClass());
                        break;
                    case 2:
                        hero.Set_param(new ChooseRace());
                        break;
                    case 3:
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
            while(x!=5)
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
