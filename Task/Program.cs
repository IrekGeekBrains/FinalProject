// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении рекомендуется пользоваться исключительно массивами.

string[] arrayOne = new string[] { "abc", "ab", "abddd", "abcdc", "ac", "abcd", "abcde", "acb", "aabcd", "a" };
string[] arrayTwo = new string[arrayOne.Length];
void FindArrayTwo(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[count] = array1[i];
            count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}\t ");
    }
    Console.WriteLine();
}
FindArrayTwo(arrayOne, arrayTwo);
System.Console.WriteLine("Первоначальный массив:");
PrintArray(arrayOne);
System.Console.WriteLine();
System.Console.WriteLine("Измененный массив:");
PrintArray(arrayTwo);