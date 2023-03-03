


int[] GetRandomArray(int lenght, int leftRange, int RightRange)
{
    int[] array = new int[lenght];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(leftRange, RightRange + 1);
    }
    return array;
}

const int LENGHT = 5;
const int LEFTBORDER = -10;
const int RIGHTBORDER = 10;

int[] myArray1 = GetRandomArray(LENGHT, LEFTBORDER, RIGHTBORDER);

int[] myArray2 = new int[myArray1.Length];
for (int i = 0; i < myArray2.Length; i++)
{
    myArray2[i] = myArray1[i];

}

myArray1[0] = 10000;
Console.WriteLine(string.Join(", ", myArray1));
Console.WriteLine(string.Join(", ", myArray2));

