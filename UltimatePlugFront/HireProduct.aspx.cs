using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Net.Mail;
using WebApplication14UltimatePlugFront.ServiceReference1;
namespace UtlimatePlug_FrontEnd
{
    public partial class HireProduct : System.Web.UI.Page
    {
        ServiceClient link = new ServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {
           
                if (Session["User"] != null || Session["Admin"] != null)
                {
                var myProduct = link.getSingle(Convert.ToInt32(Request.QueryString["prodID"]));
                string show = "";
                if (myProduct != null)
                {
                    show += "<section class='products'>";
                   
                    show += "<div class='product-card'>";
                    show += "<div class='product-image'>";
                    show += "<img src = " + myProduct.Image + ">";
                    show += "</div>";
                    show += "<div class='product-info'>";
                    show += "<h2>" + myProduct.ProductName + "</h2>";
                    show += "<h3>" + myProduct.Company_Or_Owner_Name + "</h3>";
                    show += "<h2>" + myProduct.Price + "</h2>";
                    show += "<h2>" + myProduct.Description + "</h2>";
                    // show += "<h2>" + p.Description + "</h2>";
                    //show += "<a href = 'HireProduct.aspx?prodID=" + p.Id + "' class='button'>Hire</a>";
                    //   < a href = "Gaming.aspx" >< p class="button">See more<p/></a>

                    show += "</div>";
                    show += "</div>";
                    show += "</section>";

                    display.InnerHtml = show;

                }
                else
                {
                    display.InnerText = "No Item to show";
                }
            }
            else
            {
                Response.Redirect("Login.aspx");
            }
            /*
            else if (Session["Admin"] == null)
            {
                Response.Redirect("Login.aspx");

            }
            else
            {
                if (Request.QueryString["prodID"] != null)
                {
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


                    }
                }
                else
                {
                    display.InnerText = "No Item to show";

                }

            }*/



        }



        protected void Button1_Click(object sender, EventArgs e)
        {
        //    Product myProduct = link.getSingle(Convert.ToInt32(Request.QueryString["prodID"]));
            WebApplication14UltimatePlugFront.ServiceReference1.Product myProduct = link.getSingle(Convert.ToInt32(Request.QueryString["prodID"]));

            if (myProduct != null)
            {
                //Chnage userMail to Hirer Mail
                string username = Session["UserMail"].ToString();
                int book = link.hire(myProduct.ProductName, Calendar1.SelectedDate, time.Value, username, myProduct.Hirer_ID);

                if (book == 1)
                {
                    // Response.Redirect("The id IS : "+ myProduct.Hirer_ID);
                    string check = link.getUserMail(myProduct.Id);
                    if (check != null)
                    { 
                        MailMessage message = new MailMessage();
                        SmtpClient smtp = new SmtpClient();
                        message.From = new MailAddress("reason.sithole99@gmail.com");
                        message.To.Add(new MailAddress(Session["HirerMail"].ToString()));
                        message.Subject = "Hiring Request ";
                        message.IsBodyHtml = true;
                        message.Body = " Hire request from " + username + " Please login to your Dashboard to Accept/Decline this request" + "<a href='C:'\'Users'\'Mreazy.LAPTOP-CO52LGI3'\'source\repos'\'WebApplication14UltimatePlugFront'\'WebApplication14UltimatePlugFrontConfirmBooking.aspx'>click</a>";
                        smtp.Host = "smtp.gmail.com";
                        smtp.Timeout = 10000;
                        smtp.EnableSsl = true;
                        smtp.UseDefaultCredentials = false;
                        smtp.Credentials = new NetworkCredential("reason.sithole99@gmail.com", "akfzhsntochjyolc");
                        smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                        smtp.Send(message);
                        //label1.InnerText = "Accepted, The user will be Notified, please deliver on the agreed time";
                        hire.Visible = true;
                        //hire.Visible = false;
                        Session["code"] = username;
                     //   Response.Redirect("Gaming.aspx");
                    }
                    else
                    {
                        Response.Redirect("Home.aspx");
                    }
                }
                else
                {
                    Response.Redirect("An error has occurred!!!");
                }
            }


        }

        protected void Back(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");
        }
    }
}
