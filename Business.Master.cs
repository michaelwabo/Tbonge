using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practice_makes_perfect
{
    public partial class Business : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            Globals.isloggedin = false;
            Response.Redirect("business_login.aspx");

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("business_pay.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("business_withdraw.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("business_history.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("business_profile.aspx");
        }
    }
}