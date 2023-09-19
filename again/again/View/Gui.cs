using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace again.View
{

    // The Gui class is responsible for displaying information about animals.
    internal class Gui
    {
        // PrintAnimal method is used to display information about an animal.
        // It takes the species, type, and age of the animal as parameters.
        internal void PrintAnimal(string species, string type, int age)
        {
            Console.WriteLine("Outgoing animal"); // Display a label indicating it's an outgoing animal.
            Console.WriteLine($"Species: {species}, Type: {type}, Age :{age}"); // Display animal details.
        }
    }
}
