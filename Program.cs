  // Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
  //Напишите программу, которая покажет количество чётных чисел в массиве.
  //[345, 897, 568, 234] -> 2
 /*int[] array = GetArray(15, 99, 1000);
Console.WriteLine($"[{String.Join(", ", array)}]");
int count = 0;
for(int i = 0; i < array.Length; i++)
{
if(array[i]%2! == 0)
{
    count = count + 1;
}
}
Console.Write($"Количество чётных чисел в массиве: {count}");
//Метод--------------------------------------------------------
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue);
    }
    return res;
}*/
//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму 
//элементов, стоящих на нечётных позициях. [3, 7, 23, 12] -> 19  [-4, -6, 89, 6] -> 0
/*int[] array = GetArray(7, 0, 100);
Console.WriteLine($"[{String.Join(", ", array)}]");
int sum = 0;
for(int i = 1; i < array.Length; i=i+2)
{
    sum = sum + array[i];
}
Console.Write($"Сумма элементов стоящих на нечётных позициях: {sum}");
//Метод--------------------------------------------------------
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue);
    }
    return res;
}*/