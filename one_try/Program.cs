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