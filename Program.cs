// Напишите программу, которая на вход 
// принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Введите первое число: ");
string s_num1 = Console.ReadLine();
int num1 = Convert.ToInt32(s_num1);
Console.Write("Введите второе число: "); 
string s_num2 = Console.ReadLine();
int num2 = Convert.ToInt32(s_num2);

if (num1 > num2)
    Console.WriteLine(num1);
else
   Console.WriteLine(num2);