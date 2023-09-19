namespace Superhero
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // for myself look past this :)
            // object = an instance of class
            //          A class can be used as a blueprint to create objects
            //          objects can have fields & methods (characteristics & actions)

            // variable declaration and instantiation  of a new object in the class
            SuperHero newHero = new SuperHero()
            {
                // Filling in data
                Name = "Clark kent",
                Age = 35,
                Alias = "Superman",
                Superpowers = "Superhuman strength, speed, and flight",
                ArchNemesis = "Lex Luthor",
                Motivation = "To protect Earth and its people from threats"
            };
            // calls methods
            newHero.introduction();
            newHero.HeroMotivation();
        }
    }
    class SuperHero
    {
        // Gets and sets the data from the newhero in main into the introduction and hero motivation method
        public string? Name { get; set; }
        public int Age { get; set; }
        public string? Alias { get; set; }
        public string? Superpowers { get; set; }
        public string? ArchNemesis { get; set; }
        public string? Motivation { get; set; }

        // Super hero introduction method with the name age alias and super powers
        public void introduction()
        {
            Console.WriteLine($"I am {Name}, im {Age} years old, and also known as {Alias}. i have special ability such as {Superpowers}. My arch Nemisis is {ArchNemesis}");

        }
        // hero motivation and gets the motivation from the newhero in main
        public void HeroMotivation()
        {
            Console.WriteLine($"My motivation and morals stem from {Motivation}");
        }
    }
}