using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BestFriends
{
    public partial class ShopCatalog : System.Web.UI.Page
    {
       // ServiceReference1.WebServiceClient SR1 = new ServiceReference1.WebServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            // Dynamic Content Variables
            /*
            string Display = "";
            int number_of_pets = SR1.NumberOfDogs() + 1;
            // View Dynamic Content
            Display = "<form runat='server'  style='display: grid; grid-template-columns: repeat(auto-fit, minmax(300px, 300px)); grid-gap: 20px; justify-content:center;'> ";

            for (int k = 1; k < number_of_pets; k++)
            {
                ServiceReference1.TempData tempdata = SR1.GetDog(k);

                if (tempdata != null)
                {
                    Display += "<div>";
                    Display += "<a href='AboutPet.aspx?PetId=" + k.ToString() + "'>";
                    Display += "<img id='Image' src=" + tempdata.Pet_Image + " style = 'width: 300px; height: 300px' runat='server'  />";
                    Display += "</a>";
                    Display += "</td>";
                    Display += "<td id='pet - description' class='auto - style1'>";
                    Display += "<p id='pet_name' class='black' runat='server'>" + tempdata.Pet_Name + "</p> ";
                    Display += "<p id='pet_price' class='pink'  runat='server'>" + "R " + tempdata.Pet_Price.ToString() + "</p>";
                    Display += "<asp:Button ID='Button" + k + "' runat='server' Text='MORE' CommandArgument=" + k + "OnClick='Btn_Click' /> ";
                    Display += "</div>";
                }
            }
            Display += "</table>";
            Display += "</ form >";
            Enclosing_Div.InnerHtml = Display;
            */
        }
    }
}