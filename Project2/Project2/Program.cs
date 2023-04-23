using Project2;
using Project2.Dictonaries;

class Program
{
    public static void Main()
    {
        OpenDict dict = new OpenDict(10);
        Utilities.WriteOutDict(dict.data);

        int size = 4;

        Console.WriteLine("Adding 12");
        dict.Insert(12);
        Utilities.WriteOutDict(dict.data);

        Console.WriteLine("Adding 32");
        dict.Insert(32);
        Utilities.WriteOutDict(dict.data);

        Console.WriteLine("Adding 14");
        dict.Insert(14);
        Utilities.WriteOutDict(dict.data);
        Console.WriteLine("Adding 13");
        dict.Insert(13);
        Utilities.WriteOutDict(dict.data);
        Console.WriteLine("Adding 22");
        dict.Insert(22);
        Utilities.WriteOutDict(dict.data);

        List<int>[] array = new List<int>[10];



        Console.WriteLine($"free space: {((dict.data.Length - dict.itemNumber) / (double)dict.data.Length) * 100}%");
        Utilities.WriteOutDict(dict.data);

    }
}