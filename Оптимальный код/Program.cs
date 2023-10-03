decimal kRec=0;
decimal kIter=0;
int number = Convert.ToInt32(Console.ReadLine());

// decimal FiboRec(int n)
// {
//     kRec++;
//     if (n==1 || n==2) return 1;
//     return FiboRec(n-1)+FiboRec(n-2);   
// }


decimal FiboIter(int n)
{
    int res=1;
    int f0 = 1;
    int f1 = 1;
    kIter++;
    for(int i = 2; i<n;i++)
    {       
        kIter++;
        res = f0+f1;
        f0=f1;
        f1=res;
    }
    return res;
}


// for(int i =1; i <number;i++)
// {
//     Console.WriteLine($"Число фибоначи № {i} = {FiboRec(i)} понадобилось сделать {kRec} запусков");
//     kRec=0;
// }

// Console.WriteLine("-----------------");

for(int n =1; n <number;n++)
{
    Console.WriteLine($"Число фибоначи № {n} = {FiboIter(n)} понадобилось сделать {kIter} запусков");
    kIter=0;
}


// FiboRec(number);
// FiboIter(number);