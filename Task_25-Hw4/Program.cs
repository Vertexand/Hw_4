// Homework 4 Task 25: Напишите цикл, который принимает на вход два числа (A и B) и
// возводит число A в натуральную степень B.  3, 5 -> 243 (3⁵), 2, 4 -> 16, Не использовать Math.Pow() и аналоги!
Console.Write("Введите число A  ");
int A  = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B  ");
int B  = Convert.ToInt32(Console.ReadLine());
int res= A;
for (int i = 1; i <=B-1;  i++)
{
   res = A*res;  
}
   Console.Write(res);







 //зад 11 сем 2 выводит случ. трехзн число и удаляет втор number

// int number = new Random().Next(100,1000);
// Console.WriteLine($"Случайное число {number}");
// int number1 = number%10;
// int number2 = number/100;
// Console.WriteLine($"результат выполнения равен{number2*10+number1}");

// Console.Write(i*i*i + " ");// + " " - отделяет числа друг от друга
