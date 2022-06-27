// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B

Console.WriteLine("Input the first number");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the second number");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(num1 + "^" + num2 + " = " + Math.Pow(num1, num2));

//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе

// void DigitsSum(int num)
// {
//     int initialNum = num;
//     int sum = 0;
//     int digit = num;
//     while (num >= 1)
//     {
//         digit = num % 10;
//         sum = sum + digit;
//         num = num / 10;
//     }
//     Console.WriteLine(initialNum + " --> " + sum);
// }

// Console.WriteLine("Input number");
// int number = Convert.ToInt32(Console.ReadLine());

// DigitsSum(number);

//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран
// void ArrayEight()
// {

//     for (int i = 0; i < 8; i++)
//     {
//         int[] array = new int [8];
//         array[i] = new Random().Next(1, 100);
//         Console.WriteLine(array[i]);
//     }
// }

// ArrayEight();