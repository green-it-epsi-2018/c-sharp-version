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
    public partial class Default : System.Web.UI.Page
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
            lblResult.Text = string.Empty;
         
            List<string> _ListData = Utils.ReadFileCSV(new StreamReader(fileUpload.PostedFile.InputStream));
            Parallel.ForEach(_ListData, data =>
             {
                 lblResult.Text += data;
             });
            DateTime DateFin = DateTime.Now;
            TimeSpan Difference = DateFin - DateLancement;

            lblChrono.Text = "Temps passé: " + Difference.Hours.ToString("d2") + ":" + Difference.Minutes.ToString("d2") + ":";
            lblChrono.Text += Difference.Seconds.ToString("d2") + ":" + Difference.Milliseconds.ToString("d2");
        }
    }
}