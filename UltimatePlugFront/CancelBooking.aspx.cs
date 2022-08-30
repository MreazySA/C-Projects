using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Net;
using System.Net.Mail;

using WebApplication14UltimatePlugFront.ServiceReference1;
namespace WebApplication14UltimatePlugFront
{
    public partial class CancelBooking : System.Web.UI.Page
    {
        ServiceClient link = new ServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedValue.Equals("Yes"))
            {

                string getHirerMail = link.getHirerMail(Convert.ToInt32(Session["HirerID"].ToString()));
                
                
                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();
                message.From = new MailAddress("reason.sithole99@gmail.com");
                message.To.Add(new MailAddress(getHirerMail));
                message.Subject = "Booking Cancellation ";
                message.IsBodyHtml = true;
                message.Body = "Hi, something came up, i would like to cancel my booking, thanks " + "<a href='ConfirmBooking.aspx'>click</a>";
                smtp.Host = "smtp.gmail.com";
                smtp.Timeout = 10000;
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("reason.sithole99@gmail.com", "akfzhsntochjyolc");
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(message);
                label1.InnerText = "Transaction Cancelled,the owner will be notified";

                MailMessage message1 = new MailMessage();
                SmtpClient smtp1 = new SmtpClient();
                message.From = new MailAddress("reason.sithole99@gmail.com");
                message.To.Add(new MailAddress(Session["Customer"].ToString()));
                message.Subject = "Booking Cancellation ";
                message.IsBodyHtml = true;
                message.Body = "Transaction Cancelled Successfully " + "<a href='ConfirmBooking.aspx'>click</a>";
                smtp.Host = "smtp.gmail.com";
                smtp.Timeout = 10000;
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("reason.sithole99@gmail.com", "akfzhsntochjyolc");
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(message);
               

            }
            else if (DropDownList1.SelectedValue.Equals("No"))
            {
                Response.Redirect("Profile.aspx");
            }
        }
    }
}