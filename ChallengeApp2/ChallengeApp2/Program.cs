//imie
string name = "Ewa";
//wiek
var age = 15;
//zmienne z płcią
var male = 1;
var female = 2;

if (age == 25)
{
    if (female == 2)
     Console.WriteLine("kobieta ponizej 30 lat");
}
else if (age == 33)
{
    if (name == "Ewa")
     Console.WriteLine("Ewa lat 33");
}
if (age < 5)
{   if (male == 1)
    Console.WriteLine("Wiek mniejszy niz 5");
}
else if (age < 18)
{
    if (male == 1)
        Console.WriteLine("Niepełnoletni mężczyzna");
}
