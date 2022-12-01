Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
int i = 1;

while (i < number)
{
    Console.Write(i + 1);
    Console.Write(" ");
    i += 2;
}