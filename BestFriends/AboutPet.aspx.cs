using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BestFriends
{
    public partial class AboutPet : System.Web.UI.Page
    {

	    ServiceReference1.Service1Client SR1 = new ServiceReference1.Service1Client();

		private int Pet_ID;
		private String Pet_Type = null;
		protected void Page_Load(object sender, EventArgs e)
		{

			Pet_ID = Convert.ToInt32(Request.QueryString["PetID"]);
			ServiceReference1.TempData tempdata = SR1.GetPet(Pet_ID);
			if (tempdata != null)
			{
				Pet_Type = tempdata.Pet_Type;
				Image.Src = tempdata.Pet_Image;
				pet_name.InnerHtml = tempdata.Pet_Name;
				pet_breed.InnerHtml = "<span>Breed</span> : " + tempdata.Pet_Breed;
				pet_info.InnerHtml = tempdata.Pet_Description;
				pet_price.InnerHtml = "R" + tempdata.Pet_Price.ToString();
				pet_available.InnerHtml = "<span>Availibility</span> : " + tempdata.Pet_Quantity.ToString();
			}

		}
		protected void btnAdd_Click(object sender, EventArgs e)
		{
			string result = SR1.AddtoCart(Pet_ID);
			if (result == "Success")
			{
				Response.Redirect("AboutPet.aspx?PetId=" + Pet_ID.ToString());
			}
		}
		protected void Back_Click(object sender, EventArgs e)
		{
			if (Pet_Type != null)
			{
				if ( Pet_Type == "Cat" )
				{
					Response.Redirect("Cats.aspx");
				}
				if (Pet_Type == "Dog")
				{
					Response.Redirect("Dogs.aspx");
				}
			}

			
		}


	}
}