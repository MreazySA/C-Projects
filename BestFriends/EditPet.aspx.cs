using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BestFriends
{
    public partial class EditPet1 : System.Web.UI.Page
    {
		//ServiceReference1.WebServiceClient SR1 = new ServiceReference1.WebServiceClient();
		private string productid = null;
		private int pet_id = 0;

		protected void Page_Load(object sender, EventArgs e)
        {
			//Retrieve product
			/*
			productid = Request.QueryString["productid"];
			if (productid != null)
			{
				pet_id = int.Parse(productid);
				ServiceReference1.TempData edit1 = SR1.GetPet(pet_id);

				oldBreed.Value = edit1.Pet_Breed;
				oldDesc.Value = edit1.Pet_Description;
				oldImgPath.Value = edit1.Pet_Image;
				oldName.Value = edit1.Pet_Name;
				oldPrice.Value = edit1.Pet_Price.ToString();
				oldQty.Value = edit1.Pet_Quantity.ToString();
				oldType.Value = edit1.Pet_Type;
			}*/
		}
		/*
		protected void btnEditPet_Click(object sender, EventArgs e)
		{
			// Function Call
			ServiceReference1.TempData edit2 = new ServiceReference1.TempData();
			if (pet_id != 0)
			{
				edit2.Pet_Id = pet_id;
				if (newBreed.Value != "")
				{
					edit2.Pet_Breed = newBreed.Value;
				}
				else
				{
					edit2.Pet_Breed = oldBreed.Value;
				}
				if (newDesc.Value != "")
				{
					edit2.Pet_Description = newDesc.Value;
				}
				else
				{
					edit2.Pet_Description = oldDesc.Value;
				}
				if (newImgPath.Value != "")
				{
					edit2.Pet_Image = newImgPath.Value;
				}
				else
				{
					edit2.Pet_Image = oldImgPath.Value;
				}
				if (newName.Value != "")
				{
					edit2.Pet_Name = newName.Value;
				}
				else
				{
					edit2.Pet_Name = oldName.Value;
				}
				if (newPrice.Value != "")
				{
					edit2.Pet_Price = decimal.Parse(newPrice.Value);
				}
				else
				{
					edit2.Pet_Price = decimal.Parse(oldPrice.Value);
				}
				if (newQty.Value != "")
				{
					edit2.Pet_Quantity = int.Parse(newQty.Value);
				}
				else
				{
					edit2.Pet_Quantity = int.Parse(oldQty.Value);
				}
				if (newType.Value != "")
				{
					edit2.Pet_Type = newType.Value;
				}
				else
				{
					edit2.Pet_Type = oldType.Value;
				}
				string result = SR1.EditPet(edit2);

				// Validation 
				if (result == "Pet Updated")
				{
					Response.Redirect("Home.aspx");
				}
			}
		}*/
	}
}