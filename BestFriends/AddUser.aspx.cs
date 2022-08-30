using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BestFriends
{
	public partial class AddUser : System.Web.UI.Page
	{
		//ServiceReference1.WebServiceClient SR1 = new ServiceReference1.WebServiceClient();

		protected void Page_Load(object sender, EventArgs e)
		{

		}
		/*
		protected void btnAdd_Click(object sender, EventArgs e)
		{
			ServiceReference1.TempData userReg = new ServiceReference1.TempData();

			userReg.First_Name = firstName.Value;
			userReg.Last_Name = lastName.Value;
			userReg.Email = email.Value;
			userReg.Phone_Number = phoneNo.Value;
			userReg.Password = pass.Value;
			userReg.Confirm_Password = confirmPass.Value;
			userReg.UserType = userType.Value;

			string result = SR1.Register(userReg);

			if (result == "User Already Exists")
			{
				msgErr.Visible = true;
				email.Value = result;
			}
			else if (result == "Passwords Dont Match")
			{
				msgErr.Visible = true;
				msgErr.Value = result;
				pass.Value = "";
				confirmPass.Value = "";
			}
			else
			{
				Response.Redirect("Home.aspx");
			}

		}*/
	}
}