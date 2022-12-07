// task 34 Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

Console.Clear();

void InputArray(int[] array)
{

    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(100, 1000);
}

int EvenNumber (int[] array)
{
 
int evenNumberCount = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 ==0) 
    {evenNumberCount = evenNumberCount +1;}
}
return evenNumberCount;
}


Console.Write("Введите кол-во элементов массива: ");
int leghtarray =  Convert.ToInt32(Console.ReadLine());
int[] array = new int[leghtarray];
//int evenNumberCount = 0;
InputArray(array);
int evenNumberCount = EvenNumber(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
Console.WriteLine(evenNumberCount);