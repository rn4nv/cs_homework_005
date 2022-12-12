Console.Clear();

void FirstArray(int[] col)
{
    int length = col.Length;
    int index = 0;
    
    while (index < length)
    {
        col[index] = new Random().Next(-1000, 1000);
        index++;
    }
}

void PrintArray (int[] collection)
{
    int count = collection.Length;
    int position = 0;

    while (position < count)
    {
        Console.WriteLine(collection[position]);
        position++;
    }

}

int Sum(int[] col)
{
    int count = col.Length;
    int index = 0;
    int res = 0;

    while (index < count)
    {
        if (index % 2 != 0)
        {
            res = res + col[index];
            index++;
        }
        else 
        {
            index++;
        }
    }
    return res;
}

int[] array = new int [4];

FirstArray(array);
PrintArray(array);
Console.WriteLine();

int result = Sum(array);
Console.Write("Сумма элементов, стоящих на нечестных позициях равна: ");
Console.Write(result);