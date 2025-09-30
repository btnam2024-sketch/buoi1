using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Create adapter and place a request

        Target target = new Adapter();
        target.Request();

        // Chờ người dùng

        Console.ReadKey();
    }

}


