using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BestFriends
{
    public partial class EditUser : System.Web.UI.Page
    {
		ServiceReference1.WebServiceClient SR1 = new ServiceReference1.WebServiceClient();
		private string email = null;

		protected void Page_Load(object sender, EventArgs e)
		{
			ServiceReference1.TempData getUser = new ServiceReference1.TempData();

			// Retrieve product
			email = Request.QueryString["email"];
			if (email != null)
			{
				getUser = SR1.GetUser(email);

				oldName.Value = getUser.First_Name;
				oldSurname.Value = getUser.Last_Name;
				oldNumber.Value = getUser.Phone_Number;
				oldEmail.Value = getUser.Email;
				oldusertype.Value = getUser.UserType;
			}
		}

		protected void btnEditUser_Click(object sender, EventArgs e)
		{
			ServiceReference1.TempData editUser = new ServiceReference1.TempData();

			// Function Call
			if (email != null)
			{
				//Name of User
				editUser.Email = email;
				if (newName.Value != "")
				{
					editUser.First_Name = newName.Value;
				}
				else
				{
					editUser.First_Name = oldName.Value;
				}

				//Surname of User
				if (newSurname.Value != "")
				{
					editUser.Last_Name = newSurname.Value;
				}
				else
				{
					editUser.Last_Name = oldSurname.Value;
				}

				//Phone number of User
				if (newNumber.Value != "")
				{
					editUser.Phone_Number = newNumber.Value;
				}
				else
				{
					editUser.Phone_Number = oldNumber.Value;
				}

				//ADDED BY BAHLE -- Email of User
				if (newEmail.Value != "")
				{
					editUser.Phone_Number = newEmail.Value;
				}
				else
				{
					editUser.Phone_Number = oldEmail.Value;
				}

				//User Type of User
				if (newusertype.Value != "")
				{
					editUser.UserType = newusertype.Value;
				}
				else
				{
					editUser.UserType = oldusertype.Value;
				}

				//Submit Changes
				string result = SR1.EditUser(editUser);
				// Validation 
				if (result == "User Updated")
				{
					Response.Redirect("Home.aspx");
				}
			}
		}
	}
}