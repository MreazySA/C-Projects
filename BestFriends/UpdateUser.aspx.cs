using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BestFriends
{
    public partial class UpdateUser1 : System.Web.UI.Page
    {
		ServiceReference1.Service1Client SR1 = new ServiceReference1.Service1Client();
		private string email;
		private string Display = "";

		protected void Page_Load(object sender, EventArgs e)
        {
			string query1 = Request.QueryString["Remove"];
			if (query1 != null)
			{
				email = query1;
				string result = SR1.RemoveUser(email);
			}

			string query2 = Request.QueryString["Add"];
			if (query2 != null)
			{
				email = query2;
				Response.Redirect("EditUser.aspx?email=" + email);
			}

			ServiceReference1.User[] admins = SR1.GetAdmins();

			int number_of_admins = 0;
			if (admins != null)
			{
				number_of_admins = admins.Length;
			}

			// View Dynamic Content
			Display		   +="<h3> Admins </h3>"
						   + "<table class='table'><thead><tr>"
						   + "<th scope='col'>Surname</th>"
						   + "<th scope='col'>Name</th>"
						   + "<th scope='col'>Email</th>"
						   + "<th scope='col'>Edit</th>"
						   + "<th scope='col'>Remove</th>"
						   + "</tr></thead>";
			for (int a = 0; a < number_of_admins; a++)
			{
				if (admins != null)
				{
					Display      +="<tbody><tr>"
								 + "<td>"
								 + "<h5>" + admins[a].Last_name + "</h5>"
								 + "</td>"
								 + "<td>"
								 + "<h5>" + admins[a].First_name + "</h5>"
								 + "</td>"
								 + "<td>"
								 + "<h5>" + admins[a].Email + "</h5>"
								 + "</td>"
								 + "<td><a href ='UpdateUser.aspx?Add=" + admins[a].Email + "'>"
								 + "<img src='img/edit.png' alt='Edit'>"
								 + "</a></td>"
								 + "<td><a href ='UpdateUser.aspx?Remove=" + admins[a].Email + "'>"
								 + "<img src='img/remove.png' alt='Remove'>"
								 + "</a></td>"
								 + "</tr></tbody>";
				}
			}
			Display		+="</table></div>"
						+ "<br /><br />"
						+ "<br /><br />";


			ServiceReference1.User[] customers = SR1.GetCustomers();
			int number_of_customers = customers.Length;
			Display		   +="<h3> Customers </h3>"
						   + "<table class='table'><thead><tr>"
						   + "<th scope='col'>Surname</th>"
						   + "<th scope='col'>Name</th>"
						   + "<th scope='col'>Email</th>"
						   + "<th scope='col'>Edit</th>"
						   + "<th scope='col'>Remove</th>"
						   + "</tr></thead>";
			for (int c = 0; c < number_of_customers; c++)
			{
				Display			 +="<tbody><tr>"
								 + "<td>"
								 + "<h5>" + customers[c].Last_name + "</h5>"
								 + "</td>"
								 + "<td>"
								 + "<h5>" + customers[c].First_name + "</h5>"
								 + "</td>"
								 + "<td>"
								 + "<h5>" + customers[c].Email + "</h5>"
								 + "</td>"
								 + "<td><a href ='UpdateUser.aspx?Add=" + customers[c].Email + "'>"
								 + "<img src='img/edit.png' alt='Edit'>"
								 + "</a></td>"
								 + "<td><a href ='UpdateUser.aspx?Remove=" + customers[c].Email + "'>"
								 + "<img src='img/remove.png' alt='Remove'>"
								 + "</a></td>"
								 + "</tr></tbody>";
			}

			Display     +="</table></div>"
						+ "<br /><br />"
						+ "<br /><br />";

			Enclosing_Div.InnerHtml = Display;
		}
    }
}