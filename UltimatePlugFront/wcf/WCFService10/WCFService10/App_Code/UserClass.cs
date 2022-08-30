using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for UserClass
/// </summary>
public class UserClass
{
    private string firstName;
    private string lastName;
    private string phoneNumber;
    private string address;
    private string province;
    private string city;
    private string country;
    private string password;
    private string email;
    private string confirmpass;
    private string suburb;
    private string image;
    public string Suburb
    {
        get { return suburb; }
        set { suburb = value; }
    }

    public string Image
    {
        get { return image; }
        set { image = value; }
    }
    public string Confirm
    {
        get { return confirmpass; }
        set { confirmpass = value; }
    }
    public string Password
    {
        get { return password; }
        set { password = value; }
    }
    public string Email
    {
        get { return email; }
        set { email = value; }
    }
    public string Country
    {
        get { return country; }
        set { country = value; }
    }
    public string City
    {
        get { return city; }
        set { city = value; }
    }
    public string FirstName
    {
        get { return firstName; }
        set { firstName = value; }
    }
    public string LastName
    {
        get { return lastName; }
        set { lastName = value; }
    }
    public string PhoneNumber
    {
        get { return phoneNumber; }
        set { phoneNumber = value; }
    }



    public string Address
    {
        get { return address; }
        set { address = value; }
    }
    public string Province
    {
        get { return province; }
        set { province = value; }
    }

 

}