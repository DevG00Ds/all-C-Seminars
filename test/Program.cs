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

int[] myArray1 = GetRandomArray(LENGHT, LEFTBORDER, RIGHTBORDER);
int[] myArray2 = myArray1;

myArray1[0] = 10000;

Console.WriteLine(string.Join(", ", myArray2));
Console.WriteLine(string.Join(", ", myArray1));

int a = 5; 
int b = a;
a = 2; 
Console.WriteLine( a);
Console.WriteLine( b);