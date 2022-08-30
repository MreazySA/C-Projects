using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BestFriends
{
    public partial class Cart : System.Web.UI.Page
    {
		//ServiceReference1.WebServiceClient SR1 = new ServiceReference1.WebServiceClient();
		private int Pet_ID;
		private string Display = "";

		protected void Page_Load(object sender, EventArgs e)
        {/*
			string query = Request.QueryString["Remove"];
			if (query != null)
			{
				Pet_ID = int.Parse(query);
				string result = SR1.RemoveFromCart(Pet_ID);
			}

			// Dynamic Content Variables
			int number_of_pets = SR1.NumberOfItems() + 1;
			decimal total = 0;

			// View Dynamic Content
			Display		   +="<table class='table'><thead><tr>"
						   + "<th scope='col'>Name</th>"
						   + "<th scope='col'>Breed</th>"
						   + "<th scope='col'>Price</th>"
						   + "<th scope='col'>Quantity</th>"
						   + "<th scope='col'>Remove</th>"
						   + "</tr></thead>";
			for (int p = 1; p < number_of_pets; p++)
			{
				ServiceReference1.TempData tempdata = SR1.GetItems(p);
				if (tempdata != null)
				{
					total += tempdata.Pet_Quantity * tempdata.Pet_Price;
					Display += "<tbody><tr>"
							 + "<td>"
							 + "<div class='media'><div class='media-body'>"
							 + "<h5>" + tempdata.Pet_Name + "</h5>"
							 + "</div></div>"
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
							 + "<td><a href ='Cart.aspx?Remove=" + tempdata.Pet_Id.ToString() + "'>"
							 + "<img src='img/delete.png' alt='Delete'>"
							 + "</a></td>"
							 + "</tr></tbody>";
				}
			}

			//DISPLAYING TOTAL
			Display +="<tr> <td></td> <td></td> <td></td> "
					+ "<td>"
					+ "<h5>Subtotal</h5>"
					+ "</td>"
					+ "<td>"
					+ "<h5>R" + total.ToString() + "</h5>"
					+ "</td>"
					+ "<td></td> </tr>"
					+ "</tbody></table>";

			//DISPLAYING OUTER BUTTONS
			if (Session["login"] != null)
			{
				string useremail = Session["useremail"].ToString();
				Display  +="<tr class='out_button_area'>"
						 + "<td></td> <td></td>"
						 + "<td>"
						 + "<div class='checkout_btn_inner d-flex align-items-center'>"
						 + "<a class='gray_btn' href='Home.aspx'>Continue Shopping</a>"
						 + "<a class='primary-btn' href='Checkout.aspx?id=" + useremail + "'>Proceed to checkout</a>"
						 + "<a class='gray_btn' href='Report.aspx?Type=year" + "&Email=" + useremail + "'>Purchase History</a>"
						 + "</div></td>"
						 + "</tr></tbody></table>";
			}

			Display += "<br /><br />";

			Enclosing_Div.InnerHtml = Display;*/
		}
    }
}