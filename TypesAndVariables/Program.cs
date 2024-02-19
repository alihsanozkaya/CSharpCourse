Console.WriteLine("Hello World");

//Value Types
byte number4 = 255; //8 Bit
short number3 = -32768; //16 Bit
int number1 = 2147483647; //32 Bit
long number2 = 2147483648; //64 Bit
double number5 = 10.4; //Virgülden sonra 15-16 değer tutar
decimal number6 = 10.4m; //Virgülden sonra 28-29 değer tutar

bool condition = false;

char character = 'A';
string city = "Ankara";

var number7 = 10;
number7 = 'S';
 
Console.WriteLine("Number1 is {0}", number1);
Console.WriteLine("Number2 is {0}", number2);
Console.WriteLine("Number3 is {0}", number3);
Console.WriteLine("Number4 is {0}", number4);
Console.WriteLine("Number5 is {0}", number5);
Console.WriteLine("Number6 is {0}", number6);
Console.WriteLine("Number7 is {0}", number7);
Console.WriteLine("Condition is {0}", condition);
Console.WriteLine("Character is {0}", character);
Console.WriteLine("City is {0}", city);
Console.WriteLine("Character is {0}", city[2]);
Console.WriteLine((int)Days.Friday);

enum Days
{
    Monday=1, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
}
