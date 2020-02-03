using System;

namespace array{
    class pk
    {
    int[,] array2D = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
    int[,] array2Da = new int[4, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
    string[,] array2Db = new string[3, 2] { { "one", "two" }, { "three", "four" },
                                        { "five", "six" } };
    int[,,] array3D = new int[,,] { { { 1, 2, 3 }, { 4, 5, 6 } },
                                 { { 7, 8, 9 }, { 10, 11, 12 } } };
    int[,,] array3Da = new int[2, 2, 3] { { { 1, 2, 3 }, { 4, 5, 6 } },
                                       { { 7, 8, 9 }, { 10, 11, 12 } } };
    Console.WriteLine(array2D[0, 0]);
    Console.WriteLine(array2D[0, 1]);
    Console.WriteLine(array2D[1, 0]);
    Console.WriteLine(array2D[1, 1]);
    Console.WriteLine(array2D[3, 0]);
    Console.WriteLine(array2Db[1, 0]);
    Console.WriteLine(array3Da[1, 0, 1]);
    Console.WriteLine(array3D[1, 1, 2]);

    var allLength = array3D.Length;
    var total = 1;
    for (int i = 0; i<array3D.Rank; i++) {
    total *= array3D.GetLength(i);
    }
    Console.WriteLine("{0} equals {1}", allLength, total);
    }
}
}