// 1. Создание исходного массива.
// 2. Заполнение исходного массива.
// 3. Главная задача получения выходного массива.
// 4. Печать массивов.

int[] CreateArray(int count)
{
    return new int[count];
}

void Fill(int[] array, int min, int max)
{
    int len = array.Length;
    for (int i = 0; i < len; i++)
        array[i] = new Random().Next(min, max);
    /*array = Enumerable.Range(1, array.Length)
                        .Select(item =>  new Random().Next(min, max))
                        .ToArray();
                      */
}

string Print(int[] array)
{
    string res = String.Empty;
    int len = array.Length;
    for (int i = 0; i < len; i++)
        res += $"{array[i]} ";
    return res;
}

/*void Print(int [] array)
{
    int len = array.Length;
    for(int i = 0; i < len; i++)
        Console.Write($"{array[i]} ");
}
*/

string Print2(int[] array)
{
    return $"{String.Join(' ', array)}";
}

int[] MainExample(int[] inputArray)
{
    int len = 0;
    int count = inputArray.Length;
    for (int k = 0; k < count; k++)
    {
        if (inputArray[k] % 2 == 0) len++;
    }
    int[] outputArray = new int[len];
    int i, index;
    i = index = 0;

    while (i < count)
    {
        if (inputArray[i] % 2 == 0)
        {
            outputArray[index] = inputArray[i];
            index++;
        }
        i++;
    }
    return outputArray;
}

var inArr = CreateArray(10);
Fill(inArr, 1, 10);
Console.WriteLine($"Исходный массив [{Print2(inArr)}]");
var outArr = MainExample(inArr);
Console.WriteLine($"Выходной массив [{Print(outArr)}]");
