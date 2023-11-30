using ChallengeApp2;


Console.WriteLine("Witamy w Programie do oceny pracowników");
Console.WriteLine("===========================================");
Console.WriteLine();
var employee = new Employee("Maciej", "Abacki", 27, "Mężczyzna");
var supervisor = new Supervisor("Tomasz", "Babacki", 40, "Mężczyzna");

Console.WriteLine("Wybierz osobę do oceny 's' - supervisor, 'e' - pracownik");
var option = Console.ReadLine();
if (option == "s" || option == "S")
{

    while (true)
    {
        Console.WriteLine("Podaj ocenę (1-6 z + lub - na końcu, 'q' aby zakończyć):");
        string userInput = Console.ReadLine();

        if (userInput == "q")
        {
            break; // Zakończ pętlę, jeśli wpisano 'q'
        }
        try
        {
            supervisor.AddGrade(userInput);
        }
        catch (Exception e)
        {
            Console.WriteLine($"Wyłapano wyjątek : {e.Message}");
        }

        var statistics1 = supervisor.GetStatistics();

        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("OCENA PRACOWNIKA");

        Console.WriteLine($"Average: {statistics1.Average}");
        Console.WriteLine($"Min: {statistics1.Min}");
        Console.WriteLine($"Max: {statistics1.Max}");
        Console.WriteLine($"Grade as letter: {statistics1.AverageLetter}");
        break;
    }

}
else if (option == "e" || option == "E")
{
    while (true)
    {
        Console.WriteLine("Podaj ocenę (1-6 z + lub - na końcu, 'q' aby zakończyć):");
        string userInput = Console.ReadLine();

        if (userInput == "q")
        {
            break; // Zakończ pętlę, jeśli wpisano 'q'
        }
        try
        {
            employee.AddGrade(userInput);
        }
        catch (Exception e)
        {
            Console.WriteLine($"Wyłapano wyjątek : {e.Message}");
        }
    }

    var statistics2 = employee.GetStatistics();

    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("OCENA PRACOWNIKA");

    Console.WriteLine($"Average: {statistics2.Average}");
    Console.WriteLine($"Min: {statistics2.Min}");
    Console.WriteLine($"Max: {statistics2.Max}");
    Console.WriteLine($"Grade as letter: {statistics2.AverageLetter}");
}
else
{
    Console.WriteLine("Niewłaściwy wybór");
}




















