using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;


namespace Green_It
{
    public partial class Pictures : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string[] filePaths = Directory.GetFiles(@"C: \Users\Utilisateur\source\repos\Green_It\Green_It\images\", "*.jpg");
            foreach (string file in filePaths)
            {
                byte[] imageArray = File.ReadAllBytes(file);

                System.Web.UI.WebControls.Image newimage = new System.Web.UI.WebControls.Image();
                newimage.ImageUrl = "data:image/jpg;base64," + Convert.ToBase64String(imageArray);
                
                pnlContent.Controls.Add(newimage);

            }
        }
    }
}