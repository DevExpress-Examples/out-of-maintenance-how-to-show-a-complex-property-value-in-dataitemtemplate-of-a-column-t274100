using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Collections.Generic;

public class Person {
    private int id;
    private string name;
    private Address address;

    public Person() {

    }
    public Person(int id, string name, Address address) {
        this.id = id;
        this.name = name;
        this.address = address;
    }

    public int Id { get{ return id; } }
    public string Name { get{ return name; } }
    public Address Address { get{ return address; } }

    public List<Person> SelectData() {
        List<Person> persons = new List<Person>();
        persons.Add(new Person(0, "John", new Address("Home Lane", "Homesville")));
        persons.Add(new Person(1, "Henry", new Address("436 1st Ave", "Cleveland")));
        return persons;
    }
}

public class Address {
    string street;
    string city;
    public Address(string street, string city) {
        this.street = street;
        this.city = city;
    }

    public string Street { get { return street; } }
    public string City { get { return city; } }}