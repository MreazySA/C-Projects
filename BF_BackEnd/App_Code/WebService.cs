using System.Collections.Generic;
using System.Linq;
using System.Web.Services;
using System;
using System.Data.SqlClient;

namespace P05
{
    [WebService]
    public class WebService : IWebService
    {
        [WebMethod]
        public string Register(TempData tempdata)
        {
            string Message = "";
            BFDataContext db = new BFDataContext();
            // Insert
            db.Users.InsertOnSubmit
            (
              new User
              {
                  First_name = tempdata.First_Name,
                  Last_name = tempdata.Last_Name,
                  Email = tempdata.Email,
                  Phone_number = tempdata.Phone_Number,
                  Password = tempdata.Password,
                  Confirm_Password = tempdata.Confirm_Password ,
                  UserType = tempdata.UserType
              }
            );
            // Retrieve
            var email = (
                           from register1 in db.Users
                           where register1.Email == tempdata.Email
                           select register1.Email
                        );

            var pword1 = (
                             from login1 in db.Users
                             where login1.Email == tempdata.Email
                                && login1.Password == login1.Confirm_Password
                             select login1.Password
                        );
            // Submit
            try
            {
                if (email.Count() != 0)
                {
                    Message = "User Already Exists";
                }
                else
                {
                    if (pword1.Count() != 0)
                    {
                        Message = "Passwords Dont Match";
                    }
                    else
                    {
                        Message = "Signed Up";
                        db.SubmitChanges();
                    }
                }
            }
            catch (SqlException)
            { }
            catch (TimeoutException)
            { }
            // Dispose objects
            db.Dispose();
            //
            return Message;
        }

