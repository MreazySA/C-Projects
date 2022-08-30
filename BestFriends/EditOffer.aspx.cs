using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BestFriends
{
    public partial class EditOffer : System.Web.UI.Page
    {

		//ServiceReference1.WebServiceClient SR1 = new ServiceReference1.WebServiceClient();
		private string offerid = null;
		private int offer_id = 0;
		protected void Page_Load(object sender, EventArgs e)
        {

			// Retrieve product
			/*
			offerid = Request.QueryString["offerid"];
			if (offerid != null)
			{
				offer_id = Convert.ToInt32(offerid);
				ServiceReference1.TempData edit1 = SR1.GetOffer(offer_id);
				oldDesc.Value = edit1.Offer_Description;
				oldType.Value = edit1.Offer_Type;
				oldImgPath.Value = edit1.Offer_Image;
				oldName.Value = edit1.Offer_Title;


			}
			*/
		}

		/*
		protected void btnEditOffer_Click(object sender, EventArgs e)
		{
			// Function Call
			ServiceReference1.TempData edit2 = new ServiceReference1.TempData();
			if (offer_id != 0)
			{
				edit2.Offer_Id = offer_id;

				if (newDesc.Value != "")
				{
					edit2.Offer_Description = newDesc.Value;
				}
				else
				{
					edit2.Offer_Description = oldDesc.Value;
				}
				if (newImgPath.Value != "")
				{
					edit2.Offer_Image = newImgPath.Value;
				}
				else
				{
					edit2.Offer_Image = oldImgPath.Value;
				}
				if (newName.Value != "")
				{
					edit2.Offer_Title = newName.Value;
				}
				else
				{
					edit2.Offer_Title = oldName.Value;
				}

				if (newType.Value != "")
				{
					edit2.Offer_Type = newType.Value;
				}
				else
				{
					edit2.Offer_Type = oldType.Value;
				}
				string result = SR1.EditOffer(edit2);
				// Validation 
				if (result == "Offer Updated")
				{
					Response.Redirect("Home.aspx");
				}
			}
		}*/
	}
}