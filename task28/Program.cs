
// cem 4. Задача 28: Напишите программу, которая принимает на вход число N и выдаёт 
// произведение чисел от 1 до N  4 -> 24;  5 -> 120
Console.WriteLine("Введите число A");// OK!!!!
int A = Convert.ToInt32(Console.ReadLine());//далее пишем цикл 
int sum = 1;
if (A<1)
{
    Console.WriteLine("Невозможно обработать число");
}
else{
    for (int i = 1; i <= A; i++) 
    {
     sum *= i;
    }
Console.WriteLine($"Произведение чисел от 1 до А = {sum}");
}


// CEM 4 № 24 нaпис прогр. которая принимает на вход число А 
// а выдает сумму чисел от 1 до А. 7-> 28. 4-> 10

// Console.WriteLine("Введите число A");// OK!!!!
// int A = Convert.ToInt32(Console.ReadLine());//далее пишем цикл 
// int sum = 0;
// for (int i = 1; i <= A; i++) 
// { 
//     sum = sum + i; // sum += i;
// }
// Console.WriteLine($"Сумма чисел от 1 до А = {sum}");

// // cem 4 zадача 30: Напишите программу, которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке. [1,0,1,1,0,1,0,0]
//zадача 30
// int[]array = new int[8];//НА 2.01  
// int i =0;
// for (i=0; i < 8; i++)
// {
//     int A = new Random().Next(0, 2);
//     array[i] =A;
// Console.Write(array[i]);
// }

//zадача 30 next  Иван на 2.11 cem 4
// int[] array = new int[8]; 
// Random rand = new Random();

// for (int i = 0; i< array.Length; i++)// int i = 0 объявили переменную i
// {
//     array[i] = rand.Next(0, 10); //диапазон 0, 1
//     // Console.Write(array[i]+ " ");// вывод 
// }
// // // Console.WriteLine(string.Join(", ", array));  // вывод Join это метод  у класса string

// Console.WriteLine($"[{string.Join(", ", array)}]"); //вывод


// int[]arr = new int[8];// вывести пустой массив
// Console.WriteLine(arr[7]); //в любом индексе будет 0

// int[]arr = new int[9];//как вывести длину массива
// Console.WriteLine(arr.Length);


// new Random().Next()//новые слова
// arr[0] =5;

//     int n = array.Length;
//     int A = new Random()
//     Console.WriteLine(array[i])
