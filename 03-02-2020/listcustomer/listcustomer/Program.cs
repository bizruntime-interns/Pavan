using System;
using System.Collections.Generic;

namespace listcustomer
{
    class Program
    {
        public static void Main()
        {
            Customr cust1 = new Customr()
            {
                ID = 101,
                Name = "Rama",
                Salary = 65000
            };
            Customr cust2 = new Customr()
            {
                ID = 202,
                Name = "Shyama",
                Salary = 50000
            };
            Customr cust3 = new Customr()
            {
                ID = 303,
                Name = "Sundhar",
                Salary = 40000
            };
            List<Customr> customrs = new List<Customr>(2);
            customrs.Add(cust1);
            customrs.Add(cust2);
            customrs.Add(cust3);
            for(int i=0; i <= customrs.Count; i++)
            {
                Customr c = customrs[i];
                Console.WriteLine("ID is {0}, Name is {1}, Saralry is {3}", c.ID, c.Name, c.Salary);
            }
            
        }
    }
}
public class Customr
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int Salary { get; set; }
}