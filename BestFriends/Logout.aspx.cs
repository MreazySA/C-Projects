using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BestFriends
{
    public partial class Logout : System.Web.UI.Page
    {
		ServiceReference1.Service1Client SR1 = new ServiceReference1.Service1Client();
		protected void Page_Load(object sender, EventArgs e)
        {
			// Empty Cart
			string result = SR1.ClearCart();

			// End Session 
			if (result == "Success")
			{
				Session["login"] = null;
				Response.Redirect("Home.aspx");
			}
			//
		}
	}
}