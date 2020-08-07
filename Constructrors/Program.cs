using System;

namespace Constructrors
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Person person2 = new Person(1, "Tomasz");
            Person person3 = new Person(2, "Michał", "Ptak");
            Person person4 = new Person(3, "Adam", "Kot", "Szczecin", 22, "Male");

        }
    }
}
