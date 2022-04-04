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
    public partial class pay : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Globals.isloggedin == false)
            {
                Response.Redirect("login.aspx");
            }
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");
            con.Open();
            SqlCommand cd = new SqlCommand("SELECT * FROM bank_balance WHERE phone_number=" + Session["phone"], con);
            SqlDataReader dr = cd.ExecuteReader();
            while (dr.Read())
            {
                ltrBalance.Text = dr["account_balance"].ToString();
                Session["account_balance"] = dr["account_balance"].ToString();
            }
            con.Close();
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            
            string businessId = txtBusinessId.Text.ToString();
            string counter = txtCounterNo.Text;
            int amount = int.Parse(txtAmount.Text);
            int mybalance=int.Parse(Session["account_balance"].ToString());
            string password = Session["user_password"].ToString();
            int senderPhone = int.Parse(Session["phone"].ToString());
            string myPassword = txtPassword.Text;
            string senderName = Session["name"].ToString();
            int businessBalance = 0;
            string business_id = "", business_name = "", business_country = "", business_address = "", business_password = "";
            
            //Retrieve business details
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");
            con.Open();
            SqlCommand cod = new SqlCommand("SELECT * FROM business_account WHERE business_id='" + businessId + "'", con);
            SqlDataReader dr = cod.ExecuteReader();
            while (dr.Read())
            {
                businessBalance = int.Parse(dr["account_balance"].ToString());
                business_password = dr["password"].ToString();
                business_address = dr["address"].ToString();
                business_country = dr["country"].ToString();
                business_name = dr["business_name"].ToString();
                business_id = dr["business_id"].ToString();

            }
            con.Close();

            if (password != myPassword)
            {
                lblMessage.ForeColor = System.Drawing.Color.Red;
                lblMessage.Text = "You entered an incorrect password. Try again!";
            }
            else
            {
                
                    if (amount > mybalance)
                    {
                        lblMessage.ForeColor = System.Drawing.Color.Red;
                        lblMessage.Text = "The amount you entered is greater than your balance. Reduce your cart size and try again";
                    }
                    else
                    {
                         
                            if (business_id == null)
                            {
                                lblMessage.ForeColor = System.Drawing.Color.Red;
                                lblMessage.Text = "The business you entered does not exist. Enter the correct business id";

                            }
                            else
                            {
                                mybalance -= amount;
                                businessBalance +=  amount;

                                con.Open();
                                SqlCommand userUpdate = new SqlCommand("INSERT INTO bank_balance(phone_number,account_balance,date) VALUES('" +senderPhone+"','"+ mybalance+"','"+System.DateTime.Now + "')", con);
                                userUpdate.ExecuteNonQuery();
                                SqlCommand bizCod = new SqlCommand("INSERT INTO business_account(business_id,business_name,country,address,account_balance,password) VALUES('" + business_id+"','"+business_name + "','"+business_country + "','"+business_address + "','"+businessBalance + "','"+business_password + "')", con);
                                bizCod.ExecuteNonQuery();
                                SqlCommand bizTran = new SqlCommand("INSERT INTO business_transactions(business_id, counter_number,user_phone,amount,user_name) VALUES('" + businessId + "','" + counter + "','" +senderPhone + "','" + amount + "','" +senderName+ "')", con);
                                bizTran.ExecuteNonQuery();

                                lblMessage.ForeColor = System.Drawing.Color.Green;
                                lblMessage.Text = "You have successfully paid " + amount + " to " + businessId + " At counter number: " + counter;
                                con.Close();
                            }
                        

                        
                    }
                
                
            }
            
        }
    }
}