using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Hero
{
    public interface IChooseCharactercs
    {
        Object choose_something();
    }
    public class ChooseRace : IChooseCharactercs
    {
        public Object choose_something()
        {
            int x=0;
            try
            {
                x = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                return choose_something();
            }
            switch (x)
            {
                case 1:
                    return ARacesHeroes.Centaur;
                case 2:
                    return ARacesHeroes.Human;
                case 3:
                    return ARacesHeroes.Elf;
                case 4:
                    return ARacesHeroes.Hobbit;
                case 5:
                    return ARacesHeroes.Orc;
                case 6:
                    return ARacesHeroes.Dwarf;
                default:
                    return choose_something();

            }

        }
    }
    public class ChooseClass : IChooseCharactercs
    {
        public Object choose_something()
        {
            int x=0;
            try
            {
                x = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                return choose_something();
            }
            switch (x)
            {
                case 1:
                    return AClassesHeroes.Warrior;
                case 2:
                    return AClassesHeroes.Archer;
                case 3:
                    return AClassesHeroes.Druid;
                case 4:
                    return AClassesHeroes.Hecromancer;
                case 5:
                    return AClassesHeroes.Mage;
                default:
                    return choose_something();

            }
        }
    }

    public class ChooseGender:IChooseCharactercs
    {
        public Object choose_something()
        {
            int x=0;
            try
            {
                x = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                return choose_something();
            }
            switch (x)
            {
                case 1:
                    return Gender.Male;
                case 2:
                    return Gender.Female;
                default:
                    return choose_something();
            }
        }




    }
}