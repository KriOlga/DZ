// Задача 1: Задайте одномерный массив из 10 целых чисел от 1 до 100. 
// Найдите количество элементов массива, значения которых лежат в отрезке [20,90].

// int[] array = new int[10];
// int count = 0;

// for(int i =0; i<array.Length; i++)
// {
//     array[i] = new Random().Next(1, 101);
//     Console.Write(array[i] + " ");

// if(array[i]>19 && array[i]<91)
//     {
//         count++;
//     }
// }

// Console.WriteLine("Количество элементов" +count);



// Задача 2: Задайте массив на 10 целых чисел. Напишите программу, которая 
// // определяет количество чётных чисел в массиве.

// int[] array = new int[10];
// int count = 0;

// for(int i =0; i<array.Length; i++)
// {
//     array[i] = new Random().Next();
//     Console.WriteLine(array[i] + " ");

//     if(array[i]%2 == 0)
//     {
//         count++;
//     }
// }
// Console.WriteLine("Количество четных элементов" +count);



// Задача 3: Задайте массив из вещественных чисел с ненулевой дробной частью.
//  Найдите разницу между максимальным и минимальным элементов массива.

// double[] array = new double[5];

// for(int i =0; i<array.Length; i++)
// {
//     array[i] = new Random().NextDouble();
//     Console.Write(array[i].ToString("F2") + " ");
// }

// Console.WriteLine();

// double max = array[0];
// double min = array[0];

// for(int i =0; i<array.Length; i++)
// {
//     if(array[i] > max)
//     {
//         max = array[i];
//     }
//     if(array[i] < min)
//     {
//         min = array[i];
//     }
// }

// string stmax = max.ToString("F2");
// string stmin = min.ToString("F2");
// Console.WriteLine(stmax);
// Console.WriteLine(stmin);

// double result = max- min;
// string stresult = result.ToString("F2");
// Console.WriteLine("Разница между максимальным и минимальным элементами массива" +" " + (stresult));



// Задача 4**(не обязательно): Дано натуральное число в диапазоне от 1 до 100 000. 
// Создайте массив, состоящий из цифр этого числа. Старший разряд числа должен 
// располагаться на 0-м индексе массива, младший – на последнем. Размер массива 
// должен быть равен количеству цифр.


// Console.WriteLine("Введите число");
// int number= Convert.ToInt32(Console.ReadLine());
// int[]array = new int[number+1];
// array[0] = number/10;

// for( int i=0; i<array.Length; i++)
// {
//     if(number>1 && number<100000)
//     {
//         array[i]= number%10;
//         number = number/10;
        
//     }
// }
// for( int i=number; i<array.Length; i--)
// {
//     Console.Write(array[i] +" ");
    
// }






