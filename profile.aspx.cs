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
    public partial class profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Globals.isloggedin == false)
            {
                Response.Redirect("login.aspx");
            }
            int phone = int.Parse(Session["phone"].ToString());
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");
            SqlCommand saveCode = new SqlCommand("SELECT * FROM savings WHERE phone_number="+phone,con);
            SqlCommand loanCode = new SqlCommand("SELECT * FROM loans WHERE phone_number=" + phone, con);
            SqlCommand accBal = new SqlCommand("SELECT * FROM bank_balance WHERE phone_number=" + phone, con);

            con.Open();
            SqlDataReader saveReader = saveCode.ExecuteReader();
            while (saveReader.Read())
            {
                string mysavings = saveReader["savings_amount"].ToString();
                ltrSavings.Text = mysavings;
                Session["savings_balance"] = mysavings;
            }
            con.Close();
            con.Open();
            SqlDataReader loanReader = loanCode.ExecuteReader();
            while (loanReader.Read())
            {
                ltrLoanBalance.Text = loanReader["loan_balance"].ToString();
                Session["loan_balance"] = loanReader["loan_balance"].ToString();

            }
            con.Close();
            con.Open();
            SqlDataReader accReader = accBal.ExecuteReader();

            while (accReader.Read())
            {
                ltrBalance.Text = accReader["account_balance"].ToString();
                Session["account_balance"]= accReader["account_balance"].ToString();
            }
            con.Close();
            

            //ltrDOB.Text = Globals.dob;
            ltrFirstName.Text = Session["name"].ToString();
            ltrLastName.Text = Session["email"].ToString();
           // ltrLocation.Text = Globals.location;
           // ltrOccupation.Text = Globals.ocupation;
            ltrPhone.Text = Session["phone"].ToString();
            
             
            ltrLoanLimit.Text = Globals.loanLimit.ToString();
            

             

        }
    }
}