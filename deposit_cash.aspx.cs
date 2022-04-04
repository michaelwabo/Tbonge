using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Practice_makes_perfect
{
    public partial class deposit_cash : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (AgentGlobals.isloggedin == false)
            {
                Response.Redirect("agent_login.aspx");
            }
            ltrFloatBalance.Text = Session["float_balance"].ToString();
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");
            string password = Session["agent_password"].ToString();
            int agentFloat = int.Parse(Session["float_balance"].ToString());
            int customerPhone = int.Parse(txtUserPhone.Text);
            int amount = int.Parse(txtAmount.Text);
            string agPassword = txtAgentPassword.Text;
            int customerBalance = 0;

            //Agent details 
            int agentNumber = int.Parse(Session["agent_no"].ToString());
           string agentName= Session["agent_name"].ToString();
           // Session["float_balance"].ToString();
           string agentCountry= Session["agent_country"].ToString();
           string agentAddress= Session["agent_address"].ToString();
            // Session["agent_password"].ToString();

            //Customer details
            con.Open();
            SqlCommand cus = new SqlCommand("SELECT * FROM bank_balance WHERE phone_number='" + customerPhone + "'", con);
            SqlDataReader cdr = cus.ExecuteReader();
            while (cdr.Read())
            {
                customerBalance=int.Parse(cdr["account_balance"].ToString());
            }
            con.Close();
            if (agPassword != password)
            {
                lblMessage.Text = "Incorrect password. Try again";
                lblMessage.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                if (amount > agentFloat)
                {
                    lblMessage.Text = "You do not have enough float to complete transaction, top up your float and try again";
                    lblMessage.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    con.Open();
                    
                    customerBalance += amount;
                    agentFloat -= amount;
                    SqlCommand agtUpd = new SqlCommand("INSERT INTO agent_account(agent_no,agent_name,float_balance,country,address,password) VALUES('"+agentNumber+"','"+agentName+"','"+agentFloat+"','"+agentCountry+"','"+agentAddress+"','"+password+"')",con);
                    SqlCommand cutUpd = new SqlCommand("INSERT INTO bank_balance(phone_number,account_balance,date) VALUES('" + customerPhone + "','" + customerBalance + "','" + System.DateTime.Now + "')", con);
                    agtUpd.ExecuteNonQuery();
                    cutUpd.ExecuteNonQuery();
                    lblMessage.Text = amount+" has been successfully deposited to user with account "+ customerPhone;
                    lblMessage.ForeColor = System.Drawing.Color.Green;
                }
            }
        }
    }
}