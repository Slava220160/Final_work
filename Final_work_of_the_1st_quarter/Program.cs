using static System.Console;
using System.Linq;
Clear();


WriteLine("Введите массив строк через пробел");
string[] Array = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
int count = (from a in Array where a.Length < 4 select a).Count();
string[] newArray = CreateNewArray(Array, count);
PrintArray(newArray);


string[] CreateNewArray(string[] array, int size)
{
    string[] stringArray = new string[size];
    int j = 0;
    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i].Length < 4)
        {
            stringArray[j] = Array[i];
            j++;
        }
    }
    return stringArray;
}


void PrintArray(string[] array)
{
    Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i != (array.Length - 1)) Write($"{array[i]} ");
        else Write($"{array[i]}");
    }
    Write("]");
    WriteLine();
}
