using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace aspstmng
{
    public partial class FailureWithFailureCount : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string Name = Request["Name"];
            int Count = int.Parse(Request["Count"]);
            Response.Write("Hello " + Name + ", you have failed all the" + Count + " attempts to login.");

        }
    }
}