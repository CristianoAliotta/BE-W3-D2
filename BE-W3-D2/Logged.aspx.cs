using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BE_W3_D2
{
    public partial class Logged : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["UserData"] != null) 
            {
               string Name = Request.Cookies["UserData"]["Username"];
                Detail.Text = $"Benvenuto {Name}";
            } else
            {
                Response.Redirect("Default.aspx");
            }
           
        }
        protected void Quit(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("UserData");
            cookie.Expires= DateTime.Now.AddMinutes(-1);
            Response.Cookies.Add(cookie);
            Response.Redirect("Default.aspx");
        }
    }
}