using Project2;
using Project2.Dictonaries;

class Program
{
    public static void Main()
    {
        OpenDict dict = new OpenDict(10);

        int size = 20;

        for (int i = 0; i < size; i++)
        {
            Console.WriteLine($"Adding {i}");
            Console.WriteLine($"free space: {((dict.data.Length - dict.itemNumber) / (double)dict.data.Length) * 100}%");

            dict.Insert(i);
        }

        Utilities.WriteOutDict(dict.data);


        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Deleting {i}");
            Console.WriteLine($"free space: {((dict.data.Length - dict.itemNumber) / (double)dict.data.Length) * 100}%");

            dict.Delete(i);

        }

        Console.WriteLine($"free space: {((dict.data.Length - dict.itemNumber) / (double)dict.data.Length) * 100}%");
        Utilities.WriteOutDict(dict.data);

    }
}