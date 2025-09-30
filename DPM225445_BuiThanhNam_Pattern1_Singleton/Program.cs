using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Hàm khởi tạo được bảo vệ - không thể sử dụng new
        Singleton s1 = Singleton.Instance();
        Singleton s2 = Singleton.Instance();

        // Kiểm tra cùng 1 trường hợp

        if (s1 == s2)
        {
            Console.WriteLine("Objects are the same instance");
        }

        // Chờ đợi người dùng

        Console.ReadKey();
    }
}
