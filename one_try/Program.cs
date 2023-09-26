
Console.Write("Введите элементы массива через пробел: ");
string input = Console.ReadLine();
string[] array = input.Split(' ');
string[] result = FilterArray(array);

Console.WriteLine("Новый массив:");
PrintArray(result);


static string[] FilterArray(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (ElementValid(array[i]))
        {
            count++;
        }
    }

    string[] result = new string[count];
    int index = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (ElementValid(array[i]))
        {
            result[index] = array[i];
            index++;
        }
    }

    return result;
}


static bool ElementValid(string element)
{
    return element.Length <= 3;
}


static void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i]);
    }
}
