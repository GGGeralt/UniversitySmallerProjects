using Project3;

class Program
{
    public static void Main()
    {
        string first = "ABBBBA";
        string second = "BBAC";
        Console.WriteLine(LCS.Find(first, second));
    }
}