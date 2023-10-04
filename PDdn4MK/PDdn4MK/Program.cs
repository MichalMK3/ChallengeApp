using System.ComponentModel.Design;

string  mes1  = "Imię" ;
Console.WriteLine(mes1) ;
string mes2 = "Płeć" ;
Console.WriteLine(mes2) ;
string mes3 = "Wiek" ;
Console.WriteLine(mes3) ;

var Imię = "Ewa" ;
var Płeć = "Kobieta" ;
var Płeć2 = "Mężczyzna" ;
var Wiek = 33 ;

if (Imię == "Ewa" && Wiek == 33) ;
{
    Console.WriteLine("Ewa ,lat 33") ;
}
if (Płeć == "Kobieta" && Wiek < 33) 
{
    Console.WriteLine("Kobieta poniżej lat 30");
}
else if (Płeć == "Kobieta" && Wiek >= 33) 
{
    Console.WriteLine("Starsze panie na drugiej");
}

if (Wiek < 18 && Płeć2 == "Mężczyzna") 
{
    Console.WriteLine("Niepełnoletni Mężczyzna");
}
else if (Wiek > 18 && Płeć2 == "Mężczyzna")  
{
    Console.WriteLine("Pełnoletni Mężczyzna");
}