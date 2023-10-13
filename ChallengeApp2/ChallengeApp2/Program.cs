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
            employee.AddGrade(4292224234);
            employee.AddGrade("4");
            employee.AddGrade(1.2444444);
            employee.AddGrade(900000000000000000);

            var statistics1 = employee.GetStatisticsWithFor();
            var statistics2 = employee.GetStatisticsWithForeach();
            var statistics3 = employee.GetStatisticsWithDoWhile();
            var statistics4 = employee.GetStatisticsWithWhile();
            Console.WriteLine(" ");
            Console.WriteLine("Pętla for ");
            Console.WriteLine($"Największa liczba: {statistics1.Max}");
            Console.WriteLine($"Średnia: {statistics1.Average:N2}");
            Console.WriteLine($"Najmniejsza liczba: {statistics1.Min}");
            Console.WriteLine(" ");
            Console.WriteLine("Pętla foreach");
            Console.WriteLine($"Największa liczba: {statistics2.Max}");
            Console.WriteLine($"Średnia: {statistics2.Average:N2}");
            Console.WriteLine($"Najmniejsza liczba: {statistics2.Min}");
            Console.WriteLine(" ");
            Console.WriteLine("Pętla do...while");
            Console.WriteLine($"Największa liczba: {statistics3.Max}");
            Console.WriteLine($"Średnia: {statistics2.Average:N2}");
            Console.WriteLine($"Najmniejsza liczba: {statistics3.Min}");
            Console.WriteLine(" ");
            Console.WriteLine("Pętla while");
            Console.WriteLine($"Największa liczba: {statistics2.Max}");
            Console.WriteLine($"Średnia: {statistics2.Average:N2}");
            Console.WriteLine($"Najmniejsza liczba: {statistics2.Min}");


        }

    }
}






