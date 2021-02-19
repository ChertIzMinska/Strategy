using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Hero
{
     interface ITakeWeapon
    {
       void Equip_weapon();
    }
    public  class TakeOneHandedSword : ITakeWeapon
    {
        
        public void Equip_weapon()
        {
            Console.WriteLine("You take an onehanded sword");
        }
    }
    public class TakeTwoHandedSword : ITakeWeapon
    {

        public void Equip_weapon()
        {
            Console.WriteLine("You take a twohanded sword");
        }
    }

    public class TakeAxe : ITakeWeapon
    {

        public void Equip_weapon()
        {
            Console.WriteLine("You take  an axe");
        }
    }
    public class TakeSpear : ITakeWeapon
    {

        public void Equip_weapon()
        {
            Console.WriteLine("You take  a spear");
        }
    }
    public class TakeBow : ITakeWeapon
    {

        public void Equip_weapon()
        {
            Console.WriteLine("You take  a bow");
        }
    }
}
