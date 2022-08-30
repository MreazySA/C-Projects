using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication14UltimatePlugFront.ServiceReference1;
namespace UtlimatePlug_FrontEnd
{
    public partial class Login : System.Web.UI.Page
    {
        ServiceClient link = new ServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public override void VerifyRenderingInServerForm(Control control)
        {
            /* Confirms that an HtmlForm control is rendered for the specified ASP.NET
          server control at run time. */
        }
        protected void Sign_In(object sender, EventArgs e)
        {
            int check = link.logintype(Email.Value, PAssword.Value);
            if(check==1)
            {
                Session["User"] = check;
                Session["UserMail"] = Email.Value;
                Response.Redirect("HomePage.aspx");
            }else if(check==2)
            {
                Session["Admin"] = check;
                int test = link.getHirerID(Email.Value);
                if(test!=0)
                {
                    Session["HirerID"] = test;
                    Session["HirerMail"] = Email.Value;
                }
                Response.Redirect("Dashboard.aspx");
            }
            
            else
            {
                incorrect.Visible = true;
            }
            
        }

    }
}