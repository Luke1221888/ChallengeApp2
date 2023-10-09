using ChallengeApp2;

namespace ChallengeApp2
{
    class Program
    {
        static void Main()
        {
            var employee = new Employee("Cezary", "Zetowski");
            employee.AddGrade(2);
            employee.AddGrade("Maciej");
            employee.AddGrade(2000);
            employee.AddGrade(20);
            employee.AddGrade("4");
            employee.AddGrade(1.2444444);
            employee.AddGrade(900000000000000000);
           
            var statistics = employee.GetStatistics();

            Console.WriteLine($"Największa liczba: {statistics.Max}");
            Console.WriteLine($"Średnia: { statistics.Average:N2}");
            Console.WriteLine($"Najmniejsza liczba: {statistics.Min}");
        }

    }
}






