using System;

public class Program
{
    public static void Main(string[] args)
    {
        Abstraction ab = new RefinedAbstraction();

        // Set implementation and call

        ab.Implementor = new ConcreteImplementorA();
        ab.Operation();

        // Change implemention and call

        ab.Implementor = new ConcreteImplementorB();
        ab.Operation();

        // Chờ người dùng

        Console.ReadKey();
    }
}