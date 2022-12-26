string[] array = { "hello", "2", "world", ":-)" };
Console.WriteLine("Выводим заданный массив: ");
PrintArray(array);
string[] sortingArray = SortingArray(array);
Console.WriteLine("Выводим отсортированный массив длинной меньше либо равно 3 символа: ");
PrintArray(sortingArray);

void PrintArray(string[] arr)
{
   
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

string[] SortingArray(string[] array)
{
    string[] sortingArray = new string[array.Length];
    int temp = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            sortingArray[temp] = array[i];
            temp++;
        }
    }
    return sortingArray;
}