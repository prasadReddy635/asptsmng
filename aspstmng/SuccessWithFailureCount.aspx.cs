using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace aspstmng
{
    public partial class SuccessWithFailureCount : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string Name = Request["Name"];
            Response.Write("Hello " + Name + ", welcome to the site.");

        }
    }
}