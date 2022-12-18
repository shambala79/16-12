// Задача 1
Console.WriteLine("Введи первое число: ");
int num1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введи второе число: ");
int num2 = int.Parse(Console.ReadLine()!);
if (num1 >= num2)
Console.WriteLine($"Число {num1} больше или равно числу {num2}");
else 
Console.WriteLine($"Число {num2} больше числа {num1}");
// Задача 2
Console.WriteLine("Введи первое число: ");
int number1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введи второе число: ");
int number2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введи третье число: ");
int number3 = int.Parse(Console.ReadLine()!);
int max = number1;
if (max< number2)
max = number2;
if (max< number3)
max = number3;
Console.WriteLine($"Максимальное число: {max}");
// Задача 3
Console.WriteLine("Введи число: ");
int number = int.Parse(Console.ReadLine()!);
int N = number%2;
if (N == 0)
Console.WriteLine($"Число {number} - чётное.");
else
Console.WriteLine($"Число {number} - нечётное.");
// Задача 4
Console.WriteLine("Введи число: ");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Чётные числа от 1 до {num}: ");
int n = 2;
while(n <= num){
    if (n%2 == 0)
    Console.Write($"{n} ");
    n++;
}