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
    public partial class savings : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Globals.isloggedin == false)
            {
                Response.Redirect("login.aspx");
            }
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");
            con.Open();
            SqlCommand cod = new SqlCommand("SELECT * FROM bank_balance WHERE phone_number=" + Session["phone"], con);
            SqlCommand savCod = new SqlCommand("SELECT * FROM savings WHERE phone_number=" + Session["phone"], con);
            SqlDataReader dr = cod.ExecuteReader();
            while (dr.Read())
            {
                ltrBalance.Text = dr["account_balance"].ToString();
                Session["account_balance"] = dr["account_balance"];
            }
            con.Close();
            con.Open();
            SqlDataReader savDr = savCod.ExecuteReader();
            
            while (savDr.Read())
            {
                ltrSavings.Text = savDr["savings_amount"].ToString();
                Session["savings_balance"]= savDr["savings_amount"];
            }
            con.Close();
            
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            Response.Redirect("add_to_savings.aspx");
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            Response.Redirect("withdraw_from_savings.aspx");
        }
    }
}