using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BE_W3_D2
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Log(object sender, EventArgs e) 
        {
            HttpCookie cookie = new HttpCookie("UserData");
            cookie.Values["Username"] = Username.Text;
            cookie.Values["Password"] = Password.Text;
            cookie.Expires= DateTime.Now.AddDays(10);
            Response.Cookies.Add(cookie);
            Response.Redirect("Logged.aspx");

        }
    }
}