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
            
            Flat flat2 = new Flat(1, 250, 3);
            Console.WriteLine(flat2.ToString());

            Person miro = new Person("Miro", "Silný", 20);            
            flat1.AddHabitant(miro);
            
            Person stefan = new Person("Štefan", "Chudý", 25);
            flat1.AddHabitant(stefan);

            Console.WriteLine(flat1.GetInfoAboutAllHabitants());
            Console.WriteLine(miro.GetInfoAboutFlat());
            
            
        }
    }
}
