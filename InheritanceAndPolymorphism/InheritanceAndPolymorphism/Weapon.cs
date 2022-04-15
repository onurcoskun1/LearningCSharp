using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphism
{
    public class Weapon
    {
        public string Name { get; set; }
        public int Weight { get; set; }

        public int Damage { get; set; }

        public virtual void Attack()
        {
            Console.WriteLine($"Tabanca ile saldırdı. ");
        }


    }

    public class Knife : Weapon
    {

    }

    public class Gun : Weapon
    {
        public int MaxCharger { get; set; }
        public int BulletsCount { get; set; }

        public void ChangeCharger()
        {
            Console.WriteLine($" Tabancanın şarjörü değişti.");
        }
    }

    public class Sniper : Gun
    {
        public int Distance { get; set; }

        public override void Attack()
        {
            Console.WriteLine($"Sniper ile saldırdı. "); 
        }

    }

    public class MachingeGun: Gun
    {
        public bool Zoom { get; set; }
    }

    public class ShotGun : Gun
    {
        public int SpecificProperty { get; set; }
    }
}
