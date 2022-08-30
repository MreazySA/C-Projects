using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using WebApplication14UltimatePlugFront.ServiceReference1;
namespace UtlimatePlug_FrontEnd
{
    public partial class Register : System.Web.UI.Page
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
           
            bool isReg = link.isReg(email.Value, Password.Value);
            if(isReg==false)
            {
                var addUser = new WebApplication14UltimatePlugFront.ServiceReference1.UserClass
                {
                    FirstName = FirstName.Value,
                    LastName = LastName.Value,
                    PhoneNumber = Phone.Value,
                    Email = email.Value,
                    Country = Country.Value,
                    Province = Province.Value,
                    City = City.Value,
                    Suburb = Suburb.Value,
                    Address = Address.Value,
                    Password = Password.Value,
                    Confirm = ConfPassword1.Value,
                    Image = Session["image"].ToString()


                };

                int add = link.register(addUser);
                if(add==1)
                {
                    Response.Redirect("Login.aspx");
                }else
                {
                    Response.Redirect("User Already Exists");
                }
            }
            Response.Redirect("#");
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