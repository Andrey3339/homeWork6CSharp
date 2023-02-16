int K = 0;
void RepositionSymbol(string s, int p1, int p2)
{
    if (p1 == p2)
    {
        K++;
        Console.WriteLine(s + " " + K);
    }
    else
    {
        for (int i = p1; i <= p2; i++)
        {
            s = Swap(s, p1, i);
            RepositionSymbol(s, p1 + 1, p2);
        }
    }
}
string Swap(string str, int i, int j)
{
    var charArray = str.ToCharArray();
    char temp = charArray[i];
    charArray[i] = charArray[j];
    charArray[j] = temp;
    return new String(charArray);
}

Console.Clear();
Console.WriteLine("Введите последовательность символов от 1 до 8");
string s = Console.ReadLine().ToUpper();
RepositionSymbol(s, 0, s.Length - 1);

