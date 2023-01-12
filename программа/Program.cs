string[] FillArray()
{
    Console.WriteLine("введите количество строк для ввода: ");
    int n = Convert.ToInt32(Console.ReadLine());
    string[] str = new string[n];
    Console.WriteLine("введите строки");
    int i = 0;
    while(i != n)
    {
        str[i] = Console.ReadLine();
        i++;
    }
    return str;
}

void PrintArray(string[] str)
{
    for(int i = 0; i<str.Length; i++)
    {
        Console.Write(str[i] + "; ");
    }
    Console.WriteLine();
}


string[] StringsLeesThanThree(string[] str)
{
    int sizeNewStr = 0;
    for(int i = 0; i < str.Length; i++)
    {
        if(str[i].Length < 4)
        {
            sizeNewStr++;
        }
    }
    string[] newStr = new string[sizeNewStr];
    int k =0;
    for(int i = 0; i < str.Length; i++)
    {
        if(str[i].Length < 4)
        {
            newStr[k] = str[i];
            k++;
        }
    }
    return newStr;
}

PrintArray(
    StringsLeesThanThree(
        FillArray()));
