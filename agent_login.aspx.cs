using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace Practice_makes_perfect
{
    public partial class agent_login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            int agentNumber = int.Parse(txtAgentNo.Text);
            string password = txtPassword.Text;
            string myPassword,agent_name,agent_country,agent_address;
            int float_balance;

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");
            SqlCommand cod = new SqlCommand("SELECT * FROM agent_account WHERE agent_no=" + agentNumber, con);
            con.Open();
            SqlDataReader dr = cod.ExecuteReader();
            while (dr.Read())
            {
                myPassword = dr["password"].ToString();
                agent_name = dr["agent_name"].ToString();
                float_balance = int.Parse(dr["float_balance"].ToString());
                agent_country = dr["country"].ToString();
                agent_address = dr["address"].ToString();

                if (password == myPassword)
                {
                    AgentGlobals.isloggedin = true;
                    Session["agent_no"] = agentNumber;
                    Session["agent_name"] = agent_name;
                    Session["float_balance"] = float_balance;
                    Session["agent_country"] = agent_country;
                    Session["agent_address"] = agent_address;
                    Session["agent_password"] = myPassword;
                    Response.Redirect("agent_profile.aspx");
                }
                else
                {
                    lblMessage.Text = "Incorrect password. Try again";
                    lblMessage.ForeColor = System.Drawing.Color.Red;
                }

            }
            con.Close();

            
        }
    }
}