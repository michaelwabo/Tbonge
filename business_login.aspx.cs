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
    public partial class business_login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            string password = txtPassword.Text;
            string businessId = txtBusinessId.Text;
            string myPassword, business_id,business_name,business_country,business_address;
            int account_balance;

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");
            SqlCommand cod = new SqlCommand("SELECT * FROM business_account WHERE business_id='" + businessId+"'", con);
            con.Open();
            SqlDataReader dr = cod.ExecuteReader();
            while (dr.Read())
            {
                myPassword = dr["password"].ToString();
                business_id = dr["business_id"].ToString();
                business_name = dr["business_name"].ToString();
                business_country = dr["country"].ToString();
                business_address = dr["address"].ToString();
                account_balance = int.Parse(dr["account_balance"].ToString());

                if (password == myPassword)
                {
                    BusinessGlobals.isloggedin = true;
                    Session["business_id"] = business_id;
                    Session["business_name"] = business_name;
                    Session["business_country"] = business_country;
                    Session["business_address"] = business_address;
                    Session["account_balance"] = account_balance;
                    Response.Redirect("business_profile.aspx");
                }
                else
                {
                    lblMessage.Text = "Incorrect password. Please try again";
                    lblMessage.ForeColor = System.Drawing.Color.Red;
                }

            }
            con.Close();

            
        }
    }
}