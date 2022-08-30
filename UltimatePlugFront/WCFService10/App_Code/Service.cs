using System;
using System.Collections.Generic;
using System.Linq;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class Service : IService
{
    DataClassesDataContext db = new DataClassesDataContext();
    public bool isReg(string email, string password)
    {
        var check = (from d in db.Users
                     where d.Email.Equals(email) && d.Password.Equals(password)
                     select d).FirstOrDefault();
        if (check != null)
        {
            return true;
        }
        else
            return false;
    }

    public int register(UserClass u)
    {

        User addUser = new User
        {

            FirstName = u.FirstName,
            LastName = u.LastName,
            Email = u.Email,
            PhoneNumber = u.PhoneNumber,
            Address = u.Address,
            City = u.City,
            Country = u.Country,
            Password = u.Password,
            ConfirmPassword = u.Confirm,
            Province = u.Province,
            Suburb = u.Suburb,
            Image = u.Image
            
        };
        db.Users.InsertOnSubmit(addUser);
        try
        {
            db.SubmitChanges();
            return 1;
        }
        catch (Exception ex)
        {
            ex.GetBaseException();
            return -1;
        }

    }

    public int logintype(string email, string password)
    {
        var user = (from d in db.Users
                    where d.Email.Equals(email) && d.Password.Equals(password)
                    select d).FirstOrDefault();

        var hirer = (from d in db.Hirers
                     where d.Email.Equals(email) && d.Password.Equals(password)
                     select d).FirstOrDefault();

        /*  var manager = (from d in db.Managers
                         where d.username.Equals(username) && d.password.Equals(password)
                         select d).FirstOrDefault();*/
        if (user != null)
        {
            return 1;
        }
        else if (hirer != null)
        {
            return 2;
        }
        /*  else if (manager != null)
          {
              return 3;
          }*/
        else
        {
            return 0;
        }

    }
   
   public string getHirerMail(int ID)
    {
        var check=(from d in db.Hirers
                   where d.Id.Equals(ID) select d).FirstOrDefault();
        if(check!=null)
        {
            return check.Email;
        }

       else return null;
    }
    public int getHirerID(string email)
    {
        var check = (from d in db.Hirers
                     where d.Email.Equals(email)
                     select d).FirstOrDefault();
        if (check != null)
        {
            return check.Id;
        }
        else

            return 0;
    }

    public int addProduct(int hireID, string prodType, string description, decimal price, string image,string prodName,string businessName,string suburb)
    {
        var add = new Product
        {
            Hirer_ID = hireID,
            Prod_Type = prodType,
            ProductName = prodName,
            Description = description,
            Company_Or_Owner_Name = businessName,
            Price = price,
            Image = image,
            Suburb=suburb
            
        };
        db.Products.InsertOnSubmit(add);
        try
        {
            db.SubmitChanges();
            return 1;
        }catch(Exception ex)
        {
            ex.GetBaseException();
            return 0;
        }
        //throw new NotImplementedException();
    }

    public List<Product> getbyType(string prodType)
    {
        dynamic getProduct = (from d in db.Products
                          where d.Prod_Type.Equals(prodType)
                          select d).ToList();
        List<Product> mylist = new List<Product>();


        if (getProduct != null)
        {
            foreach (Product p in getProduct)
            {
                mylist.Add(p);
            }
            return mylist;
        }
        else return null;        
        

        }
    public Product getSingle(int id)
    {
        var check = (from d in db.Products
                     where d.Id.Equals(id)
                     select d).FirstOrDefault();
        if (check != null)
        {
            return check;
        }
        else return null;
    }
    public string getUserMail(int id)
    {
        var check = (from d in db.Products
                     where d.Id.Equals(id)
                     select d).FirstOrDefault();
        

        if (check != null)
        {
            return check.Company_Or_Owner_Name;
        }
     
        else return null;
  
    }
    public int hire(string ProductName, DateTime date, string time, string username,int hirerID)
    {
        var add = new Hire
        {
            ProductName = ProductName,
            Date = date,
            Time =time,
            CustomerName = username,
            HirerID=hirerID
        };
        db.Hires.InsertOnSubmit(add);
        try
        {
            db.SubmitChanges();
            return 1;
        }catch(Exception ex)
        {
            ex.GetBaseException();
            return 0;
        }
       
    }

    public List<Hire> getEvent(int id)
    {
        dynamic getEvents = (from d in db.Hires
                             where d.HirerID.Equals(id)
                             select d).ToList();
        List<Hire> mylist = new List<Hire>();
        foreach(Hire h in getEvents)
        {
            mylist.Add(h);
        }
        return mylist;
    }

    public int confirmHire(string customerName, string customerMail,string productNAme, DateTime date, string time, string status)
    {
        var add = new VerifyHire
        {
            Name = customerName,
            Email = customerMail,
            Date = date,
            Time = time,
            ProductName = productNAme,
            Status = status
        };
        db.VerifyHires.InsertOnSubmit(add);
        try
        {
            db.SubmitChanges();
            return 1;
        }catch(Exception ex)
        {
            ex.GetBaseException();
            return 0;
        }
    }

    public List<Product> getProducts()
    {
        dynamic getall = (from d in db.Products
                          select d).ToList();
        List<Product> mylist = new List<Product>();
        foreach(Product a in getall)
        {
            mylist.Add(a);
        }
        return mylist;
    }

    public List<Hire> getUserProducts(string username)
    {
        dynamic getProducts = (from d in db.Hires
                               where d.CustomerName.Equals(username)
                               select d).ToList();

        List<Hire> mylist = new List<Hire>();
        foreach(Hire h in getProducts)
        {
            mylist.Add(h);
        }
        return mylist;
    }

    public List<Product> getbySuburb(string type,string Suburb)
    {
        dynamic getAll = (from d in db.Products
                          where d.Suburb.Equals(Suburb) && d.Prod_Type.Equals(type)
                          select d).ToList();

        List<Product> mylist = new List<Product>();
        foreach(Product p in getAll)
        {
            mylist.Add(p);
        }
        return mylist;
    }

    public string getHirerSuburb(int id)
    {
        var getSuburb = (from d in db.Hirers where d.Id.Equals(id) select d).FirstOrDefault();
        if (getSuburb != null)
        {
            return getSuburb.Suburb;
        }
        else return null;

    }

    public string getUserSuburb(string username)
    {
        var getSuburb = (from d in db.Users where d.Email.Equals(username) select d).FirstOrDefault();
        if (getSuburb != null)
        {
            return getSuburb.Suburb;
        }
        else return null;
    }

    public string getCustomer(int ID)
    {
        throw new NotImplementedException();
    }

    public List<Product> searchProduct(string category,string prodName, string suburb)
    {
        dynamic getProducts = (from d in db.Products
                               where d.Prod_Type.Equals(category) && d.ProductName.Equals(prodName) && d.Suburb.Equals(suburb)
                               select d).ToList();
        List<Product> mylist = new List<Product>();
        foreach (Product p in getProducts)
        {
            mylist.Add(p);
        }
        return mylist;
    }
    public List<Product> searchAllP(string category, string prodName)
    {
        dynamic getProducts = (from d in db.Products
                               where d.Prod_Type.Equals(category) && d.ProductName.Equals(prodName) 
                               select d).ToList();
        List<Product> mylist = new List<Product>();
        foreach (Product p in getProducts)
        {
            mylist.Add(p);
        }
        return mylist;
    }

    public int addDriver(string username, string licenceNumber, string NumberPlate, string carName,
        string carImage)
    {
        var add = (from d in db.Users
                   where d.Email.Equals(username)
                   select d).FirstOrDefault();

        if (add != null)
        {
            Driver mydriver = new Driver
            {
                Id=add.Id,
                FirstName = add.FirstName,
                LastName = add.LastName,
                Address = add.Address,
                City = add.City,
                Country = add.Country,
                Image = add.Image,
                LicenseNumber = licenceNumber,
                Email = add.Email,
                Password = add.Password,
                ConfirmPassword = add.ConfirmPassword,
                Suburb = add.Suburb,
                Province = add.Province,
                NumberPlate = NumberPlate,
                PhoneNumber = add.PhoneNumber,
                CarName = carName,
                CarImage = carImage

            };
            db.Drivers.InsertOnSubmit(mydriver);
            try
            {
                db.SubmitChanges();
                return 1;
            }catch(Exception ex)
            {
                ex.GetBaseException();
                return -1;
            }
        }
        else
        {
            return 0;
        }
        //throw new NotImplementedException();
    }

    public List<Driver> getDriverBySuburb(string suburb)
    {
        dynamic getDrivers = (from d in db.Drivers
                              where d.Suburb.Equals(suburb)
                              select d).ToList();
        List<Driver> mylist = new List<Driver>();
    foreach(Driver d in getDrivers)
        {
            mylist.Add(d);
        }
        return mylist;

    }

    public bool isDriverReg(string username)
    {
        var check = (from d in db.Drivers
                     where d.Email.Equals(username)
                     select d).FirstOrDefault();
        if (check != null)
        {
            return true;
        }
        else return false;
    }

    public User getUser(string username)
    {
        throw new NotImplementedException();
    }
}


