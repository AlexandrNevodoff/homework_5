// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

Console.Clear();

void InputArray(double[] array)
{

    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().NextDouble();
}

double FindMax (double[] array)
{
double max=array[0];

    for (int i = 0; i < array.Length; i++)
    {if (array[i]>max) 
    
        {max=array[i];}
    
    }
return max;    
}

double FindMin (double[] array)
{
double min=array[0];

    for (int i = 0; i < array.Length; i++)
    {if (array[i]<min) 
    
        {min=array[i];}
    
    }
return min;    
}

Console.Write("Введите кол-во элементов массива: ");
int lenghtarray =  Convert.ToInt32(Console.ReadLine());
double[] array = new double[lenghtarray];

InputArray(array);
double max=FindMax(array);
double min=FindMin(array);

Console.WriteLine($"[{string.Join(", ", array)}]");
Console.WriteLine($" Максимальный элемент: " + max);
Console.WriteLine($" Минимальный элемент: " + min);
Console.WriteLine($"Разница между ними: "+ (max-min));