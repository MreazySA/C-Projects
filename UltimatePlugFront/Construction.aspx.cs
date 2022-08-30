using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication14UltimatePlugFront.ServiceReference1;
namespace NewUltimateFE
{
    public partial class Construction : System.Web.UI.Page
    {
        ServiceClient link = new ServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["User"] != null || Session["Admin"] != null)
            {
                /*
                var myProduct = link.getSingle(Convert.ToInt32(Request.QueryString["prodID"]));

                if (myProduct != null)
                {
                    string show = "";
                    show += myProduct.Image;
                    show += myProduct.ProductName;
                    show += myProduct.Prod_Type;
                    show += myProduct.Price;
                    show += myProduct.Description;
                    display.InnerHtml = show;
                  
                    
                }*/


                string show = "";
                dynamic getall = link.getbyType("Construction");
                show += "<section class='products'>";
                foreach (Product p in getall)
                {
                    // show += "<div class='row'>";
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


                    show += "<a href='HireProduct.aspx?prodID=" + p.Id + "' class='team text-center'>";
                    show += "<div class='column'>";
                    show += "<div class='card'>";
                    show += "<img src = " + p.Image + " alt='image' style='width:100%'>";
                    show += "<div class='container'>";

                    show += "<h2>" + p.ProductName + "</h2>";

                    show += "<h2>" + p.Description + "</h2>";
                    show += "<h2>" + p.Price + "</h2>";
                        show += "<h2>" + p.Suburb + "</h2>";
                        // show += p.Hirer_ID;

                    show += " <br />";
                    show += "</div>";
                    show += "</div>";
                    show += "</div>";
                    */

                    Session["HirerMail"] = link.getHirerMail(p.Hirer_ID);

                    show += "<div class='product-card'>";
                    show += "<div class='product-image'>";
                    show += "<img src = " + p.Image + ">";
                    show += "</div>";
                    show += "<div class='product-info'>";
                    show += "<h2>" + p.ProductName + "</h2>";
                    show += "<h3>" + p.Company_Or_Owner_Name + "</h3>";
                    show += "<h2>" + p.Price + "</h2>";
                    // show += "<h2>" + p.Description + "</h2>";
                    show += "<a href = 'HireProduct.aspx?prodID=" + p.Id + "' class='button'>Hire</a>";
                    //   < a href = "Gaming.aspx" >< p class="button">See more<p/></a>

                    show += "</div>";
                    show += "</div>";


                }
                show += "</section>";
                /*
                show += "</div";

                show += "</div";
                show += "</div";
                show += "</div";
                show += "</div";
                show += "</div";
                show += "</div";
                show += "</div";*/
                display.InnerHtml = show;





            }
            else
            {
                Response.Redirect("Login.aspx");
            }
        }

        protected void searchProduct(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedValue.Equals("NearMe"))
            {
                string show = "";
                var suburb = link.getUserSuburb(Session["UserMail"].ToString());
                if (suburb != null)
                {

                    //  dynamic searchP = link.searchProduct("Construction",search.Value,suburb);
                    dynamic searchP = link.getbySuburb("Construction",suburb);
                    show += "<section class='products'>";
                    foreach (Product p in searchP)
                    {
                        // show += "<div class='row'>";
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


                        show += "<a href='HireProduct.aspx?prodID=" + p.Id + "' class='team text-center'>";
                        show += "<div class='column'>";
                        show += "<div class='card'>";
                        show += "<img src = " + p.Image + " alt='image' style='width:100%'>";
                        show += "<div class='container'>";

                        show += "<h2>" + p.ProductName + "</h2>";

                        show += "<h2>" + p.Description + "</h2>";
                        show += "<h2>" + p.Price + "</h2>";
                            show += "<h2>" + p.Suburb + "</h2>";
                            // show += p.Hirer_ID;

                        show += " <br />";
                        show += "</div>";
                        show += "</div>";
                        show += "</div>";
                        */

                        Session["HirerMail"] = link.getHirerMail(p.Hirer_ID);

                        show += "<div class='product-card'>";
                        show += "<div class='product-image'>";
                        show += "<img src = " + p.Image + ">";
                        show += "</div>";
                        show += "<div class='product-info'>";
                        show += "<h2>" + p.ProductName + "</h2>";
                        show += "<h3>" + p.Company_Or_Owner_Name + "</h3>";
                        show += "<h2>" + p.Price + "</h2>";
                        //show += "<h2>" + p.Description + "</h2>";
                        show += "<a href = 'HireProduct.aspx?prodID=" + p.Id + "' class='button'>Hire</a>";
                        //   < a href = "Gaming.aspx" >< p class="button">See more<p/></a>

                        show += "</div>";
                        show += "</div>";


                    }
                    show += "</section>";
                    /*
                    show += "</div";

                    show += "</div";
                    show += "</div";
                    show += "</div";
                    show += "</div";
                    show += "</div";
                    show += "</div";
                    show += "</div";*/
                    display.InnerHtml = show;
                }
                else
                {
                    Response.Redirect("Error");
                }
            }
            else if (DropDownList1.SelectedValue.Equals("All"))
            {
                string show = "";
                // dynamic getEnt = link.searchAllP("G);

                dynamic searchP = link.searchAllP("Gaming", search.Value);

                show += "<section class='products'>";
                foreach (Product p in searchP)
                {
                    // show += "<div class='row'>";
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


                    show += "<a href='HireProduct.aspx?prodID=" + p.Id + "' class='team text-center'>";
                    show += "<div class='column'>";
                    show += "<div class='card'>";
                    show += "<img src = " + p.Image + " alt='image' style='width:100%'>";
                    show += "<div class='container'>";

                    show += "<h2>" + p.ProductName + "</h2>";

                    show += "<h2>" + p.Description + "</h2>";
                    show += "<h2>" + p.Price + "</h2>";
                        show += "<h2>" + p.Suburb + "</h2>";
                        // show += p.Hirer_ID;

                    show += " <br />";
                    show += "</div>";
                    show += "</div>";
                    show += "</div>";
                    */

                    Session["HirerMail"] = link.getHirerMail(p.Hirer_ID);

                    show += "<div class='product-card'>";
                    show += "<div class='product-image'>";
                    show += "<img src = " + p.Image + ">";
                    show += "</div>";
                    show += "<div class='product-info'>";
                    show += "<h2>" + p.ProductName + "</h2>";
                    show += "<p>" + p.Company_Or_Owner_Name + "</p>";
                    show += "<p>" + p.Price + "</p>";
                    show += "<p>" + p.Description + "</p>";
                    show += "<a href = 'HireProduct.aspx?prodID=" + p.Id + "' class='button'>Hire</a>";
                    //   < a href = "Gaming.aspx" >< p class="button">See more<p/></a>

                    show += "</div>";
                    show += "</div>";


                }
                show += "</section>";
                /*
                show += "</div";

                show += "</div";
                show += "</div";
                show += "</div";
                show += "</div";
                show += "</div";
                show += "</div";
                show += "</div";*/
                display.InnerHtml = show;
            }
            else
            {
                Response.Redirect("Error");
            }
        }

    }
}