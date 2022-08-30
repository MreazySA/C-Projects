using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication14UltimatePlugFront.ServiceReference1;
namespace NewUltimateFE
{
    public partial class Profile : System.Web.UI.Page
    {
        ServiceClient link = new ServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string display = "";
    
            dynamic check = link.getUserProducts(Session["UserMail"].ToString());
            
            if (check != null)
            {
                display += "<table>";
                display += "<tr>";
                display += "<th>" + "Customer Mail" + "</th>";
                display += "<th>" + "Date" + "</th>";
                display += "<th>" + "Time" + "</th>";
                display += "<th>" + "ProductName" + "</th>";
                display += "<th>" + "Hirer Mail" + "</th>";
                display += "</tr>";
                display += "<tr>";
                foreach (Hire a in check)
                {
                    string getHirer = link.getHirerMail(a.HirerID);
                    //display += "<td>" + Session["UserMail"].ToString() + "</td>";
                    display += "<td>" + a.CustomerName + "</td>";
                    Session["Customer"] = a.CustomerName;
                    display += "<td>" + a.Date + "</td>";
                    display += "<td>" + a.Time + "</td>";
                    display += "<td>" + a.ProductName + "</td>";
                   
                    //display += "<a href='singleProduct.aspx?hairStyleID=" + a.UserID + "' ></a>";
                    display += "<td>" + getHirer + "</td>";
                    Session["HirerID"] = a.HirerID;
                    display += "<td>" + "<a href='CancelBooking.aspx?bookId=" + a.Id + "' >Cancel</a>" + "</td>";
                    display += "</tr>";
                    
                    
                }

                display += "</tr>";
                display += "</table>";
                viewTrans.InnerHtml = display;
            }
        }
    }
}