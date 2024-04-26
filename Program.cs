using Dumpify;
using System;

Console.WriteLine("Hello, World!");

new { Name = "Dumpify", Description = "Dump any object to Console" }.Dump();

var arr = new[] { 1, 2, 3, 4 }.Dump();

var arr2d = new int[,] { { 1, 2 }, { 3, 4 } }.Dump();

new Dictionary<string, string>
{
    ["Moaid"] = "Hathot",
    ["Haneeni"] = "Shibli",
    ["Eren"] = "Yeager",
    ["Mikasa"] = "Ackerman",
}.Dump();



Console.ReadKey();