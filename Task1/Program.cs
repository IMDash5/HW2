Console.Write("Введите трёхзначное число: ");
string n = Console.ReadLine();
int Num = int.Parse(n);

int res = Num % 100 / 10;
Console.Write(res);
