using System;

namespace OOPNarozeniny
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Zadej datum narození: ");
            DateTime datumNarozeni = DateTime.Parse(Console.ReadLine());
            TimeSpan vek = DateTime.Today - datumNarozeni;
            DateTime dalsiNarozeniny = new DateTime(DateTime.Today.AddYears(1).Year, datumNarozeni.Month, datumNarozeni.Day);
            TimeSpan index = dalsiNarozeniny - DateTime.Today;
           
            Console.WriteLine("Je ti {0} let a narozeniny máš za {1} dní.", Math.Floor(vek.Days/365.255), index.TotalDays);
            Console.ReadKey();
        }
    }
}
