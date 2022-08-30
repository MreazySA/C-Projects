using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NewUltimateFE
{
    public partial class Logout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["User"] = null;
            Session["Admin"] = null;
            Response.Redirect("HomePage.aspx");
        }
    }
}