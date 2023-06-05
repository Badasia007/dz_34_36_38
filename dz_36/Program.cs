//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

int[] array = GetRandomArray(4, -100, 100);
Console.WriteLine(String.Join(", ", array));


int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}


int NeChetnieNumbers(int[] array)
{
    int i = 0;
    int sum = 0;
    
    foreach (int el in array)
    {
        if (i%2 == 0){
            sum = sum + 0;
        } 
        else
        {
            sum = sum + el;
        }   
        i = i + 1;     
    }
    return sum;
}
Console.WriteLine($"Сумма чисел стоящих на нечётных позициях = {NeChetnieNumbers(array)}");
