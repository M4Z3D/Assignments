using System.Drawing;

namespace Superheros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
    public class SuperHeros
    {
        private string _identity;
        public string identity
        {
            get { return _identity; }
            private set { _identity = value; }
        }

    }
}