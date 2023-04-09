using Project2;
using Project2.Dictonaries;

class Program
{
    public static void Main()
    {
        OpenDict dict = new OpenDict();
        Utilities.WriteOutDict(dict.data);

        dict.Insert(18);
        Utilities.WriteOutDict(dict.data);

        dict.Insert(43);
        dict.Insert(27);
        dict.Insert(10);

        Utilities.WriteOutDict(dict.data);

        dict.Insert(58);

        Utilities.WriteOutDict(dict.data); 
        
        dict.Insert(67);

        Utilities.WriteOutDict(dict.data);

        Console.WriteLine($"seraching for 23 {dict.Find(23)}");
        Console.WriteLine($"seraching for 58 {dict.Find(58)}");
        Console.WriteLine($"seraching for 19 {dict.Find(19)}");

        Utilities.WriteOutDict(dict.data);

        dict.Delete(18);
        Utilities.WriteOutDict(dict.data);

        Console.WriteLine($"seraching for 58 {dict.Find(58)}");

        dict.Insert(17);

        Utilities.WriteOutDict(dict.data);
    }
}