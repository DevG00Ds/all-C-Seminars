// Задача 44:

// const int N = 5 ;

// Console.WriteLine( " Введите число");
// int f = Convert.ToInt32(Console.ReadLine());
// int [] Fibonacci ( int f)

// if ( f<=2) return new int[] { 0 , 1};


const int N = 5 ;

int[] fib = new int[N];

fib[0] = 0;
fib[1] = 1;


for ( int i = 2; i < fib.Length; i++)
{
    fib[i] = fib[i-1] + fib[i-2];
}

Console.WriteLine(string.Join(", ", fib));



