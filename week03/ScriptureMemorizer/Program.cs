using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");


        Scripture scrip1 = new Scripture();
        Reference ref1 = new Reference();
        Console.WriteLine($"{ref1.GetReference()} {scrip1.Display()}");
    }
}