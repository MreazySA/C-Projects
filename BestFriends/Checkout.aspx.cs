using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BestFriends
{
    public partial class Checkout : System.Web.UI.Page
    {
        //ServiceReference1.WebServiceClient SR1 = new ServiceReference1.WebServiceClient();
        private string result = "";

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        /*
        protected void btnToInvoice_Click(object sender, EventArgs e)
        {
            if (Session["useremail"] != null)
            {
                ServiceReference1.TempData userdata = SR1.GetUser(Session["useremail"].ToString());
                int number_of_pets = SR1.NumberOfItems() + 1;

                ServiceReference1.TempData tempdata = new ServiceReference1.TempData();

                for (int k = 1; k < number_of_pets; k++)
                {
                    ServiceReference1.TempData item = SR1.GetItems(k);
                    if (item != null)
                    {
                        tempdata.First_Name = userdata.First_Name;
                        tempdata.Last_Name = userdata.Last_Name;
                        tempdata.Email = userdata.Email;
                        tempdata.Phone_Number = userdata.Phone_Number;
                        tempdata.UserType = userdata.UserType;

                        tempdata.Pet_Id = item.Pet_Id;
                        tempdata.Pet_Name = item.Pet_Name;
                        tempdata.Pet_Breed = item.Pet_Breed;
                        tempdata.Pet_Price = item.Pet_Price;
                        tempdata.Pet_Quantity = item.Pet_Quantity;
                        tempdata.Pet_Type = item.Pet_Type;

                        tempdata.Card_Number = cardno.Value;
                        tempdata.Date = DateTime.Now;
                        tempdata.Street_Address = addr1.Value;
                        tempdata.City = city.Value;
                        tempdata.Province_State = province.Value;
                        tempdata.Zip_Code = zip.Value;

                        result = SR1.Add_Item(tempdata);
                    }
                }
                if (result == "Success")
                {
                    Response.Redirect("Invoice.aspx?Email=" + userdata.Email + "&Date=" + DateTime.Now.ToString());
                }
                else
                {
                    msgErr.Visible = true;
                    msgErr.Value = result;
                }
            }
        }*/
    }
}