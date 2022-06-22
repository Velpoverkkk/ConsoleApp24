using System;
class Program
{   //Подсчитать количество цифр в заданном числе  (с применением рекурсии и без неё)
    static void Main(string[] args)
    {
        Random rnd = new Random();
        int N,n=0;
        System.Console.WriteLine("chislo N");
        N = System.Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine(Norm(N));
        System.Console.WriteLine(Rec(N, n));
    }
    static int Norm(int N)
    {
        int n = 0;
        for (int i = N; i >= 1; i = i / 10)  n++;
        return n;
        
    }
    static int Rec(int N,int n)
    { 
        if (N <= 0) return n;
        else
        {
            n++;
            return Rec(N / 10, n);
        }
    }
}
