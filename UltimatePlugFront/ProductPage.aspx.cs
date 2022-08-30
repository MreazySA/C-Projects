using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication14UltimatePlugFront.ServiceReference1;
namespace NewUltimateFE
{
    public partial class ProductPage : System.Web.UI.Page
    {
        ServiceClient link = new ServiceClient();
        protected void ChooseProduct(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedValue.Equals("ENTERTAINMENT"))
            {
                string show = "";
                dynamic getEnt = link.getbyType("ENTERTAINMENT");
                show += "<div class='row'>";
                foreach (Product p in getEnt)
                {
                    /*
                    Session["hID"] = p.Hirer_ID;
                   // show += p.Hirer_ID;
                    show += "<a href='HireProduct.aspx?prodID=" + p.Id + "' class='team text-center'>";
                    show += p.ProductName;
                    show += "</br> ";
                    show += p.Description;
                    show += "</br> ";
                    show += "<img src=" + p.Image + " width='500' height='500' alt=" + p.ProductName + " />";
                    show += "</br> ";

                    */

                    show += "<div class='column'>";
                    show += "<div class='card'>";
                    show += "<img src = " + p.Image + " alt='image' style='width:100%'>";
                    show += "<div class='container'>";
                    show += "<h2>" + p.ProductName + "</h2>";
                    show += "<p class='title'>CEO & Founder</p>";
                    show += "<p>Some text that describes me lorem ipsum ipsum lorem.</p>";
                    show += "<p>example @example.com</p>";
                    show += "<p><button class='button'>Hire</button></p>";

                    show += "</div>";
                    show += "</div>";
                    show += "</div>";



                }

                show += "</div";

                show += "</div";
                show += "</div";
                show += "</div";
                show += "</div";
                show += "</div";
                show += "</div";
                show += "</div";
                display.InnerHtml = show;

            }
            else if (DropDownList1.SelectedValue.Equals("EVENT"))
            {
                string show = "";
                dynamic getEnt = link.getbyType("EVENT");
                foreach (Product p in getEnt)
                {
                    Session["hID"] = p.Hirer_ID;
                    // show += p.Hirer_ID;
                    show += "<ahref='HireProduct.aspx?prodID=" + p.Id + "' class='team text-center'>";
                    show += "<img src=" + p.Image + " width='500' height='500' alt=" + p.ProductName + " />";

                    //  show += "<a href='HireProduct.aspx?prodID=" + p.Id + "' class='team text-center'>";
                    show += p.ProductName;
                    show += "</br> ";
                    show += p.Description;
                    show += "</br> ";
                    show += "</br> ";

        
                }
                display.InnerHtml = show;
            }
        }
    
}
}