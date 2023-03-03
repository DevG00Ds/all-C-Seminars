// // Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// // 45 -> 101101
// // 3  -> 11
// // 2  -> 10

// int n = 44;

// int countOfDigits = 0 ;
// int nCopy = n;

// while ( nCopy != 0 )
// {
//     nCopy /= 2;
//     countOfDigits++;  
// }

// Console.WriteLine( countOfDigits);

// int[] binaryNumbers = new int[countOfDigits];

// for ( int i = 0; i < binaryNumbers.Length; i++)
// {
//     binaryNumbers[i] = n % 2 ;
//     n /= 2; 
// }

// void ReverseArray(int[] array)
// {
//     for (int i = 0; i < array.Length / 2; i++)
//     {
//         int temp = array[i];
//         array[i] = array[array.Length - i - 1];
//         array[array.Length - i - 1] = temp;
//     }

// }

// Console.WriteLine(string.Join(", ", binaryNumbers));
// ReverseArray(binaryNumbers);
// Console.WriteLine(string.Join(", ", binaryNumbers));


int n = 44; 

void PrintBinary( int n)
{
    if ( n == 0) return;
    PrintBinary( n/2);
    Console.Write(n % 2);
}

PrintBinary(n);