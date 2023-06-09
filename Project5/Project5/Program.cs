﻿using Project5;

class Program
{
    static void Main()
    {

        /*
        5
        0 2 0 6 0 
        2 0 3 8 5 
        0 3 0 0 7 
        6 8 0 0 9 
        0 5 7 9 0 

        { 0, 2, 0, 6, 0 },
        { 2, 0, 3, 8, 5 },
        { 0, 3, 0, 0, 7 },
        { 6, 8, 0, 0, 9 },
        { 0, 5, 7, 9, 0 },
        */

        /*
        4
        0 3 0 8 
        3 0 5 4 
        0 5 0 1 
        8 4 1 0

        { 0, 3, 0, 8 },
        { 3, 0, 5, 4 },
        { 0, 5, 0, 1 },
        { 8, 4, 1, 0 },
        */


        int[,] graph = 
        {
            { 0, 3, 0, 8 },
            { 3, 0, 5, 4 },
            { 0, 5, 0, 1 },
            { 8, 4, 1, 0 },
        };

        MSTPrim.Prim(graph);

    }
}