using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication14UltimatePlugFront.ServiceReference1;
namespace UtlimatePlug_FrontEnd
{
    public partial class Products : System.Web.UI.Page
    {
        ServiceClient link = new ServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ChooseProduct(object sender, EventArgs e)
        {
            if(DropDownList1.SelectedValue.Equals("ENTERTAINMENT"))
            {
                string show = "";
                dynamic getEnt = link.getbyType("GAMING");
                show +="<div class='row'>";
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
                    show += "<a href='HireProduct.aspx?prodID=" + p.Id + "' class='team text-center'>";
                    show +="<div class='column'>";
                    show +="<div class='card'>";
                    show +="<img src = " + p.Image + " alt='image' style='width:100%'>";
                    show +="<div class='container'>";
     
                    show +="<h2>"+ p.ProductName+ "</h2>";
                  
                    show += "<h2>"      + p.Description + "</h2>";
                    // show += p.Hirer_ID;

                    show += "<a href = 'HireProduct.aspx?prodID=" + p.Id + "' class='button'>Hire</a>";
                   
                    show +="</div>";
                    show +="</div>";
                    show +="</div>";



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
            else if(DropDownList1.SelectedValue.Equals("EVENT"))
            {
                string show = "";
                dynamic getEnt = link.getbyType("EVENT");
                foreach (Product p in getEnt)
                {
                    Session["hID"] = p.Hirer_ID;
                    // show += p.Hirer_ID;
                    show += "<a href='HireProduct.aspx?prodID=" + p.Id + "' class='team text-center'>";
                    show += p.ProductName;
                    show += "</br> ";
                    show += p.Description;
                    show += "</br> ";
                    show += "<img src=" + p.Image + " width='500' height='500' alt=" + p.ProductName + " />";
                    show += "</br> ";


                }
                display.InnerHtml = show;
            }
        }
    }
}