        [WebMethod]
        public string Login(TempData tempdata)
        {

            string Message = "";
            BFDataContext db = new BFDataContext();
            // Retrieve
            var email = (from field1 in db.Users
                         where field1.Email == tempdata.Email
                         select field1.Email
                        );
            var pass = (from field1 in db.Users
                        where field1.Email == tempdata.Email
                           && field1.Password == tempdata.Password
                        select field1.Password
                       );
            var type = (from field1 in db.Users
                        where field1.Email == tempdata.Email
                           && field1.Password == tempdata.Password
                        select field1.UserType
                       );
            // Submit
            try
            {
                if (email.Count() == 0)
                {
                    Message = "User Email does not Exist";
                }
                else if (pass.Count() != 0)
                {
                    if (type.FirstOrDefault() == "0")
                    {
                        Message = "Customer Login";
                    }
                    if (type.FirstOrDefault() == "1")
                    {
                        Message = "Admin Login";
                    }
                    if (type.FirstOrDefault() == "2")
                    {
                        Message = "Manager Login";
                    }
                }
                else
                {
                    Message = "Wrong Password";
                }
            }
            catch (SqlException)
            { }
            catch (TimeoutException)
            { }
            // Dispose objects
            db.Dispose();
            //
            return Message;
        }
        [WebMethod]
        public TempData GetUser(string email)
        {

            TempData tempdata = new TempData();
            BFDataContext db = new BFDataContext();
            // Retrieve
            var user = (from user1 in db.Users
                         where user1.Email == email
                         select user1
                        );
            // Submit
            try
            {
                if (user.Count() != 0)
                {
                    foreach (User user1 in user)
                    {
                        tempdata.Email = user.First().Email;
                        tempdata.First_Name = user.First().First_name;
                        tempdata.Last_Name = user.First().Last_name;
                        tempdata.Phone_Number = user.First().Phone_number;
                        tempdata.UserType = user.First().UserType;
                    }
                }
                else
                {
                    tempdata = null;
                }
            }
            catch (SqlException)
            { }
            catch (TimeoutException)
            { }
            // Dispose objects
            db.Dispose();
            //
            return tempdata;
        }
        [WebMethod]
        public int NumberOfPets()
        {
            int number = 0;
            BFDataContext db = new BFDataContext();
            //Retrieve
            var Pets = ( from pet1 in db.Pets
                         select pet1.Pet_Id
                       );
            // Submit
            try
            {
                if (Pets.Count() != 0)
                {
                    number = Pets.Max();
                }
            }
            catch (SqlException)
            { }
            catch (TimeoutException)
            { }
            // Dispose objects
            db.Dispose();
            //

            return number;
        }
        [WebMethod]
        public int NumberOfCats()
        {
            int number = 0;
            BFDataContext db = new BFDataContext();
            //Retrieve
            var Pets = (from pet1 in db.Pets
                        where pet1.Pet_Type == "Cat"
                        select pet1.Pet_Id
                        );
            // Submit
            try
            {
                if (Pets.Count() != 0)
                {
                    number = Pets.Max();
                }
            }
            catch (SqlException)
            { }
            catch (TimeoutException)
            { }
            // Dispose objects
            db.Dispose();
            //

            return number;
        }
        [WebMethod]
        public int NumberOfDogs()
        {
            int number = 0;
            BFDataContext db = new BFDataContext();
            //Retrieve
            var Pets = (from pet1 in db.Pets
                        where pet1.Pet_Type == "Dog"
                        select pet1.Pet_Id
                        );
            // Submit
            try
            {
                if (Pets.Count() != 0)
                {
                    number = Pets.Max();
                }
            }
            catch (SqlException)
            { }
            catch (TimeoutException)
            { }
            // Dispose objects
            db.Dispose();
            //

            return number;
        }
        [WebMethod]
        public TempData Get_Pet(string Pet_Name)
        {
            TempData tempdata = new TempData();
            BFDataContext db = new BFDataContext();
            // Retrieve
            var getrow = (
                           from row in db.Pets
                           where row.Pet_Name == Pet_Name
                           select row
                         );
            try
            {
                if (getrow.Count() != 0)
                {
                    // Retrieve Items
                    foreach (Pet pet1 in getrow)
                    {
                        tempdata.Pet_Id = pet1.Pet_Id;
                        tempdata.Pet_Image = pet1.Pet_Image;
                        tempdata.Pet_Name = pet1.Pet_Name;
                        tempdata.Pet_Type = pet1.Pet_Type;
                        tempdata.Pet_Breed = pet1.Pet_Breed;
                        tempdata.Pet_Description = pet1.Pet_Description;
                        tempdata.Pet_Price = pet1.Pet_Price;
                        tempdata.Pet_Quantity = pet1.Pet_Quantity;
                    }
                    //
                }
                else
                {
                    tempdata = null;
                }
            }
            catch (SqlException)
            { }
            catch (TimeoutException)
            { }
            // Dispose objects
            db.Dispose();
            //
            return tempdata;
        }
        [WebMethod]
        public TempData GetPet(int ID)
        {
            TempData tempdata = new TempData();
            BFDataContext db = new BFDataContext();
            // Retrieve
            var getrow = (
                           from row in db.Pets
                           where row.Pet_Id == ID
                           select row
                         );
            try
            {
                if( getrow.Count() != 0)
                {
                    // Retrieve Items
                    foreach (Pet pet1 in getrow )
                    {
                        tempdata.Pet_Id = pet1.Pet_Id;
                        tempdata.Pet_Image = pet1.Pet_Image;
                        tempdata.Pet_Name = pet1.Pet_Name;
                        tempdata.Pet_Type = pet1.Pet_Type;
                        tempdata.Pet_Breed = pet1.Pet_Breed;
                        tempdata.Pet_Description = pet1.Pet_Description;
                        tempdata.Pet_Price = pet1.Pet_Price;
                        tempdata.Pet_Quantity = pet1.Pet_Quantity;
                    }
                    //
                }
                else
                {
                   tempdata = null;
                }
            }
            catch (SqlException)
            { }
            catch (TimeoutException)
            { }
            // Dispose objects
            db.Dispose();
            //
            return tempdata;
        }
        [WebMethod]
        public string RemoveUser(string email)
        {
            string Message = "";
            BFDataContext db = new BFDataContext();
            // Retrieve
            TempData tempdata = GetUser(email);
            var pet = (from row in db.Users
                       where row.Email == email
                       select row
                       );
            // Submit
            try
            {
                if (pet.Count() != 0)
                {
                    db.Users.DeleteOnSubmit(pet.First());
                    // Submit
                    db.SubmitChanges();
                    //
                    Message = "Success";
                }
            }
            catch (SqlException)
            { }
            catch (TimeoutException)
            { }
            // Dispose objects
            db.Dispose();
            //
            return Message;
        }
        [WebMethod]
        public string RemovePet(int ID)
        {
            string Message = "";
            BFDataContext db = new BFDataContext();
            // Retrieve
            TempData tempdata = GetPet(ID);
            var pet = (from row in db.Pets
                       where row.Pet_Id == ID
                       select row
                       );
            // Submit
            try
            {
                if (pet.Count() != 0 )
                {
                    db.Pets.DeleteOnSubmit(pet.First());
                    // Submit
                    db.SubmitChanges();
                    //
                    Message = "Success";
                }
            }
            catch (SqlException)
            { }
            catch (TimeoutException)
            { }
            // Dispose objects
            db.Dispose();
            //
            return Message;
        }
        [WebMethod]
        public List<User> GetCustomers()
        {
            List<User> tempdata = new List<User>();
            BFDataContext db = new BFDataContext();
            // Retrieve
            var getrow = (
                           from row in db.Users
                           where row.UserType == "0"
                           select row
                         );
            try
            {
                if (getrow.Count() != 0)
                {
                    // Retrieve Items
                    foreach (User pet1 in getrow)
                    {
                        tempdata.Add(pet1);
                    }
                    //
                }
                else
                {
                    tempdata = null;
                }
            }
            catch (SqlException)
            { }
            catch (TimeoutException)
            { }
            // Dispose objects
            db.Dispose();
            //
            return tempdata;
        }
        [WebMethod]
        public List<User> GetAdmins()
        {
            List<User> tempdata = new List<User>();
            BFDataContext db = new BFDataContext();
            // Retrieve
            var getrow = (
                           from row in db.Users
                           where row.UserType == "1"
                           select row
                         );
            try
            {
                if (getrow.Count() != 0)
                {
                    // Retrieve Items
                    foreach (User pet1 in getrow)
                    {
                        tempdata.Add(pet1);
                    }
                    //
                }
                else
                {
                    tempdata = null;
                }
            }
            catch (SqlException)
            { }
            catch (TimeoutException)
            { }
            // Dispose objects
            db.Dispose();
            //
            return tempdata;
        }
        [WebMethod]
        public List<User> GetManagers()
        {
           List<User> tempdata = new List<User>();
            BFDataContext db = new BFDataContext();
            // Retrieve
            var getrow = (
                           from row in db.Users
                           where row.UserType == "2"
                           select row
                         );
            try
            {
                if (getrow.Count() != 0)
                {
                    // Retrieve Items
                    foreach (User pet1 in getrow)
                    {
                        tempdata.Add( pet1 );
                    }
                    //
                }
                else
                {
                    tempdata = null;
                }
            }
            catch (SqlException)
            { }
            catch (TimeoutException)
            { }
            // Dispose objects
            db.Dispose();
            //
            return tempdata;
        }
        [WebMethod]
        public TempData GetDog(int ID)
        {
            TempData tempdata = new TempData();
            BFDataContext db = new BFDataContext();
            // Retrieve
            var getrow = (
                           from row in db.Pets
                           where row.Pet_Id == ID
                               && row.Pet_Type == "Dog"
                           select row
                         );
            try
            {
                if (getrow.Count() != 0)
                {
                    // Retrieve Items
                    foreach (Pet pet1 in getrow)
                    {
                        tempdata.Pet_Id = pet1.Pet_Id;
                        tempdata.Pet_Image = pet1.Pet_Image;
                        tempdata.Pet_Name = pet1.Pet_Name;
                        tempdata.Pet_Type = pet1.Pet_Type;
                        tempdata.Pet_Breed = pet1.Pet_Breed;
                        tempdata.Pet_Description = pet1.Pet_Description;
                        tempdata.Pet_Price = pet1.Pet_Price;
                        tempdata.Pet_Quantity = pet1.Pet_Quantity;
                    }
                    //
                }
                else
                {
                    tempdata = null;
                }
            }
            catch (SqlException)
            { }
            catch (TimeoutException)
            { }
            // Dispose objects
            db.Dispose();
            //
            return tempdata;
        }

