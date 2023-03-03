// Задача 39: Напишите программу, которая перевернёт 
// одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)

// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]



int[] GetRandomArray(int lenght, int leftRange, int RightRange)
{
    int[] array = new int[lenght];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(leftRange, RightRange + 1);
    }
    return array;
}


void ReverseArray(int[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        int temp = array[i];
        array[i] = array[array.Length - i - 1];
        array[array.Length - i - 1] = temp;
    }

}

const int LENGHT = 5;
const int LEFTBORDER = -10;
const int RIGHTBORDER = 10;

int[] myArray = GetRandomArray(LENGHT, LEFTBORDER, RIGHTBORDER);
Console.WriteLine(string.Join(", ", myArray));

ReverseArray(myArray);
Console.WriteLine(string.Join(", ", myArray));







// int lenght = ReadNumber(" Задайте длинну массива : ");
// int leftRange = ReadNumber(" Задайте левый диапозон чисел : ");
// int RightRange = ReadNumber(" задайте правый диапозон чисел : ");

// int[] array = GetRandomArray(lenght, leftRange, RightRange);