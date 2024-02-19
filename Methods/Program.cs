Add();
Add();
Add();
Console.WriteLine(Add2(3));

//out olursa number1 için değer atamaya gerek yok ama ref kullanırken değer atamak gerekir
int number1;
int number2 = 100;
var result = Add3(out number1, number2);
Console.WriteLine(result);
Console.WriteLine(number1);

Console.WriteLine(Multiply(12, 5));
//Console.WriteLine(Multiply(12, 5, 13));
Console.WriteLine("Params Toplamı: " +Add4(1,2,3,4,5,6,7,8));
Console.WriteLine("Params diğer toplam: " +Add5(1,2,5,9,11));

void Add()
{
    Console.WriteLine("Added!!!");
}
int Add2(int number1, int number2 = 30)
{
    var result = number1 + number2;
    return result;
}
//out da metodun içinde set edilmesi gerekir
int Add3(out int number1, int number2)
{
    number1 = 30;
    return number1 + number2;
}
int Multiply(int number1, int number2)
{
    return number1 * number2;
}
//Overloading
//int Multiply(int number1, int number2, int number3)
//{
//    return number1 * number2 * number3;
//}

int Add4(params int[] numbers)
{
    return numbers.Sum();
}
int Add5(int number, params int[] numbers)
{
    return numbers.Sum();
}