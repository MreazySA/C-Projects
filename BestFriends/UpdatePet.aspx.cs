using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BestFriends
{
	public partial class UpdatePet : System.Web.UI.Page
	{
		ServiceReference1.Service1Client SR1 = new ServiceReference1.Service1Client();
		private int Pet_ID;
		private string Display = "";

		protected void Page_Load(object sender, EventArgs e)
		{
			string query1 = Request.QueryString["Remove"];
			if (query1 != null)
			{
				Pet_ID = int.Parse(query1);
				string result = SR1.RemovePet(Pet_ID);
			}

			string query2 = Request.QueryString["Add"];
			if (query2 != null)
			{
				Pet_ID = int.Parse(query2);
				Response.Redirect("EditPet.aspx?productid=" + Pet_ID);
			}

			// Dynamic Content Variables
			int number_of_pets = SR1.NumberOfPets() + 1;

			// View Dynamic Content
			Display += "<table class='table'><thead><tr>"
						   + "<th scope='col'>Name</th>"
						   + "<th scope='col'>Type of Pet</th>"
						   + "<th scope='col'>Breed</th>"
						   + "<th scope='col'>Price</th>"
						   + "<th scope='col'>Quantity</th>"
						   + "<th scope='col'>Edit</th>"
						   + "<th scope='col'>Remove</th>"
						   + "</tr></thead>";
			for (int p = 1; p < number_of_pets; p++)
			{
				ServiceReference1.TempData tempdata = SR1.GetPet(p);
				if (tempdata != null)
				{
					Display += "<tbody><tr>"
							 + "<td>"
							 + "<div class='media'>"
							 + "<div class='media-body'>"
							 + "<h5>" + tempdata.Pet_Name + "</h5>"
							 + "</div></div></td>"
							 + "<td>"
							 + "<h5>" + tempdata.Pet_Type + "</h5>"
							 + "</td>"
							 + "<td>"
							 + "<h5>" + tempdata.Pet_Breed + "</h5>"
							 + "</td>"
							 + "<td>"
							 + "<h5> R" + tempdata.Pet_Price + "</h5>"
							 + "</td>"
							 + "<td>"
							 + "<h5>" + tempdata.Pet_Quantity + "</h5>"
							 + "</td>"
							 + "<td>"
							 + "<a href ='UpdatePet.aspx?Add=" + tempdata.Pet_Id.ToString() + "'>"
							 + "<img src='img/edit.png' alt='Edit'>"
							 + "</a></td>"
							 + "<td>"
							 + "<a href ='UpdatePet.aspx?Remove=" + tempdata.Pet_Id.ToString() + "'>"
							 + "<img src='img/remove.png' alt='Remove'>"
							 + "</a></td>"
							 + "</tr></tbody>";
				}
			}

			Display += "</table>"
					+ "<br /><br />";

			Enclosing_Div.InnerHtml = Display;
		}
	}
}