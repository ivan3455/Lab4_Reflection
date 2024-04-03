using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ProductFactory
{
    // Поля класу
    private string factoryName;
    public int employeesCount;
    protected double totalRevenue;
    internal bool isOperating;
    public DateTime lastMaintenanceDate;

    // Конструктор класу
    public ProductFactory(string name, int employees, DateTime maintenanceDate)
    {
        factoryName = name;
        employeesCount = employees;
        lastMaintenanceDate = maintenanceDate;
        isOperating = true;
        totalRevenue = 0;
    }

    // Метод для додавання до загального доходу
    public void AddRevenue(double revenue)
    {
        totalRevenue += revenue;
    }

    // Метод для зміни назви заводу
    public void ChangeFactoryName(string newName)
    {
        factoryName = newName;
    }

    // Метод для проведення технічного обслуговування
    protected void PerformMaintenance()
    {
        Console.WriteLine("Performing maintenance on the factory...");
        // Код для обслуговування
        lastMaintenanceDate = DateTime.Now;
    }

    // Метод для відображення інформації про завод
    public void DisplayFactoryInfo()
    {
        Console.WriteLine($"Factory Name: {factoryName}");
        Console.WriteLine($"Employees Count: {employeesCount}");
        Console.WriteLine($"Total Revenue: {totalRevenue}");
        Console.WriteLine($"Last Maintenance Date: {lastMaintenanceDate}");
        Console.WriteLine($"Is Operating: {(isOperating ? "Yes" : "No")}");
    }
}
