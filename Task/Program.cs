using static System.Console;
WriteLine("Введите массив через пробел: ");
string[] array = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
WriteLine();
WriteLine("[{0}]", string.Join(", ", newArray(array)));

string[] newArray(string[] inArray) 
{
    string[] resultArray = new string[NewArraySize(inArray)];
    int count = 0;
    for(var i=0; i<inArray.Length; i++)
    {
        if (inArray[i].Length <= 3)
        {
            resultArray[count] = inArray[i];
            count++;
        }
    }
    return resultArray;

}

int NewArraySize(string[] inArray2) 
{
    int result = 0;
    for(var j=0; j<inArray2.Length; j++)
    {
        if (inArray2[j].Length <= 3)
            result++;
    }
    return result;
}