using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BestFriends
{
    public partial class Register : System.Web.UI.Page
    {
        ServiceReference1.Service1Client SR1 = new ServiceReference1.Service1Client();
        protected void Page_Load(object sender, EventArgs e)
        {
            // USER MANAGEMENT
            if (Session["login"] != null)
            {
                if (Session["login"].ToString() == "Manager Login")
                {
                    Utype.Visible = true;
                }
            }
        }
        protected void BtnReg_Click(object sender, EventArgs e)
        {
            ServiceReference1.TempData register1 = new ServiceReference1.TempData();

            //use register form to create database table
            register1.First_Name = firstName.Value;
            register1.Last_Name = lastName.Value;
            register1.Email = email.Value;
            register1.Phone_Number = phoneNo.Value;
            register1.Password = pass.Value;
            register1.Confirm_Password = confirmPass.Value;
            register1.UserType = userType.Value;
            string result = SR1.Register(register1);

            if (result == "User Already Exists")
            {
				msgErr.Visible = true;
                email.Value = result;
            }
            // make sure passwords match in the service.
            if (result == "Passwords Dont Match")
            {
				msgErr.Visible = true;
				msgErr.Value = result;
                pass.Value = "";
                confirmPass.Value = "";
            }
            // Error Handling
            if (result == "Connection timed out")
            {
				msgErr.Visible = true;
				msgErr.Value = result;
			}
            // Correct Submission
            if (result == "Signed Up")
            {
                if (Session["login"] != null)
                {
                    if (Session["login"].ToString() == "Manager Login")
                    {
                        Response.Redirect("Home.aspx");
                    }
                }
                else
                {
                    Response.Redirect("Login.aspx");
                }
            }
        }
    }
}