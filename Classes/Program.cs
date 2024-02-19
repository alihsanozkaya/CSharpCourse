﻿namespace Classes;

class Program
{
    static void Main(string[] args)
    {
        CustomerManager customerManager = new CustomerManager();
        customerManager.Add();
        customerManager.Update();
        ProductManager productManager = new ProductManager();
        productManager.Add();
        productManager.Update();

        Customer customer = new Customer();
        customer.City = "Ankara";
        customer.Id = 1;
        customer.FirstName = "Engin";
        customer.LastName = "Demiroğ";

        Customer customer2 = new Customer
        {
            Id = 2, City = "Gaziantep", FirstName = "Ali İhsan", LastName = "Özkaya"
        };

        Console.WriteLine(customer2.FirstName);
    } 
}