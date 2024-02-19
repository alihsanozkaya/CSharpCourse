//string student1 = "Engin";
//string student2 = "Derin";
//string student3 = "Salih";

string[] students = new string[3];
students[0] = "Engin";
students[1] = "Derin";
students[2] = "Salih";

foreach (var student in students)
{
    Console.WriteLine(student);
}

string[] students2 = { "Ali", "İhsan", "İrem", "Sena" };

foreach (var student in students2)
{
    Console.WriteLine(student);
}

string[,] regions = new string[7, 3]
{
    {"İstanbul", "Kocaeli", "Tekirdağ" },
    {"Ankara", "Konya", "Sivas" },
    {"Adana", "Mersin", "Antalya" },
    {"Artvin", "Trabzon", "Samsun" },
    {"Gaziantep", "Şanlıurfa", "Mardin" },
    {"İzmir", "Denizli", "Muğla" },
    {"Erzurum", "Van", "Kars" },
};

for (int i = 0; i <= regions.GetUpperBound(0); i++)
{
    Console.WriteLine("{0}. Bölge", i+1);
    for (int j = 0; j <= regions.GetUpperBound(1); j++)
    {
        Console.WriteLine(regions[i,j]);
    }
}