Console.Clear();

void FirstArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;

    while (index < length)
    {
        collection[index] = new Random().Next(100, 999);
        index++;
    }
}

void PrintArray (int[] col)

{
    int count = col.Length;
    int position = 0;

    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int EvenNum (int[] collection)
{
    int count = collection.Length;
    int index = 0;
    int quantity = 0;

    while (index < count)
    {
        if (collection[index] % 2 == 0)
        {
            quantity++;
            index++;
        }
        else
        {
            index++;
        }
    }
    return quantity;
}

int[] array = new int[4];

FirstArray(array);
PrintArray(array);
Console.WriteLine();

int result = EvenNum(array);
Console.Write("Количество четных чисел в массиве равняется: ");
Console.Write(result);
