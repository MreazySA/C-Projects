using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BestFriends
{
	public partial class Invoice : System.Web.UI.Page
    {
		ServiceReference1.Service1Client SR1 = new ServiceReference1.Service1Client();

		protected void Page_Load(object sender, EventArgs e)
        {
			string email = Request.QueryString["Email"];
			string date = Request.QueryString["Date"];
			string Display = "";

			//Personal Information
			ServiceReference1.TempData tempdata = new ServiceReference1.TempData();
			tempdata.Email = email;

			tempdata.Date = Convert.ToDateTime(date);
			ServiceReference1.TempData tempDataUser = null;

			string report = Request.QueryString["Report"];
			if (report != null)
			{
				tempDataUser = SR1.ViewInvoiceUser(tempdata);
			}
			else
			{
				tempDataUser = SR1.GetInvoiceUser(tempdata);
			}

			Enclosing_Div.InnerHtml = Display;
			
			Display		+= "<div class='row order_d_inner'>"
						+ "<div class='col-lg-4'>"
						+ "<div class='details_item'>"
						+ "<h4>Personal Information</h4>"
						+ "<ul class='list'>"
						+ "<li><span>Name</span>: " + tempDataUser.First_Name + "</li>"
						+ "<li><span>Surname</span>: " + tempDataUser.Last_Name + "</li>"
						+ "</ul>"
						+ "</div></div>"
						+ "<div class='col-lg-4'>"
						+ "<div class='details_item'>"
						+ "<h4>Contact Details</h4>"
						+ "<ul class='list'>"
						+ "<li><span>Email</span>: " + tempDataUser.Email + "</li>"
						+ "<li><span>Phone Number</span>: " + tempDataUser.Phone_Number + "</li>"
						+ "</ul>"
						+ "</div></div>"
						+ "<div class='col-lg-4'>"
						+ "<div class='details_item'>"
						+ "<h4>Billing Address</h4>"
						+ "<ul class='list'>"
						+ "<li><span>Email</span>: " + tempDataUser.Street_Address + "</li>"
						+ "<li><span>City</span>: " + tempDataUser.City + "</li>"
						+ "<li><span>Province</span>: " + tempDataUser.Province_State + "</li>"
						+ "<li><span>Postcode</span>: " + tempDataUser.Zip_Code + "</li>"
						+ "</ul>"
						+ "</div></div></div>";

			// Purchase Information
			int number_of_items = SR1.InvoiceItems(tempDataUser) + 1;
			decimal total = 0;

			Display	  +="<div class='order_details_table'>"
					  + "<h2>Order Details</h2>"
					  + "<div class='table-responsive'>"
					  + "<table class='table'><thead><tr>"
					  + "<th scope='col'>Name</th>"
					  + "<th scope='col'>Price</th>"
					  + "<th scope='col'>Quantity</th>"
					  + "<th scope='col'>Total</th>"
					  + "</tr></thead>";

			int dog_number = 0;
			int cat_number = 0;

			for (int i = 1; i < number_of_items; i++)
			{
				ServiceReference1.TempData tempdata2 = new ServiceReference1.TempData();
				tempdata2.Email = Session["useremail"].ToString();
				tempdata2.Date = DateTime.Now;
				tempdata2.Pet_Id = i;
				ServiceReference1.TempData tempDataPet = SR1.GetInvoicePet(tempdata2);

				if (tempDataPet != null)
				{
					total += tempDataPet.Pet_Quantity * tempDataPet.Pet_Price;
					Display += "<tbody>"
							 + "<tr>"
							 + "<td><p>" + tempDataPet.Pet_Name + "</p></td>"
							 + "<td><p>R" + tempDataPet.Pet_Price + "</p></td>"
							 + "<td><h5>x " + tempDataPet.Pet_Quantity + "</h5></td>"
							 + "<td><h5>R " + tempDataPet.Pet_Quantity * tempDataPet.Pet_Price + "</h5></td>"
							 + "</tr>";

					if (tempDataPet.Pet_Type == "Dog")
					{
						dog_number++;
					}

					if (tempDataPet.Pet_Type == "Cat")
					{
						cat_number++;
					}
				}

			}

			Display += "<tr>"
					 + "<td><h5>Subtotal</h5></td>"
					 + "<td></td> <td></td>"
					 + "<td><p>R" + Math.Round(total, 2).ToString() + "</p></td>"
					 + "</tr>"
					 + "<tr>"
					 + "<td><h5>Rate</h5></td>"
					 + "<td></td> <td></td>"
					 + "<td><p>15%</p></td>"
					 + "</tr>"
					 + "<tr>"
					 + "<td><h4>VAT</h4></td>"
					 + "<td></td> <td></td>"
					 + "<td><h4>R" + Math.Round((total * 15 / 100), 2).ToString() + "</h4></td>"
					 + "</tr>";

			decimal value1 = 0;
			decimal value2 = 0;

			// Discounts Part
			if ((dog_number != 0) || (cat_number != 0))
			{
				if (dog_number >= 2)
				{
					value1 = total * 3 / 100;
					value2 = total + (total * 15 / 100) - (total * 3 / 100);
				}
				if (dog_number >= 4)
				{
					value1 = total * 10 / 100;
					value2 = total + (total * 15 / 100) - (total * 10 / 100);
				}
				if (dog_number >= 6)
				{
					value1 = total * 13 / 100;
					value2 = total + (total * 15 / 100) - (total * 13 / 100);
				}
				if (cat_number >= 2)
				{
					value1 = total * 4 / 100;
					value2 = total + (total * 15 / 100) - (total * 4 / 100);
				}
				if (cat_number >= 4)
				{
					value1 = total * 9 / 100;
					value2 = total + (total * 15 / 100) - (total * 9 / 100);
				}
				if (cat_number >= 6)
				{
					value1 = total * 14 / 100;
					value2 = total + (total * 15 / 100) - (total * 14 / 100);
				}
			}
			else
			{
				value2 = total + (total * 15 / 100);
			}

			if (value1 != 0)
			{
				Display +="<tr>"
						+ "<td><h5>Discount</h5></td>"
						+ "<td></td> <td></td>"
						+ "<td><h5>-R" + Math.Round(value1, 2) + "</h5></td>"
						+ "</tr>"
						+ "<tr>"
						+ "<td><h4>Total</h4></td>"
						+ "<td></td> <td></td>"
						+ "<td><h4>R" + Math.Round(value2, 2) + "</h4></td>"
						+ "</tr>";
			}
			else
			{
				Display += "<tr>"
						+ "<td><h5>Total</h5></td>"
						+ "<td></td> <td></td>"
						+ "<td><h5>R" + Math.Round(value2, 2) + "</h5></td>"
						+ "</tr>";
			}

			Display  += "</tbody>"
					 + "</table>"
					 + "</div></div>";

			Enclosing_Div.InnerHtml = Display;
		}
    }
}