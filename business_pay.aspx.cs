using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Practice_makes_perfect
{
    public partial class business_pay : System.Web.UI.Page
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
            string businessId = txtBusinessId.Text;
            string counter = txtCounterNo.Text;
            int amount = int.Parse(txtAmount.Text);
            int mybalance = BusinessGlobals.bankBalance;
            string password = BusinessGlobals.password;
            string myPassword = txtPassword.Text;

           // string senderPhone = int.Parse(Session["phone"].ToString());
           // string myPassword = txtPassword.Text;
           // string senderName = Session["name"].ToString();
            int businessBalance = 0;
            int mbusinessBalance = 0;
            string business_id = "", business_name = "", business_country = "", business_address = "", business_password = "";
            string mbusiness_id = "", mbusiness_name = "", mbusiness_country = "", mbusiness_address = "", mbusiness_password = "";


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
            con.Open();
            SqlCommand mcod = new SqlCommand("SELECT * FROM business_account WHERE business_id='" + businessId + "'", con);
            SqlDataReader mdr = cod.ExecuteReader();
            while (mdr.Read())
            {
                mbusinessBalance = int.Parse(mdr["account_balance"].ToString());
                mbusiness_password = mdr["password"].ToString();
                mbusiness_address = mdr["address"].ToString();
                mbusiness_country = mdr["country"].ToString();
                mbusiness_name = mdr["business_name"].ToString();
                mbusiness_id = mdr["business_id"].ToString();

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
                    con.Open();
                    // SqlCommand userUpdate = new SqlCommand("INSERT INTO bank_balance(phone_number,account_balance,date) VALUES('" + senderPhone + "','" + mybalance + "','" + System.DateTime.Now + "')", con);
                    // userUpdate.ExecuteNonQuery();
                    businessBalance += amount;
                    mbusinessBalance -= amount;
                    SqlCommand bizCod = new SqlCommand("INSERT INTO business_account(business_id,business_name,country,address,account_balance,password) VALUES('" + business_id + "','" + business_name + "','" + business_country + "','" + business_address + "','" + businessBalance + "','" + business_password + "')", con);
                    bizCod.ExecuteNonQuery();
                    SqlCommand mbizCod = new SqlCommand("INSERT INTO business_account(business_id,business_name,country,address,account_balance,password) VALUES('" + mbusiness_id + "','" + mbusiness_name + "','" + mbusiness_country + "','" + mbusiness_address + "','" + mbusinessBalance + "','" + mbusiness_password + "')", con);
                   mbizCod.ExecuteNonQuery();
                    //SqlCommand bizTran = new SqlCommand("INSERT INTO business_transactions(business_id, counter_number,user_phone,amount,user_name) VALUES('" + businessId + "','" + counter + "','" + senderPhone + "','" + amount + "','" + senderName + "')", con);
                    //bizTran.ExecuteNonQuery();

                    lblMessage.ForeColor = System.Drawing.Color.Green;
                    lblMessage.Text = "You have successfully paid " + amount + " to " + businessId + " At counter number: " + counter;
                    con.Close();
                    lblMessage.ForeColor = System.Drawing.Color.Green;
                    lblMessage.Text = "You have successfully paid " + amount + " to " + businessId + " At counter number: " + counter;
                    mybalance -= amount;
                }
            }
        }
    }
}