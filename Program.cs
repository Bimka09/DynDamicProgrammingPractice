using DynamicProgrammingPractice;

Console.WriteLine(DynamicTasks.LCD(10, 5));
var tree = new int[,] 
        { 
            { 1, 0, 0 ,0}, 
            { 2, 3, 0, 0},
            { 4, 5, 6, 0},
            { 9, 8, 0, 3},
        };
Console.WriteLine(DynamicTasks.Tree(tree));
Console.WriteLine(DynamicTasks.CountAmountOfNumbers(5));

var map = new int[,]
        {
            { 1, 0, 0 ,0, 1},
            { 0, 0, 0, 1, 0},
            { 0, 0, 1, 1, 0},
            { 0, 1, 0, 0, 1},
            { 0, 1, 0, 0, 1},
        };
Console.WriteLine(DynamicTasks.CountIlands(map));
