using System;

public class Program
{
    public static void Main()
    {
        Singleton s1 = Singleton.Instance();
        Singleton s2 = Singleton.Instance();

        if (s1 == s2)
        {
            Console.WriteLine("Same instance");
        }

        Console.ReadKey(); // giữ console không bị đóng ngay
    }
}

public class Singleton
{
    private static Singleton instance;
    protected Singleton() { }

    public static Singleton Instance()
    {
        if (instance == null)
        {
            instance = new Singleton();
        }
        return instance;
    }
}
