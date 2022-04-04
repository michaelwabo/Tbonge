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
    public partial class withdraw_cash : System.Web.UI.Page
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
            con.Close();
            
        }

        protected void Button8_Click(object sender, EventArgs e)
        {

            int amount = int.Parse(txtAmount.Text);
            int agent = int.Parse(txtAgentNumber.Text);
            int senderPhone = int.Parse(Session["phone"].ToString());
            int mybalance = int.Parse(Session["account_balance"].ToString());
            string password = Session["user_password"].ToString();
            string myPassword = txtPassword.Text;
            int myAgent=0;
            int agentFloat = 0;
            string agentName="",agentCountry="",agentAddress="",agentPassword="";
            string senderName = Session["name"].ToString();

            //Retrieve agent details
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");
            con.Open();
            SqlCommand agtCod = new SqlCommand("SELECT * FROM agent_account WHERE agent_no='" + agent+"'", con);
            SqlDataReader agtdr = agtCod.ExecuteReader();
            while (agtdr.Read())
            {
                myAgent = int.Parse(agtdr["agent_no"].ToString());
                agentFloat = int.Parse(agtdr["float_balance"].ToString());
                agentName = agtdr["agent_name"].ToString();
                agentCountry= agtdr["country"].ToString();
                agentAddress= agtdr["address"].ToString();
                agentPassword= agtdr["agent_name"].ToString();
            }
            con.Close();




            if (password != myPassword)
            {
                lblMessage.Text = "You entered an wrong password. Try again!";
                lblMessage.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                
                    if (amount > mybalance)
                    {
                        lblMessage.Text = "The amount you entered is greater than your balance. Try a smaller amount";
                        lblMessage.ForeColor = System.Drawing.Color.Red;
                    }
                    else
                    {
                        
                        
                            if (myAgent == 0)
                            {
                                lblMessage.Text = "The agent you entered does not exist. Enter the correct agent number";
                                lblMessage.ForeColor = System.Drawing.Color.Red;
                            }
                            else
                            {
                                agentFloat =agentFloat+ amount;
                                mybalance -= amount;
                                con.Open();
                                SqlCommand agtCd = new SqlCommand("INSERT INTO agent_account(agent_no,agent_name,float_balance,country,address,password) VALUES('"+myAgent+"','"+agentName + "','"+agentFloat + "','" +agentCountry + "','" +agentAddress + "','" +agentPassword+ "')",con);
                                agtCd.ExecuteNonQuery();
                                SqlCommand useBal = new SqlCommand("INSERT INTO bank_balance(phone_number,account_balance,date) VALUES('"+senderPhone+"','" + mybalance + "','"+System.DateTime.Now + "')", con);
                                useBal.ExecuteNonQuery();
                                SqlCommand agenTran = new SqlCommand("INSERT INTO agent_withdraw(agent_number,user_number,user_name,amout,date) VALUES('"+myAgent + "','" +senderPhone + "','" +senderName + "','" + amount + "','" + System.DateTime.Now + "')" , con);
                                agenTran.ExecuteNonQuery();
                                con.Close();

                                lblMessage.Text = "Collect Ksh: " + amount + "From Agent : " + agentName+" with agent number "+myAgent;
                                lblMessage.ForeColor = System.Drawing.Color.Green;
                                
                            }
                        
                        
                    }
                
                
            }

            
        }
    }
}