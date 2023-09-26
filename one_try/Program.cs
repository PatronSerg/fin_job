static void Main()
{
    Console.Write("Введите элементы массива через пробел: ");
    string input = Console.ReadLine();
    string[] array = input.Split(' ');
    string[] result = FilterArray(array);

    Console.WriteLine("Новый массив:");
    PrintArray(result);
}

