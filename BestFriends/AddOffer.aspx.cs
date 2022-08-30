using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BestFriends
{
	public partial class AddOffer : System.Web.UI.Page
	{
		//ServiceReference1.WebServiceClient SR1 = new ServiceReference1.WebServiceClient();

		protected void Page_Load(object sender, EventArgs e)
		{

		}
		/*
		protected void BtnAdd_Click(object sender, EventArgs e)
		{
			// Function Call
			ServiceReference1.TempData add = new ServiceReference1.TempData();
			add.Offer_Title = title.Value;
			add.Offer_Type = type.Value;
			add.Offer_Image = imgfile.Value;
			add.Offer_Description = description.Value;
			
			string result = SR1.AddOffer(add);
			// Validation
			if (result == "Offer Added")
			{
				Response.Redirect("Home.aspx");
			}
			if (result == "Offer Already Exists")
			{
				msgErr.Visible = true;
				msgErr.Value = result;
			}
			//
		}*/
	}
}