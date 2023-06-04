//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int[] array = GetRandomArray(10, 100, 999);
Console.WriteLine(String.Join(", ", array));
int ChetnieNumbers = 0;

int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}

foreach (int el in array)//[1, 2, 3, 4, -5, 1, -3] el = -5
{
    if (el%2 == 0){
    ChetnieNumbers = ChetnieNumbers + 1;
    } 
}

Console.WriteLine($"количество чётных чисел в массиве = {ChetnieNumbers}");

