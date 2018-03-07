using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Visible = true;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Label2.Text = "Hello Again once more" + TextBox1.Text + ", how do you like github and Appharbor and SQLServer and Visual Studio?";
        }
    }
}
