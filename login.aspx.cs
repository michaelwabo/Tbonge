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
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int phone = int.Parse(txtPhone.Text);
            string mypassword = txtPassword.Text;
            string password,name,email;
            int myphonenumber;

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");
            SqlCommand cod = new SqlCommand("SELECT * FROM accounts WHERE phone_number="+phone,con);
            con.Open();
            SqlDataReader dr = cod.ExecuteReader();
            while (dr.Read())
            {
                password = dr["password"].ToString();
                myphonenumber = int.Parse(dr["phone_number"].ToString());
                name = dr["name"].ToString();
                email = dr["email"].ToString();

                if (password == mypassword && phone == myphonenumber)
                {
                    Globals.isloggedin = true;
                    Session["phone"] = myphonenumber;
                    Session["name"] = name;
                    Session["email"]=email;
                    Session["user_password"] = password;
                    Response.Redirect("profile.aspx");
                }
                else
                {
                    lblMessage.Text = "Incorrect phone number/ password combination";
                    lblMessage.ForeColor = System.Drawing.Color.Red;
                }
            }
            //cod.ExecuteNonQuery();

            
        }
    }
}