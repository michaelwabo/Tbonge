using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;


namespace Practice_makes_perfect

{

     
    public partial class register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string name, email, password, confirmPassword;
            int phone;
            name = txtName.Text;
            email = txtEmail.Text;
            password = txtPassword.Text;
            confirmPassword = txtConfirm.Text;
            phone = int.Parse(txtPhone.Text);

            

            if (password == confirmPassword)
            {
               SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");
               SqlCommand cmd = new SqlCommand("INSERT INTO accounts(phone_number,name,email,password) VALUES("+phone+","+name+","+email+","+password+")", con);
                
                con.Open();
                cmd.ExecuteNonQuery();
               con.Close();
                Response.Redirect("login.aspx");
            }
            else
            {
                
            }
        }
    }
}