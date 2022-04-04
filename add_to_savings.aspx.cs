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
    public partial class add_to_savings : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Globals.isloggedin == false)
            {
                Response.Redirect("login.aspx");
            }
            ltrBalance.Text = Session["account_balance"].ToString();
            ltrSavings.Text = Session["savings_balance"].ToString();
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            int balance = int.Parse(Session["account_balance"].ToString());
            int savings = int.Parse(Session["savings_balance"].ToString());
            int amounToSave = int.Parse(txtAmount.Text);
            string password = Session["user_password"].ToString();
            string myPassword = txtPassword.Text;
            int senderPhone = int.Parse(Session["phone"].ToString());

            if (password != myPassword)
            {
                lblMessage.ForeColor = System.Drawing.Color.Red;
                lblMessage.Text = "You entered an incorrect password. Try again!";
            }
            else
            {
                if (amounToSave > balance)
                {
                    lblMessage.Text = "You do not have enough money in your account. Try with a smaller value";
                    lblMessage.ForeColor = System.Drawing.Color.Red;

                }
                else
                {
                    int newSavings = savings + amounToSave;
                    int newBalance = balance - amounToSave;
                    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");
                    con.Open();
                    SqlCommand cod = new SqlCommand("INSERT INTO savings(phone_number,savings_amount) VALUES('"+senderPhone+"','"+newSavings+"')", con);
                    SqlCommand balCod = new SqlCommand("INSERT INTO bank_balance(phone_number,account_balance,date) VALUES('"+senderPhone+"','"+newBalance+"','"+System.DateTime.Now + "')", con);
                    cod.ExecuteNonQuery();
                    balCod.ExecuteNonQuery();
                    Session["savings_balance"] = newSavings;
                    Session["account_balance"] = newBalance;
                    con.Close();
                    lblMessage.ForeColor = System.Drawing.Color.Green;
                    lblMessage.Text = amounToSave + " has been added to your savings account. Your total savings is" + newSavings;
                }
            }

            
        }
    }
}