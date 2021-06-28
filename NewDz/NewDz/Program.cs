using System;
using Program;

Console.WriteLine("Введите количество элементов массива");
var n = Convert.ToInt32(Console.ReadLine());
var massMain = InitArray(1, 27, n);
var nEven = 0;
var nOdd = 0;
var iMass = 0;
var iArray = 0;
var massChar = "aeidhj";

for (var i = 0; i < n; i++)
{
    if (massMain[i] % 2 == 0)
    {
        nEven++;
    }
}

nOdd = n - nEven;

var massOdd = new int[nOdd];
var massEven = new int[nEven];

for (var i = 0; i < n; i++)
{
    if (massMain[i] % 2 == 0)
    {
        massEven[iMass] = massMain[i];
        iMass++;
    }
    else
    {
        massOdd[iArray] = massMain[i];
        iArray++;
    }
}

var evenWithChars = ChangeNumbersToChars(massEven, nEven);
var oddWithChars = ChangeNumbersToChars(massOdd, nOdd);
Console.WriteLine();
Console.WriteLine("Массив символов с четными номерами");
OutputInformation(evenWithChars,  nEven);
Console.WriteLine();
Console.WriteLine("Массив символов с нечетными номерами");
OutputInformation(oddWithChars,  nOdd);
Console.WriteLine();
CountUppercaseCharacters(evenWithChars, oddWithChars);

string[] ChangeNumbersToChars(int[] mass, int lenght)
{
    var iMass = new string[lenght];
    for (var i = 0; i < lenght; i++)
    {
        var symbol = (Alphabet)mass[i];
        iMass[i] = symbol.ToString().ToLower();

        if (massChar.Contains(iMass[i]))
        {
            iMass[i] = iMass[i].ToUpper();
        }
    }

    return iMass;
}

int[] InitArray(int minRange, int maxRange, int length)
{
    var array = new int[length];

    for (var i = 0; i < length; i++)
    {
        array[i] = new Random().Next(minRange, maxRange);
        Console.Write($"{array[i]} ");
    }

    Console.WriteLine(" ");
    return array;
}

void OutputInformation(string[] mass, int length)
{
    for (var i = 0; i < length; i++)
    {
        Console.Write($"{mass[i]} ");
    }

    Console.WriteLine(" ");
}

void CountUppercaseCharacters(string[] mass, string[] mass2)
{
    var countOfUppercaseCharacters = 0;
    var countOfUppercaseCharacters2 = 0;
    foreach (var item in mass)
    {
        if (massChar.Contains(item.ToLower()))
        {
            countOfUppercaseCharacters++;
        }
    }

    foreach (var item in mass2)
    {
        if (massChar.Contains(item.ToLower()))
        {
            countOfUppercaseCharacters2++;
        }
    }

    if (countOfUppercaseCharacters == countOfUppercaseCharacters2)
    {
        Console.WriteLine("В обоих массивах одинаковое количество символов верхнего регистра");
    }
    else if (countOfUppercaseCharacters > countOfUppercaseCharacters2)
    {
        Console.WriteLine("В первом массиве больше символов верхнего регистра чем во втором");
    }
    else
    {
        Console.WriteLine("Во втором массиве больше символом верхнего регистра чем в первом");
    }
}