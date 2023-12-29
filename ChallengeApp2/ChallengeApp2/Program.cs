using ChallengeApp2;


Console.WriteLine("Witamy w Programie do oceny pracowników");
Console.WriteLine("===========================================");
Console.WriteLine();
var employee = new EmployeeInFile("Maciej", "Abacki", 27, "Mężczyzna");
var supervisor = new Supervisor("Tomasz", "Babacki", 40, "Mężczyzna");

employee.AddGrade(99);
employee.AddGrade('a');
employee.AddGrade(0.5f);
employee.AddGrade(34);
employee.AddGrade('b');

var statistics = employee.GetStatistics();
Console.WriteLine($"Average: {statistics.Average}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Grade as letter: {statistics.AverageLetter}");



















