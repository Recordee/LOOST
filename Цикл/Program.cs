void PrintMatrix(int[,] matr)
{
    for(int row = 0;row < matr.GetLength(0);row++)
        {
        for(int colomns = 0;colomns < matr.GetLength(1);colomns++)
            {
                Console.Write($"{matr[row,colomns]} ");
            }
        Console.WriteLine();
        }       
}

int[,] RandomNumber(int[,] matrRandom) // void
{
    for(int row = 0;row < matrRandom.GetLength(0);row++)
        {
        for(int colomns = 0;colomns < matrRandom.GetLength(1);colomns++)
            {
                int number = new Random().Next(1,100);
                matrRandom[row,colomns] = number;
            }
        }
    return matrRandom;
}

int[,] matrix = new int[3,4];
PrintMatrix(matrix);
RandomNumber(matrix);
Console.WriteLine();
PrintMatrix(matrix);
