Console.Write("Введите трёхзначное число: ");
string n = Console.ReadLine();
int Num = int.Parse(n);

int Num1 = Num / 100;
int Num3 = Num % 10; 
int res = Num1 * 10 + Num3;

Console.Write(res);