// Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

// double number  = 3.09232321;
// double numberRound = Math.Round(number,2);
// Console.WriteLine(numberRound);

// double sqrt = Math.Sqrt(5);

Console.Write("x1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("x2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());

double Distance(double x1,double y1,double x2,double y2)
{
    return Math.Round(Math.Sqrt((x1-x2)*(x1-x2) + (y1-y2)*(y1-y2)),2,MidpointRounding.ToZero);
}

Console.WriteLine(Distance(x1,y1,x2,y2));