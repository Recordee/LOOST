// . Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

int number = new Random().Next(10,100);
// int number1 = number%10;
// int number2 = number/10;
// if (number1 > number2) Console.WriteLine($"{number} {number1}");
// else Console.WriteLine($"{number} {number2}");

// int maxDigit = number1>number2 ? number1 : number2;
// Console.WriteLine($"{number} {maxDigit}");

int result = MaxDigit(number);
Console.WriteLine($"{number} {result}");

int MaxDigit(int num)
{
    int number1 = num%10;
    int number2 = num/10;
    int maxDigit = number1>number2 ? number1 : number2;
    return maxDigit;
}
