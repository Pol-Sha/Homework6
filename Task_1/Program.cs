// Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3



int[] inputArray ()
{
Console.Write("Введите количество элементов: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int [size];
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine($"Введите значение для {i} - го элемента массива : ");
    array[i]= Convert.ToInt32(Console.ReadLine());
}
return array;
}
int[] printArray(int[] array)
{
Console.WriteLine("Элементы массива: ");
for (int i = 0; i < array.Length; i++)
{
Console.Write($"{array[i]} \t");
}
Console.WriteLine();
return array;
}

int CountToDigit(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
            count++;
    }
    return count;
}


int[] arr = inputArray();
printArray(arr);
Console.WriteLine($"Положительных элементов в массиве = {CountToDigit(arr)}");
