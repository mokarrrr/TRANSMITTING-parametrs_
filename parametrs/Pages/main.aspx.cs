using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace parametrs.NewFolder1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void go_click(object sender, EventArgs e)
        {
            Response.Redirect(String.Format("take.aspx?login={0}", login.Value));
        }
    }
}