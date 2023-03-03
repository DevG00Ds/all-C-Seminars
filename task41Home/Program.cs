// Задача 41: 
//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3



int ReadNumber(string messageToUser)
{
    Console.Write(messageToUser);
    return Convert.ToInt32(Console.ReadLine());
}

int [] LengthArray( int length)
{
    int [] array = new int [length];
    for ( int z = 0; z < array.Length; z++)
    {
        array[z] = ReadNumber($" Введенное {z} число : ");
    }
    return array;
}

int PositiveNumbers(int[] array)
{
    int count = 0; 
    for ( int i = 0; i < array.Length; i++)
    {
        if ( array[i]> 0)
        {
            count++;
        }
    }
    return count;
}

int n = ReadNumber(" Введите длинну массива : ");
int[] myArray = LengthArray(n);
int res = PositiveNumbers(myArray);
Console.WriteLine($"Было введено {res} положительных чисел");