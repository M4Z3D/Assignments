using again.Model;
using again.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace again.Controller
{
    internal class Controller

    {


        Stack<Animal> inCommingAnimals; // Stack to hold incoming animals
        Queue<Animal> outGoingAnimals; // Queue to hold outgoing animals
        Gui gui; // Reference to the GUI class

        internal Controller()
        {
            inCommingAnimals = new Stack<Animal>(); // Initialize the incoming animals stack
            outGoingAnimals = new Queue<Animal>(); // Initialize the outgoing animals queue
            gui = new Gui(); // Initialize the GUI
        }

        internal void AddAnimal()
        {
            // Add sample animals to the incoming stack
            inCommingAnimals.Push(new Animal("lion", "mammal", 4));
            inCommingAnimals.Push(new Animal("pig", "Household", 4));
            inCommingAnimals.Push(new Animal("pig1", "Household", 4));
            inCommingAnimals.Push(new Animal("pig2", "Household", 4));
            inCommingAnimals.Push(new Animal("lion1", "mammal", 4));
            inCommingAnimals.Push(new Animal("pig3", "Household", 4));
        }

        internal void RemoveAnimal()
        {
            Stack<Animal> tempAnimals = new Stack<Animal>(); // Temporary stack to hold animals being processed
            Animal animal;

            // Move mammals from incoming stack to outgoing queue, and others to temp stack
            while (inCommingAnimals.Count > 0)
            {
                animal = inCommingAnimals.Pop();
                if (animal.Type == "mammal")
                {
                    outGoingAnimals.Enqueue(animal); // Add mammals to the outgoing queue
                }
                else
                {
                    tempAnimals.Push(animal); // Add non-mammals to the temporary stack
                }
            }

            // Move animals back from the temp stack to the incoming stack
            while (tempAnimals.Count > 0)
            {
                inCommingAnimals.Push(tempAnimals.Pop());
            }

            // Print information about animals in the outgoing queue to the GUI
            while (outGoingAnimals.Count > 0)
            {
                animal = outGoingAnimals.Dequeue();
                gui.PrintAnimal(animal.Species, animal.Type, animal.Age);
            }
        }
    }
}
