using System;

namespace AbstractClass2
{
    class Program
    {
        static void Main(string[] args)
        {
            January january = new January();
            Console.WriteLine(january.GunlerKacSaattir());
            Console.WriteLine(january.KacGundenOlusur());
            Console.WriteLine(january.YilinKacinciAyidir());
        }
    }
}
