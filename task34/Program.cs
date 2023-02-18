/* Задайте массив заполненный случайными положительными трёхзначными числами. Напишите
программу, которая покажет количество чётных чисел в массиве */

int [] GetArray(int size, int minValue, int maxValue)
{

    int [] result = new int [size];
    for (int i = 0; i < size; i++)

    {
        result[i]= new Random().Next (minValue, maxValue + 1);
    }
    return result;
}
    Console.Clear();

int Result(int[] inArray)
{
    int count = 0;
    foreach (int element in inArray)
    {
        if(element / 2 == 0);
        {
            count++;
        }
    }
    return count;
}

int [] array = GetArray(6, 100, 1000);
Console.WriteLine(String.Join(", ", array));
int count = Result(array);
Console.WriteLine(count);