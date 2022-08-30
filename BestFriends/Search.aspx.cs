using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BestFriends
{
	public partial class Search : System.Web.UI.Page
	{

		ServiceReference1.Service1Client SR1 = new ServiceReference1.Service1Client();
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void btnSearch_Click(object sender, EventArgs e)
		{
			// Function Call
			ServiceReference1.TempData tempdata = SR1.Get_Pet(search.Value);

			// Request Validation
			if (tempdata != null)
			{
				if (tempdata.Pet_Type == "Dog")
				{
					Response.Redirect("AboutPet.aspx?PetId=" + tempdata.Pet_Id.ToString());
				}
				if (tempdata.Pet_Type == "Cat")
				{
					Response.Redirect("AboutPet.aspx?PetId=" + tempdata.Pet_Id.ToString());
				}
				else
				{
					search.Value = "NoSuchProduct";
				}
			}
			else
			{
				search.Value = "NoSuchProduct";
			}

		}
	}
}