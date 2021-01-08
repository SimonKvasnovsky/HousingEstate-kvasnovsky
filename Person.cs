using System;
using System.Collections.Generic;
using System.Text;

namespace HousingEstate
{
    class Person
    {
        private string name;
        private string surname;
        private int age;
        public Flat currentFlat;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }        
        public Person(string Name1, string Surname1, int Age1)
        {
            name = Name1;
            surname = Surname1;
            age = Age1;
        }
        public Person() { }
        
        public string GetInfoAboutFlat()
        {
            return this.currentFlat.ToString();
        }

        public override string ToString()
        {
            return String.Format($"{name}\n{surname}\n{age}\n");
        }

    }
}
