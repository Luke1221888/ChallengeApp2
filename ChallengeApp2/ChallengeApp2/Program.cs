string name = "Ewa";
int age = 33;
bool isWomen = true;

if (name == "Ewa" && age == 33)

    Console.WriteLine("EWA LAT 33");

else if (!isWomen && age < 18)
    
    Console.WriteLine("NIEPELNOLETNI MEZCZYZNA");

else if (isWomen == true && age <= 30)
    Console.WriteLine("KOBIETA PONIZEJ 30 LAT");
