Console.Write("Введите число: ");
string n = Console.ReadLine();
int Num = int.Parse(n);


int i = 100;
int num = 0;
int result = 0;
if (Num < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    while (Num / i > 9)
    { 
        i = i * 10;
    }
    i = i / 100;
    int Num1 = Num / i;
    result = Num1 % 10;
    Console.WriteLine(result);
}


