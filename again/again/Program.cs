namespace again
{
    // The Program class contains the entry point of the application.
    internal class Program
    {
        // The Main method is the entry point of the program.
        static void Main(string[] args)
        {
            // Create an instance of the Controller class to manage animal operations.
            again.Controller.Controller ctrl = new again.Controller.Controller();

            // Add some animals to the system.
            ctrl.AddAnimal();

            // Remove animals and display outgoing animals' information.
            ctrl.RemoveAnimal();
        }
    }
}