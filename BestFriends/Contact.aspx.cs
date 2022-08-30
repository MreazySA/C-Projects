using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BestFriends
{
	public partial class Contact : System.Web.UI.Page
	{
		//ServiceReference1.WebServiceClient SR1 = new ServiceReference1.WebServiceClient();
		protected void Page_Load(object sender, EventArgs e)
		{/*
			ServiceReference1.User[] admins = SR1.GetAdmins();
			string Display = "";

			int number_of_admins = 0;
			if (admins != null)
			{
				number_of_admins = admins.Length;
			}

			// View Dynamic Content
			Display		   +="<h3>Admins</h3>"
						   + "<table class='table'><thead><tr>"
						   + "<th scope='col'>Surname</th>"
						   + "<th scope='col'>Name</th>"
						   + "<th scope='col'>Email</th>"
						   + "</tr></thead>";
			for (int a = 0; a < number_of_admins; a++)
			{
				if (admins != null)
				{
					Display		 +="<tbody><tr>"
								 + "<td>"
								 + "<h5>" + admins[a].Last_name + "</h5>"
								 + "</td>"
								 + "<td>"
								 + "<h5>" + admins[a].First_name + "</h5>"
								 + "</td>"
								 + "<td>"
								 + "<i class='lnr lnr-envelope'></i><h5>" + admins[a].Email + "</h5>"
								 + "</td>"
								 + "</tr></tbody>";
				}
			}
			Display += "</table></div>"
						+ "<br /><br />"
						+ "<br /><br />";


			ServiceReference1.User[] managers = SR1.GetManagers();
			int number_of_managers = 0;
			if (managers != null)
			{
				number_of_managers = managers.Length;
			}

			// View Dynamic Content
			Display += "<h3>Managers</h3>"
						   + "<table class='table'><thead><tr>"
						   + "<th scope='col'>Surname</th>"
						   + "<th scope='col'>Name</th>"
						   + "<th scope='col'>Email</th>"
						   + "<th scope='col'>Phone Number</th>"
						   + "</tr></thead>";
			for (int m = 0; m < number_of_managers; m++)
			{
				if (admins != null)
				{
					Display += "<tbody><tr>"
								 + "<td>"
								 + "<h5>" + managers[m].Last_name + "</h5>"
								 + "</td>"
								 + "<td>"
								 + "<h5>" + managers[m].First_name + "</h5>"
								 + "</td>"
								 + "<td>"
								 + "<i class='lnr lnr-envelope'></i><h5>" + managers[m].Email + "</h5>"
								 + "</td>"
								 + "<td>"
								 + "<i class='lnr lnr-phone-handset'></i><h5>" + managers[m].Phone_number + "</h5>"
								 + "</td>"
								 + "</tr></tbody>";
				}
			}
			Display += "</table></div>"
						+ "<br /><br />"
						+ "<br /><br />";

			Enclosing_Div.InnerHtml = Display;
			*/
		} 
		}
}