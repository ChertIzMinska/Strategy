using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Hero
{
   public enum AClassesHeroes {Warrior,Mage, Archer ,Druid,Hecromancer};
   public enum ARacesHeroes {Orc,Dwarf,Human,Elf,Hobbit,Centaur};

   public enum Gender { Male,Female};


    public class Hero
    {
        AClassesHeroes clas;
        ARacesHeroes race;
        Gender gender;
        string Name;
        public string get_info()
        {
            return "Имя:" + Name + "Пол:"+gender+ "Раса:" +race+ "Класс:"+clas;
        }
        public void set_name(string name)
        {
            Name = name;
        }

        public Hero(string str)
        {
            Name = str;
           

        }
        public Hero()
        {

        }
        public void Set_param(IChooseCharactercs chooseCharactercs)
        {
            if (chooseCharactercs is ChooseRace)
                race = (ARacesHeroes)chooseCharactercs.choose_something();
            else if (chooseCharactercs is ChooseGender)
                gender = (Gender)chooseCharactercs.choose_something();
            else if (chooseCharactercs is ChooseClass)
                clas = (AClassesHeroes)chooseCharactercs.choose_something();
        }
        

    }
}
