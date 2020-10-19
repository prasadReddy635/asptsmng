using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace aspstmng
{
    public partial class LoginWithFailureCount_aspx : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtuser.Focus();
                ViewState["FailureCount"] = 0;
            }
        }
        protected void btnlgn_Click(object sender, EventArgs e)
        {
            if (txtuser.Text == "admin" && txtpwd.Text == "admin")
            {
                Response.Redirect("SuccessWithFailureCount.aspx?Name=" + txtuser.Text);
            }
            else
            {
                int Count = (int)ViewState["FailureCount"] + 1;
                if (Count == 4)
                {
                    Response.Redirect("FailureWithFailureCount.aspx?Name=" + txtuser.Text + "&Count=" + Count);
                }
                ViewState["FailureCount"] = Count;
                lblmsg.Text = Count + " attempt(s) failed, maximum are 4.";

            }
        }

        protected void btnrst_Click(object sender, EventArgs e)
        {
            txtuser.Text = txtpwd.Text = ""; txtuser.Focus();
        }
    }
}