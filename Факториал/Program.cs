using System.Xml.XPath;

Console.WriteLine("Ведите наутральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int Factorial(int number)
// {
//     if (number==1) return 1;
//     return number*Factorial(number-1);
// }
{
    int i =1;
    int res=1;
    while(i<=number)
    {
        checked
        {
            res*=i;
        }
        i++;
    }
    return res;
}
int res = Factorial(number);

Console.WriteLine($"Факториал числа {number} = {res} ");