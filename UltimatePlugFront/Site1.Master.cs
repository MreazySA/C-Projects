using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UtlimatePlug_FrontEnd
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack==false)
            {
                if(Session["User"]!=null|| Session["Admin"]!=null) 
                {
                    logout.Visible = true;
                }else if(Session["Admin"]!=null)
                {
                    Dash.Visible = true;

                }
                    else
                {
                    login.Visible = true;
                    login.Visible = true;
                    login.Visible = true;
                }
                
            }
        }

        protected void login_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
        protected void Dash_Click(object sender, EventArgs e)
        {
            Response.Redirect("Dashboard.aspx");
        }
    }
}