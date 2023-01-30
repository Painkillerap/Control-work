Console.Clear();
string[] ArrayMin3(string[] Array)
{
    int count = Array.Length;
    string[] tempArray = new string[count];
    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i].Length <= 3)
        {
            tempArray[i] = Array[i];
        }
        else
        {
            count=count-1;
        }
    }
    return tempArray;
}

string[] Array = { "Hello", "String", "2", "World", ";)", "12", "Rim" };
Console.Write("Массив: ");
Console.WriteLine("[" + string.Join(", ", Array) + "]");
string[] result=ArrayMin3(Array);

Console.Write("Элементы массива с длинной 3 или меньше: ");
result = result.Where(x => x != null).ToArray();
Console.WriteLine("[" + string.Join(", ", result) + "]");