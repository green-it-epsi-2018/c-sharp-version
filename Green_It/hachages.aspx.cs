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
    public partial class hachages : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSend_Click(object sender, EventArgs e)
        {
            DateTime DateLancement = DateTime.Now;
            lblResult.Text = string.Empty;

            List<string> _ListData = Utils.ReadFileCSV(new StreamReader(fileUpload.PostedFile.InputStream));

            foreach (string data in _ListData)
            {
                lblResult.Text += Utils.HashesCsvFile(data.Replace("<br>", "")) + " <br><br>";
            }
           /* Parallel.ForEach(_ListData, data =>
            {
                lblResult.Text += Utils.HashesCsvFile(data);
            });*/


            DateTime DateFin = DateTime.Now;
            TimeSpan Difference = DateFin - DateLancement;

            lblChrono.Text = "Temps passé: " + Difference.Hours.ToString("d2") + " Hours :" + Difference.Minutes.ToString("d2") + " Minutes :";
            lblChrono.Text += Difference.Seconds.ToString("d2") + " Seconds :" + Difference.Milliseconds.ToString("d2") + " Milliseconds";
        }
    }
}