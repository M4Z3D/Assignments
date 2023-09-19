using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Model
{
    public class Animal
    {

        private string _species;
        private string _type;
        private int _age;
        // Create a stack with all the animals in it
        private Stack<Animal> _animals = new Stack<Animal>();

        public Animal(string Species, string Type, int Age)
        {
            _species = Species;
            _type = Type;
            _age = Age;
        }
        public override string ToString()
        {
            return $"{Species}, {Type},{Age} years old";
        }
        // Fill the private properties with data
        public string Species
        {
            get { return _species; }
            set { _species = value; }
        }
        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public Stack<Animal> Animals
        {
            get { return _animals; }
            set { _animals = value; }
        }
        public Animal()
        {
            // Fills the stack with animals
            Animal animal1 = new Animal("Horse", "Mammal", 9);
            Animal animal2 = new Animal("Pig", "Mammal", 7);
            Animal animal3 = new Animal("Lion", "Mammal", 2);
            Animal animal4 = new Animal("Snake", "reptile", 6);
            Animal animal5 = new Animal("Cow", "Mammal", 8);



            // Creates a list of all the animals to have them viewed in the future (not in use)

            List<Animal> animals = new List<Animal>()
            {
                animal1, animal2, animal3, animal4, animal5
            };
        }
    }
}

