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
namespace UtlimatePlug_FrontEnd
{
    public partial class ConfirmBooking : System.Web.UI.Page
    {
        ServiceClient link = new ServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {/*
            string to = "217023885@Student.uj.ac.za"; //To address    
            string from = "reason.sithole99@gmail.com"; //From address    
            MailMessage message = new MailMessage(from, to);

            string mailbody = "In this article you will learn how to send a email using Asp.Net & C#";
            message.Subject = "Sending Email Using Asp.Net & C#";
            message.Body = mailbody;
          //  message.BodyEncoding = Encoding.UTF8;
            message.IsBodyHtml = true;
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587); //Gmail smtp    
            System.Net.NetworkCredential basicCredential1 = new
            System.Net.NetworkCredential("reason.sithole99@gmail.com", "19990630");
            client.EnableSsl = true;
            client.UseDefaultCredentials = false;
            client.Credentials = basicCredential1;
            try
            {
                client.Send(message);
            }

            catch (Exception ex)
            {
                throw ex;
            }*/
            if(DropDownList1.SelectedValue.Equals("Accept"))
            {

                string check = link.getUserMail(Convert.ToInt32(Request.QueryString["bookId"]));
                if(check!=null)
                {
                    Session["customerMail"] = check;
                }
                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();
                message.From = new MailAddress("reason.sithole99@gmail.com");
                message.To.Add(new MailAddress(Session["Customer"].ToString()));
                message.Subject = "Hiring Request ";
                message.IsBodyHtml = true;
                message.Body = " Hire Confirmed,please pay the deposit to continue with your booking and send the screenshot to the Whatspp Number 0671363132!  " + "<a href='ConfirmBooking.aspx'>click</a>";
                smtp.Host = "smtp.gmail.com";
                smtp.Timeout = 10000;
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("reason.sithole99@gmail.com", "akfzhsntochjyolc");
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(message);
                label1.InnerText = "Accepted, The user will be Notified, please deliver on the agreed time";

            }
            else if(DropDownList1.SelectedValue.Equals("Decline"))
            {
                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();
                message.From = new MailAddress("reason.sithole99@gmail.com");
                message.To.Add(new MailAddress(Session["Customer"].ToString()));
                message.Subject = "Hiring Request ";
                message.IsBodyHtml = true;
                message.Body = " Product cannot be hired at this time, try some other time or check another product! " + "<a href='ConfirmBooking.aspx'>click</a>";
                smtp.Host = "smtp.gmail.com";
                smtp.Timeout = 10000;
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("reason.sithole99@gmail.com", "akfzhsntochjyolc");
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(message);
                label1.InnerText = "Declined,user will be notified";
            }

        }
    }
}