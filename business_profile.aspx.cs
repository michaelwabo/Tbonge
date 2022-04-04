using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practice_makes_perfect
{
    public partial class business_profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (BusinessGlobals.isloggedin == false)
            {
                Response.Redirect("business_login.aspx");
            }

            ltrAddress.Text = Session["business_address"].ToString();
            ltrBalance.Text = Session["account_balance"].ToString();
            ltrBusinessId.Text = Session["business_id"].ToString();
            ltrBusinessName.Text = Session["business_name"].ToString();
            ltrCountry.Text = Session["business_country"].ToString();

            
        }
    }
}