using System;

class MainApp
{

    static void Main()
    {
        // Mảng creators

        Creator[] creators = new Creator[2];

        creators[0] = new ConcreteCreatorA();
        creators[1] = new ConcreteCreatorB();

        // Lặp lại creators và tạo products

        foreach (Creator creator in creators)
        {
            Product product = creator.FactoryMethod();
            Console.WriteLine("Created {0}",
              product.GetType().Name);
        }

        // Chờ người dùng

        Console.ReadKey();
    }
}
