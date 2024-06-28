// See https://aka.ms/new-console-template for more information

using CRM;

Console.WriteLine("Jay Shree Ram!");


Customer customer = new Customer();

customer.email="ram@gmail.com";
customer.age = 23;
customer.name="Rohit";
customer.contactNumber = "1244219898";
customer.location = "Pune";
Helper.display("ROHIT");

Console.WriteLine(customer);

Helper.display("ROHIT","ABHAY","MANDAR");

List<string>  s1= new List<string>();

s1.Add("DAC");
s1.Add("DBDA");
s1.Add("DITISS");
customer.History=s1;
Console.WriteLine();
Console.WriteLine();
foreach (string h in customer.History)
{
    Console.WriteLine(h);
}
