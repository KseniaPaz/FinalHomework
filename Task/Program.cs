using static System.Console;
WriteLine("Введите массив через пробел: ");
string[] array = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

PrintArray(array);
WriteLine();


void PrintArray(string[] inArray)
{
    Write("[");
    for(int i=0; i<inArray.Length-1; i++)
    {
      Write($"{inArray[i]}, ");  
    }
    Write($"{inArray[inArray.Length-1]}]");
}
