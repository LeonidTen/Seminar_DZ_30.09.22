/* Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.WriteLine("Введите первое число: ");
string Number1 = Console.ReadLine();
int Num1 = Convert.ToInt32(Number1);
Console.WriteLine("Введите второе число: ");
string Number2 = Console.ReadLine();
int Num2 = Convert.ToInt32(Number2);
Console.WriteLine("Введите третье число: ");
string Number3 = Console.ReadLine();
int Num3 = Convert.ToInt32(Number3);

if (Num1 >= Num2 & Num1 >=Num3)
{
    Console.WriteLine($"max = {Num1}");
}

else if (Num2 >= Num1 & Num2 >=Num3)
{
    Console.WriteLine($"max = {Num2}");
}
else if (Num3 >= Num1 & Num3 >=Num2)
{
    Console.WriteLine($"max = {Num3}");
}