        [WebMethod]
        public TempData GetCat(int ID)
        {
            TempData tempdata = new TempData();
            BFDataContext db = new BFDataContext();
            // Retrieve
            var getrow = (
                           from row in db.Pets
                           where row.Pet_Id == ID
                               && row.Pet_Type == "Cat"
                           select row
                         );
            try
            {
                if (getrow.Count() != 0)
                {
                    // Retrieve Items
                    foreach (Pet pet1 in getrow)
                    {
                        tempdata.Pet_Id = pet1.Pet_Id;
                        tempdata.Pet_Image = pet1.Pet_Image;
                        tempdata.Pet_Name = pet1.Pet_Name;
                        tempdata.Pet_Type = pet1.Pet_Type;
                        tempdata.Pet_Breed = pet1.Pet_Breed;
                        tempdata.Pet_Description = pet1.Pet_Description;
                        tempdata.Pet_Price = pet1.Pet_Price;
                        tempdata.Pet_Quantity = pet1.Pet_Quantity;
                    }
                    //
                }
                else
                {
                    tempdata = null;
                }
            }
            catch (SqlException)
            { }
            catch (TimeoutException)
            { }
            // Dispose objects
            db.Dispose();
            //
            return tempdata;
        }
        [WebMethod]
        public string AddtoCart(int ID)
        {
            string Message="";
            BFDataContext db = new BFDataContext();
            // Retrieve
            TempData tempdata = GetPet(ID);
               var get_qty= ( from row in db.Carts
                              where row.Pet_Id == ID
                              select row.Pet_Quantity
                            );
               var pet = ( from row in db.Carts
                            where row.Pet_Id == ID
                            select row
                          );
            // Submit
            try
            {
                if (get_qty.Count() == 0)
                {
                    // Add
                    db.Carts.InsertOnSubmit
                    (
                      new Cart
                      {
                          Pet_Id=  tempdata.Pet_Id,
                          Pet_Name = tempdata.Pet_Name ,
                          Pet_Type = tempdata.Pet_Type ,
                          Pet_Breed = tempdata.Pet_Breed ,
                          Pet_Price = tempdata.Pet_Price ,
                          Pet_Quantity = 1
                      }
                   );
                    // Submit
                    db.SubmitChanges();
                    //
                    Message = "Success";
                }
                else
                {
                    // Update
                    foreach ( Cart field1 in pet )
                    {
                        field1.Pet_Id = tempdata.Pet_Id;
                        field1.Pet_Name = tempdata.Pet_Name;
                        field1.Pet_Type = tempdata.Pet_Type;
                        field1.Pet_Breed = tempdata.Pet_Breed;
                        field1.Pet_Price = tempdata.Pet_Price;
                        field1.Pet_Quantity += 1;
                    }
                    // Submit
                    db.SubmitChanges();
                    //
                    Message = "Success";
                }
            }
            catch (SqlException)
            { }
            catch (TimeoutException)
            { }
            // Dispose objects
            db.Dispose();
            //
            return Message;
        }
        [WebMethod]
        public int NumberOfItems()
        {
            int number = 0;
            BFDataContext db = new BFDataContext();
            var Products = (from product1 in db.Carts
                            select product1.Pet_Id 
                            );
            try
            {
                if (Products.Count() != 0)
                {
                    number = Products.Max();
                }
            }
            catch (SqlException)
            {  }
            catch(TimeoutException)
            { }
            // Dispose objects
               db.Dispose();
            //

            return number;
        }
        [WebMethod]
        public TempData GetItems(int ID)
        {
            TempData tempdata = new TempData();
            BFDataContext db = new BFDataContext();
            // Retrieve
            var getrow = (
                           from row in db.Carts
                           where row.Pet_Id == ID
                           select row
                         );
            try
            {
                if (getrow.Count() != 0)
                {
                    // Retrieve Items
                    foreach (Cart pet1 in getrow)
                    {
                        tempdata.Pet_Id = pet1.Pet_Id;
                        tempdata.Pet_Name = pet1.Pet_Name;
                        tempdata.Pet_Type = pet1.Pet_Type;
                        tempdata.Pet_Breed = pet1.Pet_Breed;
                        tempdata.Pet_Price = pet1.Pet_Price;
                        tempdata.Pet_Quantity = pet1.Pet_Quantity;
                    }
                    //
                }
                else
                {
                    tempdata = null;
                }
            }
            catch (SqlException)
            { }
            catch (TimeoutException)
            { }
            // Dispose objects
            db.Dispose();
            //
            return tempdata;
        }
        [WebMethod]
        public string ClearCart()
        {
            string Message="";
            BFDataContext db = new BFDataContext();
            // Retrieve
            var pets = (from row in db.Carts
                        select row
                       );
            // Submit
            try
            {
                if(pets.Count() != 0 )
                {
                    // Update
                    foreach (Cart row1 in pets )
                    {
                        db.Carts.DeleteOnSubmit( row1 );
                    }
                    // Submit
                    db.SubmitChanges();
                    //
                    Message = "Success";
                }
                else
                {
                    Message = "Success";
                }
            }
            catch (SqlException)
            { }
            catch (TimeoutException)
            {}
            // Dispose objects
            db.Dispose();
            //
            return Message;
        }
        [WebMethod]
        public string RemoveFromCart(int ID)
        {
            string Message ="";
            BFDataContext db = new BFDataContext();
            // Retrieve
            TempData tempdata = GetPet(ID);
            var get_qty = (from row in db.Carts
                           where row.Pet_Id == ID
                           select row.Pet_Quantity
                         );
            var pet = (from row in db.Carts
                       where row.Pet_Id == ID
                       select row
                       );
            var pets = (from row in db.Carts
                        select row
                       );
            // Submit
            try
            {
                if ( get_qty.First() == 0)
                {
                       db.Carts.DeleteOnSubmit( pet.First() );
                    // Submit
                    db.SubmitChanges();
                    //
                    Message = "Success";
                }
                else
                {
                    // Update
                    foreach (Cart field1 in pet)
                    {
                        if (tempdata != null)
                        {
                            field1.Pet_Id = tempdata.Pet_Id;
                            field1.Pet_Name = tempdata.Pet_Name;
                            field1.Pet_Type = tempdata.Pet_Type;
                            field1.Pet_Breed = tempdata.Pet_Breed;
                            field1.Pet_Price = tempdata.Pet_Price;
                            field1.Pet_Quantity -= 1;
                        }
                    }
                    // Submit
                    db.SubmitChanges();
                    //
                    Message = "Success";
                }
            }
            catch (SqlException)
            { }
            catch (TimeoutException)
            { }
            // Dispose objects
            db.Dispose();
            //
            return Message;
        }
        [WebMethod]
        public string AddPet(TempData tempdata)
        {
            string Message = "";
            BFDataContext db = new BFDataContext();
            // Insert
            db.Pets.InsertOnSubmit
            (
              new Pet
              {
                  Pet_Id = NumberOfPets() + 1 ,
                  Pet_Breed = tempdata.Pet_Breed,
                  Pet_Description = tempdata.Pet_Description,
                  Pet_Image= "./images/" + tempdata.Pet_Image,
                  Pet_Name = tempdata.Pet_Name,
                  Pet_Price = tempdata.Pet_Price ,
                  Pet_Quantity = tempdata.Pet_Quantity ,
                  Pet_Type = tempdata.Pet_Type
              }
            );
            // Retrieve
            var pet_id = ( from pet in db.Pets
                            where pet.Pet_Image == tempdata.Pet_Image
                            select pet.Pet_Id
                       );
            // Submit
            try
            {
                if ( pet_id.Count() != 0 )
                {
                    Message = "Pet Already Exists";
                }
                else
                {
                    Message = "Pet Added";
                    db.SubmitChanges();
                }
            }
            catch (SqlException)
            { }
            catch (TimeoutException)
            { }
            // Dispose objects
            db.Dispose();
            //
            return Message;
        }
        [WebMethod]
        public int NumberOfOffers()
        {
            int number = 0;
            BFDataContext db = new BFDataContext();
            //Retrieve
            var Offers = ( from offer1 in db.Offers
                           select offer1.Offer_Id
                         );
            // Submit
            try
            {
                if (Offers.Count() != 0)
                {
                    number = Offers.Max();
                }
            }
            catch (SqlException)
            { }
            catch (TimeoutException)
            { }
            // Dispose objects
            db.Dispose();
            //

            return number;
        }
        [WebMethod]
        public string AddOffer(TempData tempdata)
        {
            string Message = "";
            BFDataContext db = new BFDataContext();
            // Insert
            db.Offers.InsertOnSubmit
            (
              new Offer
              {
                  Offer_Id = NumberOfOffers() + 1,
                  Offer_Title = tempdata.Offer_Title,
                  Offer_Type = tempdata.Offer_Type ,
                  Offer_Description = tempdata.Offer_Description,
                  Offer_Image = "./images/" + tempdata.Offer_Image
              }
            );
            // Retrieve
            var offer_id = ( from offer1 in db.Offers
                             where offer1.Offer_Image == tempdata.Offer_Image
                             select offer1.Offer_Id
                           );
            // Submit
            try
            {
                if (offer_id.Count() != 0)
                {
                    Message = "Offer Already Exists";
                }
                else
                {
                    Message = "Offer Added";
                    db.SubmitChanges();
                }
            }
            catch (SqlException)
            { }
            catch (TimeoutException)
            { }
            // Dispose objects
            db.Dispose();
            //
            return Message;
        }
        [WebMethod]
        public TempData GetOffer(int ID)
        {
            TempData tempdata = new TempData();
            BFDataContext db = new BFDataContext();
            // Retrieve
            var getrow = (
                           from row in db.Offers
                           where row.Offer_Id == ID
                           select row
                         );
            try
            {
                if (getrow.Count() != 0)
                {
                    // Retrieve Items
                    foreach (Offer offer1 in getrow)
                    {
                        tempdata.Offer_Id = offer1.Offer_Id;
                        tempdata.Offer_Type = offer1.Offer_Type;
                        tempdata.Offer_Image = offer1.Offer_Image;
                        tempdata.Offer_Title = offer1.Offer_Title;
                        tempdata.Offer_Description = offer1.Offer_Description;
                    }
                    //
                }
                else
                {
                    tempdata = null;
                }
            }
            catch (SqlException)
            { }
            catch (TimeoutException)
            { }
            // Dispose objects
            db.Dispose();
            //
            return tempdata;
        }
        [WebMethod]
        public string RemoveOffer(int ID)
        {
            string Message = "";
            BFDataContext db = new BFDataContext();
            // Retrieve
            TempData tempdata = GetOffer(ID);
            var offer = (from row in db.Offers
                       where row.Offer_Id == ID
                       select row
                       );
            // Submit
            try
            {
                if (offer.Count() != 0)
                {
                    db.Offers.DeleteOnSubmit(offer.First());
                    // Submit
                    db.SubmitChanges();
                    //
                    Message = "Success";
                }
            }
            catch (SqlException)
            { }
            catch (TimeoutException)
            { }
            // Dispose objects
            db.Dispose();
            //
            return Message;
        }
        [WebMethod]
        public string UpdatePet(TempData tempdata)
        {
            string Message = "";
            BFDataContext db = new BFDataContext();
            // Retrieve 
            var code = (from pet in db.Pets
                        where pet.Pet_Id == tempdata.Pet_Id
                        select pet.Pet_Id
                       );
            // Submit
            try
            {
                if (code.Count() != 0)
                {
                    Message = code.First().ToString();
                }
                else
                {
                    Message = "NoSuchProduct";
                }
            }
            catch (SqlException)
            { }
            catch (TimeoutException)
            { }
            // Dispose objects
            db.Dispose();
            //
            return Message;
        }
        [WebMethod]
        public string EditUser(TempData tempdata)
        {
            string Message = "";
            BFDataContext db = new BFDataContext();
            // Retrieve
            var users = (from user in db.Users
                        where user.Email == tempdata.Email
                        select user
                       );
            // Submit
            try
            {
                Message = "User Updated";
                // Update
                foreach (User user1 in users)
                {
                    user1.Email = tempdata.Email;
                    user1.First_name = tempdata.First_Name;
                    user1.Last_name = tempdata.Last_Name;
                    user1.Phone_number = tempdata.Phone_Number;
                    user1.Password = user1.Password;
                    user1.Confirm_Password = user1.Confirm_Password;
                    user1.UserType = tempdata.UserType;
                }
                db.SubmitChanges();
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                Message = ex.Message;  // For Programmer : Check Errors
                Message = "Connection timed out";
            }
            // Dispose objects
            db.Dispose();
            //
            return Message;
        }
        [WebMethod]
        public string EditPet(TempData tempdata)
        {
            string Message = "";
            BFDataContext db = new BFDataContext();
            // Retrieve
            var pets = ( from pet in db.Pets
                         where pet.Pet_Id == tempdata.Pet_Id
                         select pet
                       );
            // Submit
            try
            {
               Message = "Pet Updated";
               // Update
                  foreach (Pet field1 in pets)
                  {
                    field1.Pet_Id = tempdata.Pet_Id;
                    field1.Pet_Breed = tempdata.Pet_Breed;
                    field1.Pet_Description = tempdata.Pet_Description;
                    field1.Pet_Image = tempdata.Pet_Image;
                    field1.Pet_Price = tempdata.Pet_Price;
                    field1.Pet_Name = tempdata.Pet_Name;
                    field1.Pet_Quantity = tempdata.Pet_Quantity;
                    field1.Pet_Type = tempdata.Pet_Type;
                }
                db.SubmitChanges();
            }
            catch (SqlException)
            { }
            catch (TimeoutException)
            { }
            // Dispose objects
            db.Dispose();
            //
            return Message;
        }
        [WebMethod]
        public string EditOffer(TempData tempdata)
        {
            string Message = "";
            BFDataContext db = new BFDataContext();
            // Retrieve
            var offers = ( from offer1 in db.Offers
                           where offer1.Offer_Id == tempdata.Offer_Id
                           select offer1
                         );
            // Submit
            try
            {
                Message = "Offer Updated";
                // Update
                foreach (Offer field1 in offers)
                {
                    field1.Offer_Id = tempdata.Offer_Id;
                    field1.Offer_Description = tempdata.Offer_Description;
                    field1.Offer_Image = tempdata.Offer_Image;
                    field1.Offer_Title = tempdata.Offer_Title;
                    field1.Offer_Type = tempdata.Offer_Type;
                }
                db.SubmitChanges();
            }
            catch (SqlException)
            { }
            catch (TimeoutException)
            { }
            // Dispose objects
            db.Dispose();
            //
            return Message;
        }
        [WebMethod]
        public string Add_Item(TempData tempdata)
        {
            string Message="";
            BFDataContext db = new BFDataContext();
            // Insert
            db.Invoice1s.InsertOnSubmit
            (
              new Invoice1
              {
                  First_name = tempdata.First_Name,
                  Last_name = tempdata.Last_Name,
                  Email = tempdata.Email,
                  Phone_number = tempdata.Phone_Number,
                  UserType = tempdata.UserType,

                  
                  Pet_Id = tempdata.Pet_Id,
                  Pet_Breed=tempdata.Pet_Breed,
                  Pet_Name=tempdata.Pet_Name,
                  Pet_Price=tempdata.Pet_Price,
                  Pet_Quantity=tempdata.Pet_Quantity,
                  Pet_Type=tempdata.Pet_Type,
                 
                  Card_Number=tempdata.Card_Number,
                  Date= tempdata.Date,
                  Country=tempdata.Country,
                  Street_Address=tempdata.Street_Address,
                  City=tempdata.City,
                  Province_State=tempdata.Province_State,
                  ZIP_Code=tempdata.Zip_Code
              }
            );

            db.Invoice2s.InsertOnSubmit
            (
              new Invoice2
              {
                  First_name = tempdata.First_Name,
                  Last_name = tempdata.Last_Name,
                  Email = tempdata.Email,
                  Phone_number = tempdata.Phone_Number,
                  UserType = tempdata.UserType,


                  Pet_Id = tempdata.Pet_Id,
                  Pet_Breed = tempdata.Pet_Breed,
                  Pet_Name = tempdata.Pet_Name,
                  Pet_Price = tempdata.Pet_Price,
                  Pet_Quantity = tempdata.Pet_Quantity,
                  Pet_Type = tempdata.Pet_Type,

                  Card_Number = tempdata.Card_Number,
                  Date = tempdata.Date,
                  Country = tempdata.Country,
                  Street_Address = tempdata.Street_Address,
                  City = tempdata.City,
                  Province_State = tempdata.Province_State,
                  ZIP_Code = tempdata.Zip_Code
              }
            );
            //Submit
            try
            {
               db.SubmitChanges();
               Message = "Success";
            }
            catch (SqlException ex){ Message = ex.Message;  }
            catch (TimeoutException ex) { Message = "Failure"; }
           
            return Message;
        }
        [WebMethod]
        public TempData GetInvoiceUser(TempData tempdata1)
        {

            TempData tempdata = new TempData();
            BFDataContext db = new BFDataContext();
            // Retrieve
            var user = (from user1 in db.Invoice1s
                        where user1.Email == tempdata1.Email
                           && user1.Date.Year == tempdata1.Date.Year
                           && user1.Date.Month == tempdata1.Date.Month
                           && user1.Date.Day == tempdata1.Date.Day
                        select user1
                        );
            var temp = user.ToArray();
            // Submit
            try
            {
                if (user.Count() != 0)
                {
                        tempdata.Email = user.First().Email;
                        tempdata.First_Name = user.First().First_name;
                        tempdata.Last_Name = user.First().Last_name;
                        tempdata.Phone_Number = user.First().Phone_number;
                        tempdata.UserType = user.First().UserType;

                        tempdata.Card_Number = temp.ElementAt(temp.Length - 1).Card_Number;
                        tempdata.Date = temp.ElementAt(temp.Length - 1).Date;
                        tempdata.Country = temp.ElementAt(temp.Length - 1).Country;
                        tempdata.Street_Address = temp.ElementAt(temp.Length - 1).Street_Address;
                        tempdata.City = temp.ElementAt(temp.Length - 1).City;
                        tempdata.Province_State = temp.ElementAt(temp.Length - 1).Province_State;
                        tempdata.Zip_Code = temp.ElementAt(temp.Length - 1).ZIP_Code;
                }
                else
                {
                    tempdata = null;
                }
            }
            catch (SqlException)
            { }
            catch (TimeoutException)
            { }
            // Dispose objects
            db.Dispose();
            //
            return tempdata;
        }

