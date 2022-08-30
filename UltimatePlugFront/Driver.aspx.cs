using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using WebApplication14UltimatePlugFront.ServiceReference1;

namespace WebApplication14UltimatePlugFront
{
    public partial class Driver : System.Web.UI.Page
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
        protected void CreateAccount(object sender, EventArgs e)
        {
            var check = link.isDriverReg(Session["Usermail"].ToString());
            if(check==false)
            {
                var add = link.addDriver(Session["Usermail"].ToString(), LicenceNumber.Value,
                    NumberPlate.Value, CarName.Value, Session["image"].ToString());

                if(add==1)
                {
                    Response.Redirect("Success");
                }
                else if (add == -1)
                {
                    Response.Redirect("Error");
                }
                else if(add==0)
                { Response.Redirect("Something else"); }
            }
        }
        protected void Button4_Click(object sender, EventArgs e)
        {
            string path = Server.MapPath("~/pictures/");
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            FileUpload1.SaveAs(path + Path.GetFileName(FileUpload1.FileName));
            Image1.ImageUrl = "/pictures/" + Path.GetFileName(FileUpload1.FileName);
            Session["image"] = Image1.ImageUrl;
        }
    }
}