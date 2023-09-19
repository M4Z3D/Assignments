using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Model;

namespace Zoo.Controller
{
    internal class Leaving
    {
        public Leaving()
        {
            // Create a queue for animals leaving
            Queue<Animal> leavingQueue = new Queue<Animal>();

            // adding animals to the leaving queue

            leavingQueue.Enqueue(new Animal("Horse", "Mammal", 9));
            leavingQueue.Enqueue(new Animal("Pig", "Mammal", 7));
            leavingQueue.Enqueue(new Animal("Lion", "Mammal", 2));
            leavingQueue.Enqueue(new Animal("Snake", "reptile", 6));
        }
    }
}
