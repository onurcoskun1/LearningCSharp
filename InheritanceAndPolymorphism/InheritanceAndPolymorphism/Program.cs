using System;

namespace InheritanceAndPolymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Nesneler genel kavramlarından özelleşerek ilerleyebilirler "Bilgisayar => Mac" gibi

            Player player = new Player();
            player.Weapon = new Knife();
            player.Weapon = new Sniper();

            player.Weapon.Attack();

            Cooker cooker = new Cooker();

            Kofte kofte = new Kofte();
            KuruFasulye kuruFasulye = new KuruFasulye();

            cooker.Cook(kofte);
            cooker.Cook(kuruFasulye);

        }
    }
}
