using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practice_makes_perfect
{
    public partial class agent_history : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (AgentGlobals.isloggedin == false)
            {
                Response.Redirect("agent_login.aspx");
            }
        }
    }
}