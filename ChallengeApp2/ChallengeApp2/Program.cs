using ChallengeApp2;


Console.WriteLine("Witamy w Programie do oceny pracowników");
Console.WriteLine("===========================================");
Console.WriteLine();
var employee = new EmployeeInFile("Maciej", "Abacki", 27, "Mężczyzna");
//var supervisor = new Supervisor("Tomasz", "Babacki", 40, "Mężczyzna");

void EmployeeGradeAdded(object sender, EventArgs args)
{
    Console.WriteLine("Dodano nową ocenę");
}

employee.GradeAdded += EmployeeGradeAdded;


while(true)
{
    Console.WriteLine("Podaj kolejna ocene lub wpisz q aby zakonczyc program");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }
    try
    {
        employee.AddGrade(input!);
    }
    catch (Exception e)
    {
        Console.WriteLine($"Exception catched: {e.Message}");
    }
}

var statistics = employee.GetStatistics();
Console.WriteLine($"Average: {statistics.Average}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Grade as letter: {statistics.AverageLetter}");


