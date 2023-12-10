// Задача 1: Напишите программу, которая принимает на вход число и проверяет,
//  кратно ли оно одновременно 7 и 23.

// int num = new Random().Next();
// Console.Write(num);
// if (num % 7 == 0 && num % 23 == 0)
// {
// Console.WriteLine("Да");
// }

// else
// {
//     Console.WriteLine( "Нет");
// }

// // Задача 2: Напишите программу, которая принимает на вход координаты точки 
// (X и Y),причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, 
// в которой находится эта точка.

// // Вариант1. Случайные числа.
// int X = new Random().Next();
// int Y = new Random().Next();
// // int X = -4;
// // int Y = 6;
// Console.Write(X + ",");
// Console.WriteLine(Y);
// if (X != 0 && Y != 0)
// if(X>0 && Y>0)
// {
//     Console.WriteLine("Точка находится в первой координатной четверти");
// }
//     else if(X>0 && Y<0)
//     {
//         Console.WriteLine("Точка находится во второй координатной четверти");
//     }
//     else if(X<0 && Y<0)
//     {
//         Console.WriteLine("Точка находится в третьей координатной четверти");
//     }
//     else if(X<0 && Y>0)
//     {
//         Console.WriteLine("Точка находится в четвертой координатной четверти");
//     }
// // Вариант2. Числа вводит пользователь.

// {Console.Write("Введите координату X: ");
//         double x = Convert.ToDouble(Console.ReadLine());

//         Console.Write("Введите координату Y: ");
//         double y = Convert.ToDouble(Console.ReadLine());

//         if (x != 0 && y != 0)
//         {
//             if (x > 0)
//             {
//                 if (y > 0)
//                 {
//                     Console.WriteLine("Точка находится в первой четверти.");
//                 }
//                 else
//                 {
//                     Console.WriteLine("Точка находится в четвертой четверти.");
//                 }
//             }
//             else
//             {
//                 if (y > 0)
//                 {
//                     Console.WriteLine("Точка находится во второй четверти.");
//                 }
//                 else
//                 {
//                     Console.WriteLine("Точка находится в третьей четверти.");
//                 }
//             }
//         }
//         else
//         {
//             Console.WriteLine("X и Y не должны быть равны 0.");
//         }
//     }




// Задача 3: Напишите программу, которая принимает на вход целое число из 
// отрезка [10, 99] и показывает наибольшую цифру числа.

// int num = new Random().Next(10, 100);
// Console.Write(num);

// Console.WriteLine();
// int a = num/10;
// int b = num%10;
// int max= a;

// if(a > max) max = a;
// if(b > max) max = b;

// Console.Write(max);


// Задача 4: Напишите программу, которая на вход принимает натуральное число N,
// //  а на выходе показывает его цифры через запятую.

//Вариант1.
// int num = new Random().Next();
// Console.Write(num);

// Console.WriteLine();

// while (num>0)
// {
//     Console.Write(num%10 + ",");
//     num = num/10;
// }
//Вариант2.
// int num = new Random().Next();
// string newNum = "";

// Console.Write(num);

// Console.WriteLine();

// while (num>0)
// {
//     newNum=newNum+ (num%10).ToString();
//     num = num/10;
// }
// for (int i =0; i<newNum.Length; i++)
// {
//     Console.Write(newNum[newNum.Length-1-i] + ",");
// }