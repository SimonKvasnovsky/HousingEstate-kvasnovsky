using System;
using System.Collections.Generic;
using System.Text;

namespace HousingEstate
{
    class Flat
    {
        private int flatNumber;
        private int areaOfFlat;
        private int numberOfRooms;
        public int FlatNumber
        {
            get { return flatNumber; }
            set { flatNumber = value; }
        }
        public int AreaOfFlat
        {
            get { return areaOfFlat; }
            set { areaOfFlat = value; }
        }
        public int NumberOfRooms
        {
            get { return numberOfRooms; }
            set { numberOfRooms = value; }
        }
        List<Person> person = new List<Person>();
        public Flat(int FlatNumber1, int AreaOfFlat1, int NumberOfRooms1)
        {
            flatNumber = FlatNumber1;
            areaOfFlat = AreaOfFlat1;
            numberOfRooms = NumberOfRooms1;

            person = new List<Person>
            {
                new Person("Jozef", "Mrkvička", 22),
                new Person("Miro", "Silný", 20),
                new Person("Štefan", "Chudý", 25)

        };
        }
        
        public void AddHabitant(Person habitant)
        {
            Console.WriteLine(habitant);
        }
        public string GetInfoAboutAllHabitants()
        {
            {
                string x = "";
                foreach (Person o in person)
                {
                    x += o.ToString();
                    x += "\n";
                }
                return x;
            }
        }
        public override string ToString()
        {
            return String.Format($"{flatNumber}\n{areaOfFlat}\n{numberOfRooms}\n");
        }


    }
}
