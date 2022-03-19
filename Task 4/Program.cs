Console.Write("Введите цифру дня недели: ");
string n = Console.ReadLine();
int Num = int.Parse(n);

if (Num == 7)
{
    Console.Write("Это выходной");
}
else
{
    if (Num == 6)
    {
        Console.Write("Это выходной");
    }
    else 
    {
        Console.Write("Это не выходной");
    }
}