        [WebMethod]
        public TempData GetInvoicePet(TempData tempdata1)
        {

            TempData tempdata = new TempData();
            BFDataContext db = new BFDataContext();
            // Retrieve
            var user = (from user1 in db.Invoice1s
                        where user1.Email == tempdata1.Email
                           && user1.Date.Year == tempdata1.Date.Year
                           && user1.Date.Month == tempdata1.Date.Month
                           && user1.Date.Day == tempdata1.Date.Day
                           && user1.Pet_Id == tempdata1.Pet_Id
                        select user1
                        );

            var temp = user.ToArray();
            // Submit
            try
            {
                if (user.Count() != 0)
                {
                    foreach (Invoice1 user1 in user)
                    {
                        tempdata.Pet_Id = temp.ElementAt(temp.Length - 1).Pet_Id;
                        tempdata.Pet_Name = temp.ElementAt(temp.Length - 1).Pet_Name;
                        tempdata.Pet_Breed = temp.ElementAt(temp.Length - 1).Pet_Breed;
                        tempdata.Pet_Price = temp.ElementAt(temp.Length - 1).Pet_Price;
                        tempdata.Pet_Quantity = temp.ElementAt(temp.Length - 1).Pet_Quantity;
                        tempdata.Pet_Type = temp.ElementAt(temp.Length - 1).Pet_Type;
                    }
                }
                else
                {
                    tempdata = null;
                }
            }
            catch (SqlException)
            { }
            catch (TimeoutException)
            { }
            // Dispose objects
            db.Dispose();
            //
            return tempdata;
        }
        [WebMethod]
        public int InvoiceItems(TempData tempdata)
        {
            int number = 0;
            BFDataContext db = new BFDataContext();
            //Retrieve
            var Products = ( from user1 in db.Invoice1s
                             where user1.Email == tempdata.Email
                               && user1.Date.Year == tempdata.Date.Year
                               && user1.Date.Month == tempdata.Date.Month
                               && user1.Date.Day == tempdata.Date.Day
                             select user1.Pet_Id
                            );
            // Submit
            try
            {
                if (Products.Count() != 0)
                {
                    number = Products.Max();
                }
            }
            catch (SqlException)
            { }
            catch (TimeoutException)
            { }
            // Dispose objects
            db.Dispose();
            //

            return number;
        }
        [WebMethod]
        public List<Invoice1> GetDayInvoices()
        {
            List<Invoice1> tempdata = new List<Invoice1>();
            BFDataContext db = new BFDataContext();
            // Retrieve
            var user = (from user1 in db.Invoice1s
                        where user1.Date.Year == DateTime.Today.Year
                            && user1.Date.Month == DateTime.Today.Month
                           && user1.Date.Day == DateTime.Today.Day
                        select user1
                        );
            // Submit
            try
            {
                if (user.Count() != 0)
                {
                    foreach (Invoice1 user1 in user)
                    {
                        tempdata.Add(user1);
                    }
                }
                else
                {
                    tempdata = null;
                }
            }
            catch (SqlException)
            { }
            catch (TimeoutException)
            { }
            // Dispose objects
            db.Dispose();
            //
            return tempdata;
        }

