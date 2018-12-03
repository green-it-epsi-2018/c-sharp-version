using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Green_It
{
    public partial class CallWebService : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCallWebService_Click(object sender, EventArgs e)
        {
            int nbreFois = int.Parse(txtNbreFois.Text);
            for (int i = 0; i < nbreFois; i++)
            {
                Utils.callWebService();
            }
        }

        protected void btnInfoWebService_Click(object sender, EventArgs e)
        {
            localhost.WebService _WebService = Utils.callWebService();
            

        }
    }
}