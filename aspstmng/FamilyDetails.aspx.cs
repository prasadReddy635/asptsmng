using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace aspstmng
{
    public partial class FamilyDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserDetails"] == null) { Response.Redirect("PersonalDetails.aspx"); }
            if (!IsPostBack) { TextBox1.Focus(); }

        }
    }
}