        [WebMethod]
        public List<Invoice1> GetMonthInvoices()
        {
            List<Invoice1> tempdata = new List<Invoice1>();
            BFDataContext db = new BFDataContext();
            // Retrieve
            var user = (from user1 in db.Invoice1s
                        where user1.Date.Year == DateTime.Today.Year
                            && user1.Date.Month == DateTime.Today.Month
                        select user1
                        );
            // Submit
            try
            {
                if (user.Count() != 0)
                {
                    foreach (Invoice1 user1 in user)
                    {
                        tempdata.Add(user1);
                    }
                }
                else
                {
                    tempdata = null;
                }
            }
            catch (SqlException)
            { }
            catch (TimeoutException)
            { }
            // Dispose objects
            db.Dispose();
            //
            return tempdata;
        }
        [WebMethod]
        public List<Invoice1> GetYearInvoices()
        {
            List<Invoice1> tempdata = new List<Invoice1>();
            BFDataContext db = new BFDataContext();
            // Retrieve
            var user = (from user1 in db.Invoice1s
                        where user1.Date.Year == DateTime.Today.Year
                        select user1
                        );
            // Submit
            try
            {
                if (user.Count() != 0)
                {
                    foreach (Invoice1 user1 in user)
                    {
                        tempdata.Add(user1);
                    }
                }
                else
                {
                    tempdata = null;
                }
            }
            catch (SqlException)
            { }
            catch (TimeoutException)
            { }
            // Dispose objects
            db.Dispose();
            //
            return tempdata;
        }

