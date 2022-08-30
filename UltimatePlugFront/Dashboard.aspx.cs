using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using WebApplication14UltimatePlugFront.ServiceReference1;

namespace UtlimatePlug_FrontEnd
{ 
    public partial class Dashboard : System.Web.UI.Page
    {
        ServiceClient link = new ServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Transactions(object sender, EventArgs e)
        {
            string display = "";
            dynamic check = link.getEvent(Convert.ToInt32(Session["HirerID"]));
            if(check!=null)
            {
                display += "<table>";
                display += "<tr>";
                display += "<th>" + "Customer Name" + "</th>";
                display += "<th>" + "Date" + "</th>";
                display += "<th>" + "Time" + "</th>";
                display += "<th>" + "ProductName" + "</th>";
                display += "</tr>";
                display += "<tr>";
                foreach (Hire a in check)
                {
                    
                    //display += "<td>" + Session["UserMail"].ToString() + "</td>";
                    display += "<td>" + a.CustomerName + "</td>";
                    Session["Customer"] = a.CustomerName;
                    display += "<td>" + a.Date + "</td>";
                    display += "<td>" + a.Time + "</td>";
                    display += "<td>" + a.ProductName + "</td>";
                    display += "<td>" + "<a href='ConfirmBooking.aspx?bookId=" + a.Id + "' >Accept/Decline</a>" + "</td>";
                    //display += "<a href='singleProduct.aspx?hairStyleID=" + a.UserID + "' ></a>";
                    display += "</tr>";
                }

                display += "</tr>";
                display += "</table>";
                viewTrans.InnerHtml = display;
            }
        }

        protected void Add(object sender, EventArgs e)
        {
            showProducts.Visible = true;
        }

        protected void AddProduct(object sender, EventArgs e)
        {
            string suburb=link.getHirerSuburb(Convert.ToInt32(Session["HirerID"].ToString()));
            int test = link.addProduct(Convert.ToInt32(Session["HirerID"].ToString()),DropDownList1.SelectedValue,description.Value,Convert.ToDecimal(price.Value),
                Session["image"].ToString(),ProductName.Value,"My Business",suburb);
            if(test!=0)
            {
                show.Visible = true;
            }else
            {
                Response.Redirect("Fail");
            }
         }

        protected void Button4_Click(object sender, EventArgs e)
        {
            string path = Server.MapPath("~/pictures/");
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            FileUpload1.SaveAs(path + Path.GetFileName(FileUpload1.FileName));
            Image1.ImageUrl = "/pictures/" + Path.GetFileName(FileUpload1.FileName);
            Session["image"] = Image1.ImageUrl;
        }
    }
}