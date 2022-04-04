using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practice_makes_perfect
{
    public partial class loans : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Globals.isloggedin == false)
            {
                Response.Redirect("login.aspx");
            }
            ltrBalance.Text = Session["loan_balance"].ToString();
            ltrLoanLimit.Text = Globals.loanLimit.ToString();
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            Response.Redirect("request_for_loan.aspx");
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            Response.Redirect("pay_for_loan.aspx");
        }
    }
}