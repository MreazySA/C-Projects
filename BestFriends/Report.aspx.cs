using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BestFriends
{
    public partial class Report : System.Web.UI.Page
    {
        ServiceReference1.Service1Client SR1 = new ServiceReference1.Service1Client();

        protected void Page_Load(object sender, EventArgs e)
        {
            string Transaction = Request.QueryString["Type"];
            string Display = "";
			string History = Request.QueryString["email"];

			//DAILY TRANSACTIONS
			if (Transaction == "day")
            {
                ServiceReference1.Invoice1[] DayInvoice = SR1.GetDayInvoices();
                int numDI = 0;

                if (DayInvoice != null)
                {
                    numDI = DayInvoice.Length;
                }

                Display		   += "<h3>Today's Transactions</h3>"
                               + "<table class='table'><thead><tr>"
                               + "<th scope='col'></th>"
                               + "<th scope='col'>Date</th>"
                               + "<th scope='col'>Time</th>"
                               + "<th scope='col'>Customer</th>"
                               + "<th scope='col'>Pet Name</th>"
                               + "<th scope='col'>Pet Type</th>"
                               + "<th scope='col'>Price</th>"
                               + "<th scope='col'>Quantity</th>"
                               + "</tr></thead>";
                for (int d = 1; d < numDI; d++)
                {
                    if (DayInvoice != null)
                    {
                        Display += "<tbody><tr>"
                                 + "<td>"
                                 + "<h5>" + d + ".</h5>"
                                 + "</td>"
                                 + "<td>"
                                 + "<h5>" + DayInvoice[d].Date.Day + "/" + DayInvoice[d].Date.Month + "/" + DayInvoice[d].Date.Year + "</h5>"
                                 + "</td>"
                                 + "<td>"
                                 + "<h5>" + DayInvoice[d].Date.Hour + ":" + DayInvoice[d].Date.Minute + ":" + DayInvoice[d].Date.Second + "</h5>"
                                 + "</td>"
                                 + "<td>"
                                 + "<h5>" + DayInvoice[d].Email + "</h5>"
                                 + "</td>"
                                 + "<td>"
                                 + "<h5>" + DayInvoice[d].Pet_Name + "</h5>"
                                 + "</td>"
                                 + "<td>"
                                 + "<h5>" + DayInvoice[d].Pet_Type + "</h5>"
                                 + "</td>"
                                 + "<td>"
                                 + "<h5>R" + DayInvoice[d].Pet_Price + "</h5>"
                                 + "</td>"
                                 + "<td>"
                                 + "<h5>" + DayInvoice[d].Pet_Quantity + "</h5>"
                                 + "</td>"
                                 + "<td><a href ='Invoice.aspx?Email=" + DayInvoice[d].Email + "&Date=" + DayInvoice[d].Date.ToString() + "&Report=1" + "'>"
								 + "<img src='img/view.png' alt='view'>"
                                 + "</a></td>"
                                 + "</tr></tbody>";
                    }
                }
                Display += "</table>"
                        + "<br /><br />";
            }

            //MONTHLY TRANSACTIONS
            if (Transaction == "month")
            {
                ServiceReference1.Invoice1[] MonthInvoice = SR1.GetMonthInvoices();
                int numMI = 0;

                if (MonthInvoice != null)
                {
                    numMI = MonthInvoice.Length;
                }

                Display += "<h3>Month's Transactions</h3>"
                               + "<table class='table'><thead><tr>"
                               + "<th scope='col'></th>"
                               + "<th scope='col'>Date</th>"
                               + "<th scope='col'>Time</th>"
                               + "<th scope='col'>Customer</th>"
                               + "<th scope='col'>Pet Name</th>"
                               + "<th scope='col'>Pet Type</th>"
                               + "<th scope='col'>Price</th>"
                               + "<th scope='col'>Quantity</th>"
                               + "</tr></thead>";
                for (int m = 1; m < numMI; m++)
                {
                    if (MonthInvoice != null)
                    {
                        Display += "<tbody><tr>"
                                 + "<td>"
                                 + "<h5>" + m + ".</h5>"
                                 + "</td>"
                                 + "<td>"
                                 + "<h5>" + MonthInvoice[m].Date.Day + "/" + MonthInvoice[m].Date.Month + "/" + MonthInvoice[m].Date.Year + "</h5>"
                                 + "</td>"
                                 + "<td>"
                                 + "<h5>" + MonthInvoice[m].Date.Hour + ":" + MonthInvoice[m].Date.Minute + ":" + MonthInvoice[m].Date.Second + "</h5>"
                                 + "</td>"
								 + "<td>"
                                 + "<h5>" + MonthInvoice[m].Email + "</h5>"
                                 + "</td>"
                                 + "<td>"
                                 + "<h5>" + MonthInvoice[m].Pet_Name + "</h5>"
                                 + "</td>"
                                 + "<td>"
                                 + "<h5>" + MonthInvoice[m].Pet_Type + "</h5>"
                                 + "</td>"
                                 + "<td>"
                                 + "<h5>R" + MonthInvoice[m].Pet_Price + "</h5>"
                                 + "</td>"
                                 + "<td>"
                                 + "<h5>" + MonthInvoice[m].Pet_Quantity + "</h5>"
                                 + "</td>"
                                 + "<td><a href ='Invoice.aspx?Email=" + MonthInvoice[m].Email + "&Date=" + MonthInvoice[m].Date.ToString() + "&Report=1" + "'>"
								 + "<img src='img/view.png' alt='view'>"
                                 + "</a></td>"
                                 + "</tr></tbody>";
                    }
                }
                Display += "</table>"
                        + "<br /><br />";
            }

            //ANNUAL TRANSACTIONS
            if (Transaction == "year")
            {
                ServiceReference1.Invoice1[] YearInvoice = null;
				if (History == null)
				{
					YearInvoice = SR1.GetYearInvoices();
				}
				else
				{
					YearInvoice = SR1.GetYearHistory(History.ToString());
				}

				int numYI = 0;

                if (YearInvoice != null)
                {
                    numYI = YearInvoice.Length;
                }


				if (History == null)
				{
					Display += "<h3>This year's Transactions</h3>";
				}
				else
				{
					Display += "<h3>My History</h3>";
				}

				Display +=  "<table class='table'><thead><tr>"
                               + "<th scope='col'></th>"
                               + "<th scope='col'>Date</th>"
                               + "<th scope='col'>Time</th>"
                               + "<th scope='col'>Customer</th>"
                               + "<th scope='col'>Pet Name</th>"
                               + "<th scope='col'>Pet Type</th>"
                               + "<th scope='col'>Price</th>"
                               + "<th scope='col'>Quantity</th>"
                               + "</tr></thead>";
                for (int y = 1; y < numYI; y++)
                {
                    if (YearInvoice != null)
                    {
                        Display += "<tbody><tr>"
                                 + "<td>"
                                 + "<h5>" + y + ".</h5>"
                                 + "</td>"
                                 + "<td>"
                                 + "<h5>" + YearInvoice[y].Date.Day + "/" + YearInvoice[y].Date.Month + "/" + YearInvoice[y].Date.Year + "</h5>"
                                 + "</td>"
                                 + "<td>"
                                 + "<h5>" + YearInvoice[y].Date.Hour + ":" + YearInvoice[y].Date.Minute + ":" + YearInvoice[y].Date.Second + "</h5>"
                                 + "</td>"
                                 + "<td>"
                                 + "<h5>" + YearInvoice[y].Email + "</h5>"
                                 + "</td>"
                                 + "<td>"
                                 + "<h5>" + YearInvoice[y].Pet_Name + "</h5>"
                                 + "</td>"
                                 + "<td>"
                                 + "<h5>" + YearInvoice[y].Pet_Type + "</h5>"
                                 + "</td>"
                                 + "<td>"
                                 + "<h5>R" + YearInvoice[y].Pet_Price + "</h5>"
                                 + "</td>"
                                 + "<td>"
                                 + "<h5>" + YearInvoice[y].Pet_Quantity + "</h5>"
                                 + "</td>"
                                 + "<td><a href ='Invoice.aspx?Email=" + YearInvoice[y].Email + "&Date=" + YearInvoice[y].Date.ToString() + "&Report=1" + "'>"
								 + "<img src='img/view.png' alt='view'>"
                                 + "</a></td>"
                                 + "</tr></tbody>";
                    }
                }
                Display += "</table>"
                        + "<br /><br />";
            }
			if (History == null)
			{
				Display += "<td>"
						 + "<div class='checkout_btn_inner d-flex align-items-center'>"
						 + "<a class='gray_btn' href='ReportsPage.aspx?Type=year'>Back</a>"
						 + "</td>";

			}
			
			//Display all code
			Enclosing_Div.InnerHtml = Display;
        }
    }
}