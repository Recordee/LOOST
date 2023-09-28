int[] arr = { 5, 7, 2, 5, 3, 8, 1, 6 };

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