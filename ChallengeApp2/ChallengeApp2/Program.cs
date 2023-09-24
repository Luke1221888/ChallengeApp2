using ChallengeApp2;

var employee = new Employee("Tomek", "Abacki");

employee.AddGrade(96);
employee.AddGrade(44);
employee.AddGrade(70);
employee.AddGrade(75);
employee.AddGrade(71);
var statistics = employee.GetStatistics();

Console.WriteLine($"Maximal:{statistics.Max}");
Console.WriteLine($"Minimal:{statistics.Min}");
Console.WriteLine($"Average:{statistics.Average:N2}");


