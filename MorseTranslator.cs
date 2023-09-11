using System.Diagnostics.Tracing;

namespace Mosecode_translator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Morsecode translator");

            Console.Write("Write what you want to get translated here:");
            string UserInput = Console.ReadLine();

            char[] Characters = UserInput.ToCharArray();
            

            foreach (char c in Characters) 
            
            {
                switch (c)
                {
                    // The different letters and the translated Morse code value
                    case ' ':
                        Console.Write("/ ");
                        break;
                    case 'a':
                        Console.Write(".- ");
                        break;
                    case 'b':
                        Console.Write("-... ");
                        break;
                    case 'c':
                        Console.Write("-.-. ");
                        break;
                    case 'd':
                        Console.Write("-.. ");
                        break;
                    case 'e':
                        Console.Write(". ");
                        break;
                    case 'f':
                        Console.Write("..-. ");
                        break;
                    case 'g':
                        Console.Write("--. ");
                        break;
                    case 'h':
                        Console.Write(".... ");
                        break;
                    case 'i':
                        Console.Write(".. ");
                        break;
                    case 'j':
                        Console.Write(".--- ");
                        break;
                    case 'k':
                        Console.Write("-.- ");
                        break;
                    case 'l':
                        Console.Write(".-.. ");
                        break;
                    case 'm':
                        Console.Write("-- ");
                        break;
                    case 'n':
                        Console.Write("-. ");
                        break;
                    case 'o':
                        Console.Write("--- ");
                        break;
                    case 'p':
                        Console.Write(".--. ");
                        break;
                    case 'q':
                        Console.Write("--.- ");
                        break;
                    case 'r':
                        Console.Write(".-. ");
                        break;
                    case 's':
                        Console.Write("... ");
                        break;
                    case 't':
                        Console.Write("- ");
                        break;
                    case 'u':
                        Console.Write("..- ");
                        break;
                    case 'v':
                        Console.Write("...- ");
                        break;
                    case 'x':
                        Console.Write("-..- ");
                        break;
                    case 'y':
                        Console.Write("-.-- ");
                        break;
                    case 'z':
                        Console.Write("--.. ");
                        break;
                    case 'æ':
                        Console.Write(".-.- ");
                        break;
                    case 'ø':
                        Console.Write("---. ");
                        break;
                    case 'å':
                        Console.Write(".--.- ");
                        break;
                    case 'w':
                        Console.Write(".-- ");
                        break;

                    // The different numbers and the translated Morse code value
                    case '1':
                        Console.Write(".---- ");
                        break;
                    case '2':
                        Console.Write("..--- ");
                        break;
                    case '3':
                        Console.Write("...-- ");
                        break;
                    case '4':
                        Console.Write("....- ");
                        break;
                    case '5':
                        Console.Write("..... ");
                        break;
                    case '6':
                        Console.Write("-.... ");
                        break;
                    case '7':
                        Console.Write("--... ");
                        break;
                    case '8':
                        Console.Write("---.. ");
                        break;
                    case '9':
                        Console.Write("----. ");
                        break;
                    case '0':
                        Console.Write("----- ");
                        break;


                    // The different symbols and the translated Morse code valu
                    case '.':
                        Console.Write(".-.-.- ");
                        break;
                    case ',':
                        Console.Write("--..-- ");
                        break;
                    case ':':
                        Console.Write("---... ");
                        break;
                    case '?':
                        Console.Write("..--.. ");
                        break;
                    case '-':
                        Console.Write("-....- ");
                        break;
                    case '/':
                        Console.Write("-..-. ");
                        break;
                    case '(':
                        Console.Write("-.--. ");
                        break;
                    case ')':
                        Console.Write("-.--.- ");
                        break;
                    case '"':
                        Console.Write(".-..-. ");
                        break;
                }


            }

        }

    }
}