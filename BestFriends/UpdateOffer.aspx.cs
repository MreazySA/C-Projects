using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BestFriends
{
	public partial class UpdateOffer : System.Web.UI.Page
	{
		ServiceReference1.Service1Client SR1 = new ServiceReference1.Service1Client();
		private int Offer_ID;
		private string Display = "";

		protected void Page_Load(object sender, EventArgs e)
		{
			string query1 = Request.QueryString["Remove"];

			if (query1 != null)
			{
				Offer_ID = int.Parse(query1);
				string result = SR1.RemoveOffer(Offer_ID);
			}

			string query2 = Request.QueryString["Add"];
			if (query2 != null)
			{
				Offer_ID = int.Parse(query2);
				Response.Redirect("EditOffer.aspx?offerid=" + Offer_ID);
			}

			// Dynamic Content Variables
			int number_of_offers = SR1.NumberOfOffers() + 1;

			// View Dynamic Content
			Display		   +="<h3>Offers</h3>"
						   + "<table class='table'><thead><tr>"
						   + "<th scope='col'>Title</th>"
						   + "<th scope='col'>Type</th>"
						   + "<th scope='col'>Edit</th>"
						   + "<th scope='col'>Remove</th>"
						   + "</tr></thead>";
			for (int k = 1; k < number_of_offers; k++)
			{
				ServiceReference1.TempData tempdata = SR1.GetOffer(k);
				if (tempdata != null)
				{
					Display += "<tbody><tr>"
								 + "<td>"
								 + "<h5>" + tempdata.Offer_Title + "</h5>"
								 + "</td>"
								 + "<td>"
								 + "<h5>" + tempdata.Offer_Type + "</h5>"
								 + "</td>"
								 + "<td><a href ='UpdateOffer.aspx?Add=" + tempdata.Offer_Id.ToString() + "'>"
								 + "<img src='img/edit.png' alt='Edit'>"
								 + "</a></td>"
								 + "<td><a href ='UpdateOffer.aspx?Remove=" + tempdata.Offer_Id.ToString() + "'>"
								 + "<img src='img/remove.png' alt='Remove'>"
								 + "</a></td>"
								 + "</tr></tbody>";
				}
			}

			Display		+="</table></div>"
						+ "<br /><br />"
						+ "<br /><br />";

			Enclosing_Div.InnerHtml = Display;
		}
	}
}