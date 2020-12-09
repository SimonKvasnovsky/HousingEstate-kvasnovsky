using System;

namespace HousingEstate
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Jozef = new Person("Jozef", "Mrkvička", 22);
            Console.WriteLine(Jozef.ToString());
            Flat flat1 = new Flat(1,250,3);
            Console.WriteLine(flat1.ToString());
            
            
        }
    }
}
