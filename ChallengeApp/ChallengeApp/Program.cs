// Podaj imię
var name = "Ewa";
//Podaj wiek
var age = 33;
//Podaj płeć
var sex = "Kobieta";

// zweryfikuj dane
// 1. "Kobieta poniżej 30 lat"

if (sex == "Kobieta" && age < 30) ;
{
    Console.WriteLine("Kobieta poniżej 30 lat");
};


// 2. Ewa, lat 33

if (name == "Ewa" && age == 33) ;
{
    Console.WriteLine("Ewa,lat 33");
};


// 3. Niepełnoletni mężczyzna
var Myage = 17;
var Mysex = "Mężczyzna";

if (Myage == 18 && Mysex == "Mężczyzna") 
{
    Console.WriteLine("pełnoletni mężczyzna");
}
else if (Myage < 18 && Mysex == "Mężczyzna") 
{
    Console.WriteLine("niepełnoletni mężczyzna");
}

