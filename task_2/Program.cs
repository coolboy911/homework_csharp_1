/*Напишите программу, которая на вход принимает два числа
и выдаёт, какое число большее, а какое меньшее.*/
Console.Write("Введите первое число: ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("Введите Второе число: ");
int numberB = int.Parse(Console.ReadLine());
if (numberA > numberB) Console.WriteLine($"первое число {numberA} больше второго числа {numberB}");
else if (numberA < numberB) Console.WriteLine($"первое число {numberA} меньше второго числа {numberB}");
else Console.WriteLine($"первое число {numberA} равно второму числу {numberB}");