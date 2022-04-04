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
    public partial class request_for_loan : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Globals.isloggedin == false)
            {
                Response.Redirect("login.aspx");
            }
            ltrLoanLimit.Text = Globals.loanLimit.ToString();
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            int limit = Globals.loanLimit;
            int loanRequest = int.Parse(txtLoanAmount.Text);
            string password = Session["user_password"].ToString();
            int myBal = int.Parse(Session["account_balance"].ToString());
           
            string myPassword = txtPassword.Text;

            if (password != myPassword)
            {
                lblMessage.Text = "You entered an wrong password. Try again later!";
                lblMessage.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                if (loanRequest > limit)
                {
                    lblMessage.Text = "You have entered a loan amount greater than your limit. Enter something less or equal to the limit";
                    lblMessage.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");
                    con.Open();
                    
                        int myloan = int.Parse(Session["loan_balance"].ToString());
                        int senderPhone = int.Parse(Session["phone"].ToString()); 
                        int newLoan = myloan + loanRequest;
                    int newBal = myBal + loanRequest;
                        SqlCommand insLoan = new SqlCommand("INSERT INTO loans(phone_number,loan_balance) VALUES('"+senderPhone+"','" + newLoan + "')", con);
                    SqlCommand insBal = new SqlCommand("INSERT INTO bank_balance(phone_number,account_balance,date) VALUES('" + senderPhone + "','" + newBal + "','" + System.DateTime.Now + "')", con);
                    insBal.ExecuteNonQuery();
                        insLoan.ExecuteNonQuery();
                        lblMessage.Text = "Your loan request has been processed." + loanRequest + " has been debited to your bank account";
                        lblMessage.ForeColor = System.Drawing.Color.Green;
                        Session["loan_balance"] = newLoan;
                    Session["account_balance"] = newBal;
                    
                    
                    con.Close();
                }
            }
        }
    }
}