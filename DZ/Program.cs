Console.Clear();
string[] Array = { "Hello", "String", "2", "World", ";)", "12", "Rim" };
string[] tempArray = new string[Array.Length];
ArrayMin3(Array, tempArray);
PrintArray(tempArray);

string[] ArrayMin3(string[] Array, string[] tempArray)
{
    int count = 0;
    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i].Length <= 3)
        {
            tempArray[count] = Array[i];
            count++;
        }
    }
    return tempArray;
}

void PrintArray(string[] Array)
{
    for (int i = 0; i < Array.Length; i++)
    {
    System.Console.Write($"{Array[i]} ");
    }
}