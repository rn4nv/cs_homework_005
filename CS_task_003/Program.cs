Console.Clear();

void UnnamedArray(double[] collection)
{
    int length = collection.Length;
    int index = 0;

    while (index < length)
    {
        collection[index] = Math.Round(new Random().NextDouble(),5);
        index++;
    }
}

void PrintArray(double[] col)
{
    int count = col.Length;
    int position = 0;

    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

double Diff(double[] collection)
{
    int quantity = collection.Length;
    int index = 0;
    double max = collection[index];
    double min = collection[index];
    double result = 0;


    while (index <= quantity)
    {
        if (index == quantity)
        {
            result = max - min;
            Console.Write("Разница между максимальным и минимальным элементом массива равно: ");
            Console.Write(Math.Round(result, 5));
            break;
        }
        else
        {
            if (collection[index] > max) max = collection[index];
            if (collection[index] < min) min = collection[index];
            index++;
        }

        
    }
    return result;
    

}

double[] array = new double[4];

UnnamedArray(array);
PrintArray(array);
Console.WriteLine();

Diff(array);