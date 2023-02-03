/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

Console.WriteLine("Введите первое число: ");
string numberAStr = Console.ReadLine();
int numberA = Convert.ToInt32(numberAStr);

Console.WriteLine("Введите второе число: ");
string numberBStr = Console.ReadLine();
int numberB = Convert.ToInt32(numberBStr);

int max = numberA;
int min = numberB;

if (numberB > numberA) 
    {   
    Console.WriteLine(("Большее число: "+numberB),("Меньшее число: "+numberA));
    }
    else
    {
        Console.WriteLine(("Меньшее число: "+numberB),("Большее число: "+numberA));
    }
if (numberA > numberB) 
    {
        Console.WriteLine(("Большее число: "+numberA),("Меньшее число: "+numberB));
    }
    else
    {
        Console.WriteLine(("Меньшее число: "+numberA),("Большее число: "+numberB));
    }