namespace Birthday
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Asking for the age and reading the input and saving it in the day varrible
            Console.WriteLine("I will help you calculate your age with year and days ");
            Console.Write("Please enter your birthday in day date(numbers only): ");
            int day = int.Parse(Console.ReadLine());
            // Asking for the age and reading the input and saving it in the month varrible
            Console.WriteLine("Please enter your month of birth (numbers only):");
            int month = int.Parse(Console.ReadLine());
            // Asking for the age and reading the input and saving it in the year varrible
            Console.WriteLine("Please enter the year of birth:");
            int year = int.Parse(Console.ReadLine());

            // taking those values given and putting them into a datetime instance
            DateTime birthday = new DateTime(year, month, day);
            DateTime today = DateTime.Today;
            // then im subtracting those todays date with the given birthday value
            int ageInYears = today.Year - birthday.Year;
            int ageInDays = (today-birthday).Days;
            // and here im typing out the age and days
            Console.WriteLine("Your age is:" + ageInYears + "years and" + ageInDays + "days");
            
        }
    }
}