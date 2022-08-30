using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BestFriends
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        ServiceReference1.Service1Client SR1 = new ServiceReference1.Service1Client();
        protected void Page_Load(object sender, EventArgs e)
        {
            // USER MANAGEMENT
            /*
            if (Session["login"] != null)
            {
                if (Session["login"].ToString() == "Customer Login")
                {
                    regBtn.Visible = false;
                    loginBtn.Visible = false;
                    logoutBtn.Visible = true;
                    prodID.Visible = false;
                }
                if (Session["login"].ToString() == "Admin Login")
                {
                    regBtn.Visible = false;
                    loginBtn.Visible = false;
                    logoutBtn.Visible = true;
                    prodID.Visible = true;
                    addtU.Visible = false;
                    updateU.Visible = false;
                }
                if (Session["login"].ToString() == "Manager Login")
                {
                    regBtn.Visible = false;
                    loginBtn.Visible = false;
                    logoutBtn.Visible = true;
                    prodID.Visible = true;
                    addtU.Visible = true;
                    updateU.Visible = true;
                    report.Visible = true;
                }
            }
            else
            {
                regBtn.Visible = true;
                loginBtn.Visible = true;
                logoutBtn.Visible = false;
                prodID.Visible = false;
            }
            // CART
            int items = 0;
            decimal total = 0;
            int number_of_pets = SR1.NumberOfItems() + 1;
            for (int k = 1; k < number_of_pets; k++)
            {

                ServiceReference1.TempData tempdata = SR1.GetItems(k);
                if (tempdata != null)
                {
                    items += tempdata.Pet_Quantity;
                    total += tempdata.Pet_Quantity * tempdata.Pet_Price;
                }
            }
            cart_items.InnerText = "Items : " + items.ToString();
            cart_total.InnerText = "Total : R " + total.ToString();
            */
        }
    }
}