int[] arr = { 5, 7, 2, 5, 3, 8, 1, 6 };

// int[] arr = new int[8];
// var arr = new int[8];

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionArray(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int min = i;
        for (int j = i + 1; j < array.Length; j++)
            if (array[j] < array[min])
            {
                min = j;
            }
        int temp = array[min];
        array[min] = array[i];
        array[i] = temp;
    }

}

PrintArray(arr);
SelectionArray(arr);
PrintArray(arr);


// void InputArray(int[] array)
// {
// for (int i = 0; i < array.Length; i++)
// array[i] = new Random().Next(-20, 21); // [-20; 20]
// }


// int[] sortVibor(int[] array)
// {
// for (int i = 0; i < array.Length; i++) // Счетчики цикла лучше всего обзывать i, j, k, m, n
// {
// int indexMin = i;
// for (int j = i; j < array.Length; j++)
// {
// if (array[j] < array[indexMin])
// indexMin = j;
// }
// if (array[indexMin] == array[i])
// continue;

// int temp = array[i];
// array[i] = array[indexMin];
// array[indexMin] = temp;
// }
// return array;
// }


// Console.Clear();
// Console.Write("Введите кол-во элементов массива: ");
// int n = int.Parse(Console.ReadLine()!);
// int[] array = new int[n];
// InputArray(array);
// Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
// Console.WriteLine($"Конечный массив: [{string.Join(", ", sortVibor(array))}]");