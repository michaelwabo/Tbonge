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
    public partial class pay_for_loan : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Globals.isloggedin == false)
            {
                Response.Redirect("login.aspx");
            }
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");
            con.Open();
            SqlCommand cod = new SqlCommand("SELECT * FROM loans WHERE phone_number=" + Session["phone"], con);
            SqlDataReader dr = cod.ExecuteReader();
            while (dr.Read())
            {
                ltrLoanBalance.Text = dr["loan_balance"].ToString();
                Session["loan_balance"]= dr["loan_balance"].ToString();
            }
            con.Close();
            con.Open();
            SqlCommand balCod = new SqlCommand("SELECT * FROM bank_balance WHERE phone_number=" + Session["phone"], con);
            SqlDataReader balRead = balCod.ExecuteReader();
            while (balRead.Read())
            {
                ltrbalance.Text = balRead["account_balance"].ToString();
                Session["account_balance"]= balRead["account_balance"].ToString();
            }
            con.Close();
        }

        protected void Button8_Click(object sender, EventArgs e)
        {

            int amountToPay = int.Parse(txtAmount.Text);
            int balance = int.Parse(Session["account_balance"].ToString());
            int loanbalance = int.Parse(Session["loan_balance"].ToString());
            string password = Session["user_password"].ToString();
            string myPassword = txtPassword.Text;
            int senderPhone = int.Parse(Session["phone"].ToString());

            if (password != myPassword)
            {
                lblMessage.Text = "You entered a wrong password. Try again!";
                lblMessage.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                if (amountToPay > balance)
                {
                    lblMessage.Text = "You do not have enough cash to complete the transaction. top up and try again or input a smaller amount";
                    lblMessage.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    int newLoanBalance = loanbalance - amountToPay;
                    balance -= amountToPay;
                    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");
                    con.Open();
                    SqlCommand updLoan = new SqlCommand("INSERT INTO loans(phone_number,loan_balance) VALUES('"+senderPhone+"','" + newLoanBalance + "')", con);
                    SqlCommand updBal = new SqlCommand("INSERT INTO bank_balance(phone_number,account_balance,date) VALUES('" + senderPhone + "','" + balance + "','" + System.DateTime.Now + "')", con);
                    updLoan.ExecuteNonQuery();
                    updBal.ExecuteNonQuery();
                    con.Close();
                    lblMessage.Text = "You have successfully paid " + amountToPay + " for your loan. Your new loan balance is: " + newLoanBalance;
                    Session["loan_balance"] = newLoanBalance;
                    Session["account_balance"] = balance;
                }
            }
        }
    }
}