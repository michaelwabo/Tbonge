using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practice_makes_perfect
{
    public partial class top_up : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (AgentGlobals.isloggedin == false)
            {
                Response.Redirect("agent_login.aspx");
            }
            ltrFloat.Text = Session["float_balance"].ToString();
        }

        protected void Button9_Click(object sender, EventArgs e)
        {

            int agent_number = int.Parse(Session["agent_no"].ToString());
            string  agent_name=Session["agent_name"].ToString();
           int agent_float=int.Parse( Session["float_balance"].ToString());
            string agent_country=Session["agent_country"].ToString(); 
            string agent_address=Session["agent_address"].ToString();
            string agent_password=Session["agent_password"].ToString();
            if (txtAmount.Text == "" || txtcardNumber.Text == "" || txtCSV.Text == "")
            {
                lblMessage.Text = " Fill all details before you proceed.";
                lblMessage.ForeColor = System.Drawing.Color.Red;
            }
            else
            {


                int amount = int.Parse(txtAmount.Text);
                string cardNumber = txtcardNumber.Text;
                string csv = txtCSV.Text;

                if (txtcardNumber.Text.Length > 16 || txtcardNumber.Text.Length < 16)
                {
                    lblMessage.Text = "Incorrect card number. Input 16 characters";
                    lblMessage.ForeColor = System.Drawing.Color.Red;
                }
                else if (txtCSV.Text.Length > 3 || txtCSV.Text.Length < 3)
                {
                    lblMessage.Text = "Incorrect csv number. Input 3 characters";
                    lblMessage.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    agent_float += amount;
                    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");
                    con.Open();
                    SqlCommand cod = new SqlCommand("INSERT INTO agent_account(agent_no,agent_name,float_balance,country,address,password) VALUES('"+agent_number+"','"+agent_name + "','"+agent_float + "','"+agent_country + "','"+agent_address + "','"+agent_password+"')",con);
                    lblMessage.Text = amount + " Has been added to your account.";
                    lblMessage.ForeColor = System.Drawing.Color.Green;
                }

            }
        }

        protected void txtAmount_TextChanged(object sender, EventArgs e)
        {

        }
    }
}