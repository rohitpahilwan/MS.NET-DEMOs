// See https://aka.ms/new-console-template for more information
using Catalog;
using OrderProcessing;
Console.WriteLine("Enter Name...");
string name = Console.ReadLine();
Console.WriteLine("Hello...."+name);
Console.WriteLine("Enter ID , Name , Salary ");
Product c1=new Product(int.Parse(Console.ReadLine()),Console.ReadLine(), double.Parse(Console.ReadLine()));
Console.WriteLine(c1);