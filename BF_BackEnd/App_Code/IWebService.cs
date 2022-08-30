using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace P05
{
    [ServiceContract]
    public interface IWebService
    {
        // TODO: Service Operations Declaration
        [OperationContract]
        string Register(TempData tempdata);
        [OperationContract]
        string Login(TempData tempdata);
        [OperationContract]
        TempData GetUser(string email);
        [OperationContract]
        int NumberOfPets();
        [OperationContract]
        int NumberOfDogs();
        [OperationContract]
        int NumberOfCats();
        [OperationContract]
        TempData GetPet(int ID);
        [OperationContract]
        List<User> GetCustomers();
        [OperationContract]
        List<User> GetAdmins();
        [OperationContract]
        List<User> GetManagers();
        [OperationContract]
        string RemovePet(int ID);
        [OperationContract]
        TempData GetDog(int ID);
        [OperationContract]
        TempData GetCat(int ID);
        [OperationContract]
        string  AddtoCart(int ID);
        [OperationContract]
        string ClearCart();
        [OperationContract]
        int NumberOfItems();
        [OperationContract]
        TempData GetItems(int ID);
        [OperationContract]
        string RemoveFromCart(int ID);
        [OperationContract]
        string AddPet(TempData tempdata);
        [OperationContract]
        string UpdatePet(TempData tempdata);
        [OperationContract]
        string EditPet(TempData tempdata);
        [OperationContract]
        string RemoveUser(string email);
        [OperationContract]
        string EditUser(TempData tempdata);
        [OperationContract]
        TempData Get_Pet(string Pet_Name);
        [OperationContract]
        string AddOffer(TempData tempdata);
        [OperationContract]
        int NumberOfOffers();
        [OperationContract]
        string RemoveOffer(int ID);
        [OperationContract]
        TempData GetOffer(int ID);
        [OperationContract]
        string EditOffer(TempData tempdata);
        [OperationContract]
        string Add_Item(TempData tempdata);
        [OperationContract]
        TempData GetInvoiceUser(TempData tempdata);
        [OperationContract]
        TempData GetInvoicePet(TempData tempdata);
        [OperationContract]
        int InvoiceItems(TempData tempdata);
        [OperationContract]
        List<Invoice1> GetDayInvoices();
        [OperationContract]
        TempData ViewInvoiceUser(TempData tempdata1);
        [OperationContract]
        List<Invoice1> GetMonthInvoices();
        [OperationContract]
        List<Invoice1> GetYearInvoices();
        [OperationContract]
        List<Invoice1> GetYearHistory(string email);
    }

    [DataContract]
    public class TempData
    {
      // Register & Login Variables
         [DataMember]
         public string First_Name;
         [DataMember]
         public  string Last_Name;
         [DataMember]
         public string Email;
         [DataMember]
         public string Phone_Number;
         [DataMember]
         public string Password;
         [DataMember]
         public string Confirm_Password;
         [DataMember]
         public string UserType;
      // Dogs , ViewDog , Cat , ViewCat , AddPet , UpdatePet , EditPet & Cart Variables
         [DataMember]
         public int Pet_Id;
         [DataMember]
         public string Pet_Image;
         [DataMember]
         public string Pet_Name;
         [DataMember]
         public string Pet_Type;
         [DataMember]
         public string Pet_Breed;
         [DataMember]
         public string Pet_Description;
         [DataMember]
         public decimal Pet_Price;
         [DataMember]
         public int Pet_Quantity;
        // Offer
        [DataMember]
        public int Offer_Id;
        [DataMember]
        public string Offer_Type;
        [DataMember]
        public string Offer_Title;
        [DataMember]
        public string Offer_Image;
        [DataMember]
        public string Offer_Description;
        // Invoice
        [DataMember]
        public string Card_Number;
        [DataMember]
        public string Country;
        [DataMember]
        public string Street_Address;
        [DataMember]
        public string City;
        [DataMember]
        public string Province_State;
        [DataMember]
        public string Zip_Code;
        [DataMember]
        public DateTime Date;
        //


    }
}