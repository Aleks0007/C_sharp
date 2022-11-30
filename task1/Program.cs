Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine()!);

if (number1 > number2)
{
    Console.Write("max = ");
    Console.Write(number1);
}
if (number1 < number2)
{
    Console.Write("max = ");
    Console.Write(number2);
}
if (number1 == number2)
{
    Console.Write("Оба числа равны, max = ");
    Console.Write(number1);
}