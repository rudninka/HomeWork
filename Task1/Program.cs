Console.Write("Введите первое число: ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberB = int.Parse(Console.ReadLine());
int max = numberA;
if (numberA > numberB) max = numberA;
if (numberA < numberB) max = numberB;

Console.WriteLine(max);