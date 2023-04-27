
using Project4;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static int MAX = int.MaxValue;
    static void Main()
    {
        List<string> points = new List<string>()
        {
            "A",
            "B",
            "C",
            "D",
            "E",
        };
        int[,] distances = new int[,]
        {
            {   0,   2,   4, MAX, MAX},
            { MAX,   0,   3,   3, MAX},
            { MAX, MAX,   0,  -1,   4},
            { MAX, MAX, MAX,   0,   2},
            { MAX, MAX, MAX, MAX,   0},
        };

        Algorithmer algorithmer = new Algorithmer(points, distances);

        algorithmer.Run();

        algorithmer.PrintState();
    }
}