using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;
using Zoo.Model;

namespace Zoo.View
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a queue for animals leaving
            Queue<Animal> leavingQueue = new Queue<Animal>();

            // Adding animals to the leaving queue
            leavingQueue.Enqueue(new Animal("Horse", "Mammal", 9));
            leavingQueue.Enqueue(new Animal("Pig", "Mammal", 7));
            leavingQueue.Enqueue(new Animal("Lion", "Mammal", 2));
            leavingQueue.Enqueue(new Animal("Snake", "reptile", 6));

            // printing out all the leaving animals 
            while (leavingQueue.Count > 0)
            {
                Animal animalLeaving = leavingQueue.Dequeue();
                Console.WriteLine($"Animal leaving: {animalLeaving.Species}, Type: {animalLeaving.Type}, Age: {animalLeaving.Age}");
            }
        }

    }
}