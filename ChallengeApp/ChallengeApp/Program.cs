﻿// Przygotuj program, który policzy ile jakich cyfr
// występuje w podanej liczbie:
//
// Przykład:
// Wyniki dla liczby: 4566
// 0 => 0
// 1 => 0
// 2 => 0
// 3 => 0
// 4 => 1
// 5 => 1
// 6 => 2
// 7 => 0
// 8 => 0
// 9 => 0


int number = 4566;
string numberAsString = number.ToString();
char[] letters = numberAsString.ToCharArray();
int counter0 = 0;
int counter1 = 0;
int counter2 = 0;
int counter3 = 0;
int counter4 = 0;
int counter5 = 0;
int counter6 = 0;
int counter7 = 0;
int counter8 = 0;
int counter9 = 0;
int counter = 10;



foreach (char letter in letters)
{
    if (letter == '0')
    {
        counter0++;
    }
    else if (letter == '1')
    {
        counter1++;
    }
    if (letter == '2')
    {
        counter2++;
    }
    else if (letter == '3')
    {
        counter3++;
    }
    if (letter == '4')
    {
        counter4++;
    }
    else if (letter == '5')
    {
        counter5++;
    }
    if (letter == '6')
    {
        counter6++;
    }
    else if (letter == '7')
    {
        counter7++;
    }
    if (letter == '8')
    {
        counter8++;
    }
    else if (letter == '9')
    {
        counter9++;
    }


}
Console.WriteLine("Zadanie Domowe, dzień 5");
Console.WriteLine("Wskaż, ile razy poszczególne cyfry, występują w cyfrze 4566:");
Console.WriteLine("0="+ counter0);
Console.WriteLine("1=" + counter1);
Console.WriteLine("2=" + counter2);
Console.WriteLine("3=" + counter3);
Console.WriteLine("4=" + counter4);
Console.WriteLine("5=" + counter5);
Console.WriteLine("6=" + counter6);
Console.WriteLine("7=" + counter7);
Console.WriteLine("8=" + counter8);
Console.WriteLine("9=" + counter9);