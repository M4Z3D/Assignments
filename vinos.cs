namespace Vinos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int MAX = 188052;
            const byte MAXSTAR = 100;

            int[] year = new int[] { 2009, 2010, 2011, 2012, 2013, 2014, 2015, 2016, 2017, 2018, 2019 };
            int[] vinos = new int[] { 175134, 175388, 172818, 142709, 151437, 152620, 150979, 152210, 149450, 154398, 150160 };
            // Adding the miss calculated number into the number
            vinos[5] += 35432;



            // Sorting the vinos bought. i just cant figure out how to match up the year with the numbers of sold liters of wine
            Array.Sort(vinos);
            // Revering the sorting so its a desending graph
            Array.Reverse(vinos);






            // Find the maximum value in the array
            int max = vinos.Max();

            // Loop through the data and print the year, value, and graph
            for (int i = 0; i < year.Length; i++)
            {
                int stjerner = MAXSTAR * vinos[i] / max;

                Console.Write("Year " + year[i] + ": " + vinos[i] + " ");
                for (int j = 0; j < stjerner; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
