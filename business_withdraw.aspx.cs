using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practice_makes_perfect
{
    public partial class business_withdraw : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (BusinessGlobals.isloggedin == false)
            {
                Response.Redirect("business_login.aspx");
            }
            ltrBalance.Text = Session["account_balance"].ToString();
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            int amount = int.Parse(txtAmount.Text);
            int agent = int.Parse(txtAgentNumber.Text);
            int mybalance = BusinessGlobals.bankBalance;
            string password = BusinessGlobals.password;
            string myPassword = txtPassword.Text;

            if (password != myPassword)
            {
                lblMessage.Text = "You entered an wrong password. Try again!";
                lblMessage.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                if (amount > mybalance)
                {
                    lblMessage.Text = "The amount you entered is greater than your balance. Try a smaller amount";
                    lblMessage.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    lblMessage.Text = "Collect Ksh: " + amount + "From Agent : " + agent;
                    lblMessage.ForeColor = System.Drawing.Color.Green;
                    mybalance -= amount;
                }
            }
        }
    }
}