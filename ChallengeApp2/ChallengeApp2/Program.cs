using ChallengeApp2;

Console.WriteLine("Witamy w Programie do oceny pracowników");
Console.WriteLine("===========================================");
Console.WriteLine();
var employee = new Employee();


while (true)
{
    Console.WriteLine("Podaj kolejną ocene pracownika:");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }
    else
    {
        employee.AddGrade(input);
    }
}

var statistics = employee.GetStatistics();
Console.WriteLine($"Average: {statistics.Average}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Grade as letter: {statistics.AverageLetter}");