using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BestFriends
{
    public partial class EditPet : System.Web.UI.Page
    {
        //ServiceReference1.WebServiceClient SR1 = new ServiceReference1.WebServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
      /*  protected void BtnAdd_Click(object sender, EventArgs e)
        {
            // Function Call
            ServiceReference1.TempData add1 = new ServiceReference1.TempData();
            add1.Pet_Breed = breed.Value;
            add1.Pet_Description = message.Value;
            add1.Pet_Image = path.Value;
            add1.Pet_Name = name.Value;
            add1.Pet_Price = decimal.Parse(price.Value);
            add1.Pet_Quantity = int.Parse(qty.Value);
            add1.Pet_Type = type.Value;

            string result = SR1.AddPet(add1);
            // Validation
            if (result == "Pet Added")
            {
                Response.Redirect("Home.aspx");
            }
            if (result == "Pet Already Exists")
            {
				msgErr.Visible = true;
                msgErr.Value = result;
            }
        }*/
    }
}