        [WebMethod]
        public List<Invoice1> GetYearHistory(string email)
        {
            List<Invoice1> tempdata = new List<Invoice1>();
            BFDataContext db = new BFDataContext();
            // Retrieve
            var user = (from user1 in db.Invoice1s
                        where user1.Email == email
                        select user1
                        );
            // Submit
            try
            {
                if (user.Count() != 0)
                {
                    foreach (Invoice1 user1 in user)
                    {
                        tempdata.Add(user1);
                    }
                }
                else
                {
                    tempdata = null;
                }
            }
            catch (SqlException)
            { }
            catch (TimeoutException)
            { }
            // Dispose objects
            db.Dispose();
            //
            return tempdata;
        }
        [WebMethod]
        public TempData ViewInvoiceUser(TempData tempdata1)
        {

            TempData tempdata = new TempData();
            BFDataContext db = new BFDataContext();
            // Retrieve
            var user = (from user1 in db.Invoice1s
                        where user1.Email == tempdata1.Email
                           && user1.Date.Year == tempdata1.Date.Year
                           && user1.Date.Month== tempdata1.Date.Month
                           && user1.Date.Day == tempdata1.Date.Day
                           && user1.Date.Hour == tempdata1.Date.Hour
                           && user1.Date.Minute == tempdata1.Date.Minute
                           && user1.Date.Second == tempdata1.Date.Second
                        select user1
                        ).First();
            // Submit
            try
            {
                if (user != null)
                {
                    tempdata.Email = user.Email;
                    tempdata.First_Name = user.First_name;
                    tempdata.Last_Name = user.Last_name;
                    tempdata.Phone_Number = user.Phone_number;
                    tempdata.UserType = user.UserType;

                    tempdata.Card_Number = user.Card_Number;
                    tempdata.Date = user.Date;
                    tempdata.Country = user.Country;
                    tempdata.Street_Address = user.Street_Address;
                    tempdata.City = user.City;
                    tempdata.Province_State = user.Province_State;
                    tempdata.Zip_Code = user.ZIP_Code;
                }
                else
                {
                    tempdata = null;
                }
            }
            catch (SqlException)
            { }
            catch (TimeoutException)
            { }
            // Dispose objects
            db.Dispose();
            //
            return tempdata;
        }
    }
}