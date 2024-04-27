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

Blog blog2 = new Blog()
{

    Id = Guid.NewGuid().ToString(),
    Author = "Test Author2",
    Content = "Test Content2",
    Title = "Test Title2"
};
blog2.Dump();
Blog blog3 = new Blog()
{

    Id = Guid.NewGuid().ToString(),
    Author = "Test Author2",
    Content = "Test Content2",
    Title = "Test Title2"
};
blog3.Dump();

Console.ReadKey();

public class Blog
{
    public string Id { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public string Content { get; set; }
}