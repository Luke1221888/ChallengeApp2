using ChallengeApp2;

Employee employee1 = new Employee("Tomek", "Abacki", 39);
Employee employee2 = new Employee("Alicja", "Cabacka", 27);
Employee employee3 = new Employee("Maciek", "Babacki", 26);

employee1.AddScore(1);
employee1.AddScore(7);
employee1.AddScore(5);
employee1.AddScore(5);
employee1.AddScore(6);

employee2.AddScore(1);
employee2.AddScore(7);
employee2.AddScore(2);
employee2.AddScore(2);
employee2.AddScore(1);

employee3.AddScore(7);
employee3.AddScore(10);
employee3.AddScore(7);
employee3.AddScore(8);
employee3.AddScore(8);


int maxResult = -1;
Employee employeeWithMaxResult = null;

List<Employee> staff = new List<Employee>()
        { employee1, employee2, employee3 };


foreach (var employee in staff)
{
    if (employee.Result > maxResult)
    {
        
        employeeWithMaxResult = employee;
        maxResult = employee.Result;
    }

}
Console.WriteLine($"Największy wynik osiągnął:");
Console.WriteLine("Imie:" +" " +employeeWithMaxResult.Name);
Console.WriteLine("Nazwisko:" +" " +employeeWithMaxResult.Surname);
Console.WriteLine($"Wiek: {employeeWithMaxResult.Age} lat");
Console.WriteLine($"Liczba zdobytych przez niego punktów to {maxResult}.");
