using System;
using System.Collections.Generic;
using System.Linq;

class Persons
{
    public static void Main()
    {
        List<Person> person = new List<Person>();
        Person p1 = new Person();
        p1.SetId(010);
        p1.SetName("Ram");
        p1.SetAge(26);
        p1.SetAddress("UP-Aayodhya");
        Person p2 = new Person();
        p2.SetId(011);
        p2.SetName("Shek");
        p2.SetAge(21);
        p2.SetAddress("Telangana-kamam");
        Person p3 = new Person();
        p3.SetId(013);
        p3.SetName("Rasikh");
        p3.SetAge(23);
        p3.SetAddress("Bangalore-RR nagar");

        person.Add(p1);
        person.Add(p2);
        person.Add(p3);

        DisplayPersonInfo(person);
    }

    public static void DisplayPersonInfo(List<Person> person)
    {
        for (int i = 0; i < person.Count; i++)
        {
            Person p1 = person[i];
            Console.WriteLine("Id = {0}, Name = {1}, Age = {2}, Address = {3}", p1.GetId(), p1.GetName(), p1.GetAge(), p1.GetAddress());
        }
    }
}
public class Person
{
    private int Id;
    private string Name;
    private int Age;
    private string Address;
    public void SetId(int Id)
    {
        this.Id = Id;
    }
    public int GetId()
    {
        return this.Id;
    }
    public void SetName(string Name)
    {
        this.Name = Name;
    }
    public string GetName()
    {
        return this.Name;
    }
    public void SetAge(int Age)
    {
        this.Age = Age;
    }
    public int GetAge()
    {
        return this.Age;
    }
    public void SetAddress(string Address)
    {
        this.Address = Address;
    }
    public string GetAddress()
    {
        return this.Address;
    }
}
