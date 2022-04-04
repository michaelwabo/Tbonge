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
    public partial class send_money : System.Web.UI.Page
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
            SqlDataReader dr = cod.ExecuteReader();
            while (dr.Read())
            {
                ltrBalance.Text = dr["account_balance"].ToString();
                Session["account_balance"]= int.Parse(dr["account_balance"].ToString());
            }
            
            
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            int mybalance = int.Parse(Session["account_balance"].ToString());
            int sendAmount = int.Parse(txtAmount.Text);
            int sendPhone = int.Parse(txtPhone.Text);
            int senderPhone = int.Parse(Session["phone"].ToString());
            string password = Session["user_password"].ToString();
            string myPassword = txtPassword.Text;
            int newRecBal=0;
            int recBal=0;

            //Get account balance for receiver
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");
            con.Open();
            SqlCommand reccod = new SqlCommand("SELECT * FROM bank_balance WHERE phone_number=" + sendPhone, con);
            SqlDataReader dr = reccod.ExecuteReader();
            while (dr.Read())
            {
                recBal = int.Parse(dr["account_balance"].ToString());            

            }
            con.Close();

            

            if (password != myPassword)
            {
                lblMessage.ForeColor = System.Drawing.Color.Red;
                lblMessage.Text = "You entered an incorrect password. Try again!";
            }
            else
            {
                if (sendAmount > mybalance)
                {
                    lblMessage.ForeColor = System.Drawing.Color.Red;
                    lblMessage.Text = "The Amount you entered is beyond the limit. Try a smaller amount";
                }
                else
                {
                    //update receiver balance
                    newRecBal = recBal + sendAmount;
                    //update sender balance
                    mybalance -= sendAmount;
                    con.Open();
                    
                        SqlCommand updBal = new SqlCommand("INSERT INTO bank_balance(phone_number,account_balance,date) VALUES('" + senderPhone + "','" + mybalance+"','"+System.DateTime.Now+"')", con);
                        updBal.ExecuteNonQuery();
                        if (recBal == 0)
                        {
                            SqlCommand newUBal = new SqlCommand("INSERT INTO bank_balance(phone_number,account_balance,date) VALUES('" +sendPhone+"','"+ sendAmount + "','" + System.DateTime.Now + "')", con);
                            newUBal.ExecuteNonQuery();
                        }
                        else
                        {
                        SqlCommand newUBal = new SqlCommand("INSERT INTO bank_balance(phone_number,account_balance,date) VALUES('" + sendPhone + "','" + newRecBal + "','" + System.DateTime.Now + "')", con); 
                        newUBal.ExecuteNonQuery();
                        }
                    lblMessage.ForeColor = System.Drawing.Color.Green;
                    
                    ltrBalance.Text = mybalance.ToString();
                    Globals.balance = mybalance;
                    lblMessage.Text = sendAmount + " Has been sent to " + sendPhone + " Your balance is : " + mybalance;
                }
            }

            
        }
    }
}