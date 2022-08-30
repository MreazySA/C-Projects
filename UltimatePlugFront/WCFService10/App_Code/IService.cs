using System;
using System.Collections.Generic;
using System.ServiceModel;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService" in both code and config file together.
[ServiceContract]
public interface IService
{

    [OperationContract]
    bool isReg(string email, string password);
    [OperationContract]
    int register(UserClass u);
    [OperationContract]
    int logintype(string email, string password);
    [OperationContract]
    int getHirerID(string email);
    [OperationContract]
    string getHirerMail(int ID);
    [OperationContract]
    int addProduct(int hireID, string prodType, string description, decimal price, string image, string prodName, string businessName,string suburb);
    [OperationContract]
    List<Product> getbyType(string prodType);
    [OperationContract]
    List<Product> getbySuburb(string type,string Suburb);
    [OperationContract]
    Product getSingle(int id);
    [OperationContract]
    int hire(string ProductName, DateTime date, string time, string username,int hirerID);
    [OperationContract]
    List<Hire> getEvent(int id);
    [OperationContract]
    int confirmHire(string customerName, string customerMail,string productNAme, DateTime date, string time, string status);
    [OperationContract]
    string getUserMail(int id);
    [OperationContract]
    List<Product> getProducts();
    [OperationContract]
    List<Hire> getUserProducts(string username);
    [OperationContract]
    string getHirerSuburb(int id);
    [OperationContract]
    string getUserSuburb(string username);
    [OperationContract]
    List<Product> searchProduct(string category,string prodName,string suburb);
    [OperationContract]
    List<Product> searchAllP(string category, string prodName);
    [OperationContract]
    int addDriver(string username,string licenceNumber,string NumberPlate,string carName,
    string carImage);
    [OperationContract]
    List<Driver> getDriverBySuburb(string suburb);
    [OperationContract]
    bool isDriverReg(string username);

    [OperationContract]
    User getUser(string username);
   
}
