using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BestFriends
{
    public partial class Home : System.Web.UI.Page
    {
		//ServiceReference1.WebServiceClient SR1 = new ServiceReference1.WebServiceClient();
		protected void Page_Load(object sender, EventArgs e)
		{/*
			// Dynamic Content Variables
			string Display = "";
			int number_of_offers = SR1.NumberOfOffers() + 1;
			// View Dynamic Content
			Display = "<form runat='server'  style='display: grid; grid-template-columns: repeat(auto-fit, minmax(300px, 300px)); grid-gap: 20px; justify-content:center;'> ";
			for (int k = 1; k < number_of_offers; k++)
			{
				ServiceReference1.TempData tempdata = SR1.GetOffer(k);

				if (tempdata != null)
				{
					Display += "<div>";
					Display += "<div>"
							 + "<a href=" + tempdata.Offer_Type + "s.aspx>"
							 + "<img src=" + tempdata.Offer_Image + " height='300' width='300' />"
							 + "</a>"
							 + "</div> ";
					Display += "<h4 id='pet_name' class='black' runat='server'>" + tempdata.Offer_Title+ "</h4> ";
					Display += "<p id='pet_price' class='pink' runat='server'>" + tempdata.Offer_Description + "</p>";
					Display += "</div>";
				}
			}

			Enclosing_Div.InnerHtml = Display;
		*/
		}
	}
}