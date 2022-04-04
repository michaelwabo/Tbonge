using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practice_makes_perfect
{
    public partial class Master : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("send_money.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("withdraw_cash.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("pay.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("savings.aspx");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("loans.aspx");
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Response.Redirect("history.aspx");
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            Response.Redirect("profile.aspx");
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            Globals.isloggedin = false;
            Response.Redirect("profile.aspx");
        }
    }
}