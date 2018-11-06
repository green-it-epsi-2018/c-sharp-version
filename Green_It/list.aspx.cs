using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Green_It
{
    public partial class list : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Send Data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnSend_Click(object sender, EventArgs e)
        {
            DateTime DateLancement = DateTime.Now;
            gvList.DataSource = Utils.ReadCsvFile(new StreamReader(fileUpload.PostedFile.InputStream));
            gvList.DataBind();

            DateTime DateFin = DateTime.Now;
            TimeSpan Difference = DateFin - DateLancement;

            lblChrono.Text = "Temps passé: " + Difference.Hours.ToString("d2") + " Hours :" + Difference.Minutes.ToString("d2") + " Minutes :";
            lblChrono.Text += Difference.Seconds.ToString("d2") + " Seconds :" + Difference.Milliseconds.ToString("d2") + " Milliseconds";
        }

    }
}