using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UtlimatePlug_FrontEnd
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           if(Session["User"]!=null || Session["Admin"]!=null)
            {
                Hire.Visible = true;
            }
        }

        protected void Hire_Click(object sender, EventArgs e)
        {
            Response.Redirect("ProductPage.aspx");
        }
    }
}