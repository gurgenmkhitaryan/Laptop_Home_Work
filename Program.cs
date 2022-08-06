//  Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу,
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


// int [] array = {345, 587, 988, 456, 464, 267, 248, 862, 159, 148}; 

// int count = 0;

// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] % 2 == 0) count++;
// }
// Console.WriteLine($"Количество четных чисел {count}");



// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

// int [] array = {345, 587, 988, 456, 464, 267, 248, 862, 159, 148}; 

// int summ = 0;

// for (int i = 1; i < array.Length; i+=2)
// {
//     summ = summ + array[i];
// }
// Console.WriteLine($"Сумма нечётных позиции {summ}");


// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

// double [] array = new double[12];

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().NextDouble() * 100;
    
// }

// Console.WriteLine(Math.Round(array,2), String.Join("; ", array));


// !!! ЗАПОЛНЕНИЕ МАССИВА С ПОМОЩЮ ФУНКЦИИ (МЕТОДА)

// int GetArray (int size, int minRandom, int maxRandom);
// {
//     int [] result = new int[size];
//     for (int i = 0; i < result.Length; i++)
//     {
//         result[i] = new Random().Next(minRandom, maxRandom +1);
//     }
//     return result;
// }


int[] GetArray (int size)
{
    int [] result = new int[size];
    for (int i = 0; i < result.Length; i++) 
    {
        result[i] = new Random().Next();
    }
    return result;
}


int array = GetArray(12);
Console.WriteLine($"Резултат: [ {String.Join("; ", array)} ]");
