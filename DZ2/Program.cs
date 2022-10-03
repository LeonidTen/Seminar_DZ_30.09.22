/* Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

Console.WriteLine("Введите первое число: ");
string firstNumber = Console.ReadLine();
int number = Convert.ToInt32(firstNumber);
Console.WriteLine("Введите второе число: ");
string secondNumber = Console.ReadLine();
int number2 = Convert.ToInt32(secondNumber);

if (number > number2)
    
    Console.WriteLine($"большее число является {number}, меньшее число является {number2}");
      
    else 
        Console.WriteLine($"большее число является {number2}, меньшее число число является {number}");