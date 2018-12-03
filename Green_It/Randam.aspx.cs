using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Green_It
{
    public partial class Randam : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblResult.Text = Utils.getNumber().ToString();
        }
    }
}