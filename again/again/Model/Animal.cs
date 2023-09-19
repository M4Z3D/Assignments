using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace again.Model

{
    // The Animal class represents an animal with properties like species, type, and age.
    public class Animal
    {
        private string _species; // Field to store the species of the animal
        private string _type;    // Field to store the type of the animal
        private int _age;        // Field to store the age of the animal

        // Constructor to initialize an instance of the Animal class with species, type, and age.
        public Animal(string Species, string Type, int Age)
        {
            _species = Species;
            _type = Type;
            _age = Age;
        }

        // Override the ToString() method to provide a formatted string representation of the animal.
        public override string ToString()
        {
            return $"{Species}, {Type}, {Age} years old";
        }

        // Property to get the species of the animal (read-only).
        public string Species
        {
            get { return _species; }
            private set { _species = value; }
        }

        // Property to get the type of the animal (read-only).
        public string Type
        {
            get { return _type; }
            private set { _type = value; }
        }

        // Property to get the age of the animal (read-only).
        public int Age
        {
            get { return _age; }
            private set { _age = value; }
        }
    }
}