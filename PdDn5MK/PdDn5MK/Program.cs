//podane przez Adama , oznacza tyle co wprowadź zmienną number nadaj jej wartość 4566 a potem zapisz tą wartość ,końcowe char [] można powiedzieć że tworzy pierwotny szkic tabeli

int number = 1625417116;
string numberInString = number.ToString();
char[] letters = numberInString.ToArray();

// wprowadzam tabele zmiennych żeby mieć je do późniejszych modyfikacjii
// to zmienne dla moich cyfr w liczbie dlatego żeby podać ich późniejszą ilość musze dla każdej wyjść od zera - wprowadź jedna zmienna w druga

int[] numbers = new int[10];
numbers[0] = 0;
numbers[1] = 0;
numbers[2] = 0;
numbers[3] = 0;
numbers[4] = 0;
numbers[5] = 0;
numbers[6] = 0;
numbers[7] = 0;
numbers[8] = 0;
numbers[9] = 0;

//wprowadzam pętle foreach jako już właściwy licznik cyfr z nową zmienne żeby mieć jakiś odnośnik/pośrednik między liczba a cyframi

foreach (char letter in letters)
{
    if (letter == '0')
    {
        numbers[0]++;
     }
    else if (letter ==  '1') 
    {
        numbers[1]++;
    }
    else if (letter == '2') 
    {
        numbers[2]++;
    }
    else if (letter == '3')
    {
        numbers[3]++;
    }
    else if (letter == '4')
    {
        numbers[4]++;
    }
    else if (letter == '5')
    {
        numbers[5]++;
    }
    else if (letter == '6')
    {
        numbers[6]++;
    }
    else if (letter == '7')
    {
        numbers[7]++;
    }
    else if (letter == '8')
    {
        numbers[8]++;
    }
    else if (letter == '9')
    {
        numbers[9]++;
    }
    
}
// zakończenie 
Console.WriteLine("Wyniki dla liczby" + number);
Console.WriteLine("0 => " + numbers[0]);
Console.WriteLine("1 => " + numbers[1]);
Console.WriteLine("2 => " + numbers[2]);
Console.WriteLine("3 => " + numbers[3]);
Console.WriteLine("4 => " + numbers[4]);
Console.WriteLine("5 => " + numbers[5]);
Console.WriteLine("6 => " + numbers[6]);
Console.WriteLine("7 => " + numbers[7]);
Console.WriteLine("8 => " + numbers[8]);
Console.WriteLine("9 => " + numbers[9]);
Console.WriteLine("Boże w końcu ,trzeba naprawdę logicznie pomyśleć huh");