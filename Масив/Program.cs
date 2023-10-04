// int[] arr = new int[12];

// void FillArray( int[] arr)
// {
//     Random rd = new Random();
//     for(int i =0;i < arr.Length;i++)
//     {
//         arr[i] = rd.Next(-9,9);
//     }
// }

// void PrintArray( int[] arr)
// {
//     int positiveNumber=0;
//     int negativeNumber = 0;

//     for(int i =0;i < arr.Length;i++)
//     {
//         if (arr[i] > 0) positiveNumber+=arr[i];
//         else negativeNumber+=arr[i];
//         Console.Write($"{arr[i]} ");
//     }
//     Console.WriteLine();
//     Console.WriteLine($"{positiveNumber} {negativeNumber}");
// }

// FillArray(arr);
// PrintArray(arr);


using System.Drawing;


int[] CreateArray( int size, int min, int max)
{
    int[] arr = new int[size];
    Random rd = new Random();
    for(int i =0;i < arr.Length;i++)
    {
        arr[i] = rd.Next(min,max+1);
    }
    return arr;
}

void PrintArray( int[] arr)
{

    Console.Write("[");
    for(int i =0;i < arr.Length;i++)
    {
        if(i == arr.Length-1) Console.Write($"{arr[i]}");
        else Console.Write($"{arr[i]}, ");
    }
    Console.Write("]");
    Console.WriteLine();
}

int[] array = CreateArray(12,-9,9);
PrintArray(array);


int[] PosNegNumber( int[] arr)
{
    int positiveNumber=0;
    int negativeNumber = 0;

    for(int i =0;i < arr.Length;i++)
    {
        if (arr[i] > 0) positiveNumber+=arr[i];
        else negativeNumber+=arr[i];
    }
    int[] res = new int[]{positiveNumber,negativeNumber};

    return res;
}

int[] SumPosNegElem = PosNegNumber(array);
Console.WriteLine($"{SumPosNegElem[0]} / {SumPosNegElem[1]}");