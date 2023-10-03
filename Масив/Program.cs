int[] arr = new int[12];

void FillArray( int[] arr)
{
    Random rd = new Random();
    for(int i =0;i < arr.Length;i++)
    {
        arr[i] = rd.Next(-9,9);
    }
}

void PrintArray( int[] arr)
{
    for(int i =0;i < arr.Length;i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

FillArray(arr);
PrintArray(arr);