//int[] numbers = { 8, 3, 6, 1, 5, 7, 9 };

//Console.WriteLine("Элементы массива:");
//Console.WriteLine(string.Join(", ", numbers));

//Console.WriteLine($"Количество элементов: {numbers.Length}");

//Console.WriteLine("Перебор массива:");

//foreach (int number in numbers)
//{
//    Console.WriteLine(number);
//}
//int[] numbers = { 20, 20 };

//Console.WriteLine("До обмена:");
//Console.WriteLine(string.Join(", ", numbers));

//int temp = numbers[0];
//numbers[0] = numbers[1];
//numbers[1] = temp;

//Console.WriteLine("После обмена:");
//Console.WriteLine(string.Join(", ", numbers));

//int temp2 = numbers[0];
//numbers[0] = numbers[1];

//numbers[1] = temp;

//int[] numbers = { 7, 3, 9, 2 };

//for (int j = 0; j < numbers.Length - 1; j++)
//{
//    if (numbers[j] > numbers[j + 1])
//    {
//        int temp = numbers[j];
//        numbers[j] = numbers[j + 1];
//        numbers[j + 1] = temp;
//    }
//}

//Console.WriteLine(string.Join(", ", numbers));

//for (int i = 0; i < numbers.Length - 1; i++)
//int[] numbers = { 15, 3, 21, 8, 1, 12 };

//for (int i = 0; i < numbers.Length - 1; i++)
//{
//    for (int j = 0; j < numbers.Length - 1; j++)
//    {
//        if (numbers[j] < numbers[j + 1])
//        {
//            int temp = numbers[j];
//            numbers[j] = numbers[j + 1];
//            numbers[j + 1] = temp;
//        }
//    }
//}

//Console.WriteLine("Отсортированный массив:");
//Console.WriteLine(string.Join(", ", numbers));

int[] numbers = { 3, 1, 67, 99, 2, 4, 30 };

Console.WriteLine("До сортировки:");
Console.WriteLine(string.Join(", ", numbers));

Array.Sort(numbers);

Console.WriteLine("После сортировки:");
Console.WriteLine(string.Join(", ", numbers));