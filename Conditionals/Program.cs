﻿var number = 30;

if (number == 10)
{
    Console.WriteLine("Number is 10");
}
else if (number == 20)
{
    Console.WriteLine("Number is 20");
}
else
{
    Console.WriteLine("Number is not 10 or 20");
}

Console.WriteLine(number == 10 ? "Number is 10" : "Number is not 10");

switch (number)
{
    case 10:
        Console.WriteLine("Number is 10");
        break;
    case 20:
        Console.WriteLine("Number is 20");
        break;
    case 30:
        Console.WriteLine("Number is 30");
        break;
    default:
        Console.WriteLine("Number is not 10 or 20 or 30");
        break;
}
number = 200;
if (number >= 0 && number <= 100)
{
    Console.WriteLine("Number is between 0-100");
}
else if (number > 100 && number <= 200)
{
    Console.WriteLine("Number is between 101-200");
}
else if (number > 200 || number < 0)
{
    Console.WriteLine("Number is less than 0 or greater than 200");
}

number = 93;
if (number < 100)
{
    if (number >= 90 && number < 95)
    {
        Console.WriteLine("Number is between 90-94");
    }
    else
    {
        
    }
}