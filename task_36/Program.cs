// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

Console.Clear();


void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(0, 100);
}

int Summ (int[] array)
{
int result = 0;
 for (int i = 1; i < array.Length; i=i+2) {result=result+array[i];}
return result;


}


Console.Write("Введите кол-во элементов массива: ");
int lenghtarray =  Convert.ToInt32(Console.ReadLine());
int[] array = new int[lenghtarray];

InputArray(array);
int result = Summ(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
Console.WriteLine($"Результат: " + result);