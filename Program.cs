using System;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        // Отримання тип класу ProductFactory
        Type factoryType = typeof(ProductFactory);

        // Використання TypeInfo
        TypeInfo factoryTypeInfo = factoryType.GetTypeInfo();

        // Отримання інформацію про всі члени класу (поля, методи, властивості, тощо)
        MemberInfo[] members = factoryType.GetMembers();

        Console.WriteLine("Members of ProductFactory class:");
        foreach (var member in members)
        {
            Console.WriteLine(member.Name);
        }

        Console.WriteLine();

        // Отримуємо інформацію про всі поля класу
        FieldInfo[] fields = factoryType.GetFields();

        Console.WriteLine("Fields of ProductFactory class:");
        foreach (var field in fields)
        {
            Console.WriteLine(field.Name);
        }

        Console.WriteLine();

        // Отримання інформацію про всі методи класу
        MethodInfo[] methods = factoryType.GetMethods();

        Console.WriteLine("Methods of ProductFactory class:");
        foreach (var method in methods)
        {
            Console.WriteLine(method.Name);
        }

        Console.WriteLine();

        // Виклик методу AddRevenue через Reflection
        ProductFactory factory = new ProductFactory("MyFactory", 100, DateTime.Now);
        MethodInfo addRevenueMethod = factoryType.GetMethod("AddRevenue");
        object[] parameters = new object[] { 10000 }; // Параметри методу
        addRevenueMethod.Invoke(factory, parameters); // Виклик методу

        // Відображення оновленої інформації про завод
        factory.DisplayFactoryInfo();
    }
}
