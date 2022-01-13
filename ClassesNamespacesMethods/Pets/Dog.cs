using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesNamespacesMethods.Pets
{
    //4 Pillars of Object Oriented Programming (OOP)
    //Abstraction, Polymorphism, Inheritance, **Encapsulation** (APIE)

    //internal is similar to private but it limits to only this project seeing it.
    //other access modifiers are: public (allows access from anywhere), sealed (limited inheritance allowed), abstract (only another class can inherit from this), private (rarely used)
    internal class Dog
    {
        //properties - TitleCase
        //auto property - has a plain getter/setter
        //Properties are private by default but can also be: public, readonly
        //class is a custom type thus "Dog" is now a type.
        //any custom property or type we add must be defined by us.

        //access modifier   type    name    getter & setter
        public string FurType { get; set; }
        public string Name { get; set; }
        public string Breed { get; set; }
        public double Weight { get; set; }
        public DateTime DateOfBirth { get; private set; }
        //calculated property
        public int Age
        {
            get
            {
                return (DateTime.Now - DateOfBirth).Days / 365;
            }
        }

        //Fields - for private values needed by the class, but not needed outside the class
        //does not require a git or set
        //access modifier of private, a type, and a name
        //name start with an "_" then it is camel case
        private bool _isFertile;

        //methods - TitleCase
        //access modifier   return type     name    code
        public void Bark()
        {
            Console.WriteLine($"{Name} barks loudly.");
        }

        public void SetDateOfBirth(DateTime dob)
        {
            DateOfBirth = dob;
        }

        public int GiveBirth()
        {
            //if this does not use any properties or fields in the class, we can make this method "static" prior to the int
            //static method is used across ALL instances and as such, you do not need to create an instance.
            int numOfPuppies = new Random().Next();
            if (_isFertile)
            {
                return numOfPuppies;
            }
            else
            {
                return 0;
            }
        }
    }
}
