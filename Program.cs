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
//Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый 
//и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
//[1 2 3 4 5]-> 5 8 3  [6 7 3 6]-> 36 21
/*int[] array = GetArray(8, 0, 10);
Console.WriteLine($"[{String.Join(", ", array)}]");
if(array.Length%2! == 0){
int[] arrayNew1 = GetArrayMult1(array);
Console.WriteLine($"[{String.Join(", ", arrayNew1)}]");}
else{
int[] arrayNew2 = GetArrayMult2(array);
Console.WriteLine($"[{String.Join(", ", arrayNew2)}]");
}
//Метод1--------------------------------------------------------
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue);
    }
    return res;
}
//Метод2--------------------------------------------------------
int[] GetArrayMult1 (int[] array)
{
    int[] result = new int[array.Length / 2];
    for (int i = 0; i < array.Length - i; i++)
    {
        result[i] = array[i] * array[array.Length - 1 - i];
    }
    return result;
}
//Метод3--------------------------------------------------------
int[] GetArrayMult2 (int[] array)
{
    int[] result = new int[(array.Length/2)+1];
    for (int i = 0; i < array.Length + 1 - i; i++)
    {
        if(i == array.Length/2) result[i] = array[(array.Length/2)] * 1;
        else result[i] = array[i] * array[array.Length - 1 - i];   
        }
       return result;
    }*/
    

