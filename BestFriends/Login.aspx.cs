using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BestFriends
{
    public partial class Login : System.Web.UI.Page
    {
        ServiceReference1.Service1Client SR1 = new ServiceReference1.Service1Client();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnSend_Click(object sender, EventArgs e)
        {
            ServiceReference1.TempData login1 = new ServiceReference1.TempData();
            login1.Email = email.Value;
            login1.Password = pass.Value;
            string result = SR1.Login(login1);
            // Incorrect Email
            if (result == "User Email does not Exist")
            {
				msgErr.Visible = true;
                msgErr.Value = result; ;
            }
            // Incorrect Password 
            if (result == "Wrong Password")
            {
				msgErr.Visible = true;
                msgErr.Value = "";
            }
            // Error Handling
            if (result == "Connection timed out")
            {
				msgErr.Visible = true;
				msgErr.Value = result;
            }
            // Correct Submission
            if ((result == "Customer Login") || (result == "Admin Login") || (result == "Manager Login"))
            {
                // Sessions
                Session["login"] = result;
                Session["useremail"] = email.Value;

                Response.Redirect("Home.aspx");
            }
            //
        }

    }
}