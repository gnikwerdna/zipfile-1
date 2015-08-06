using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Ionic.Zip;

public partial class CodeListing2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        using (var zip = new ZipFile())
        {
            var imagePath = Server.MapPath("~/Images/Sam.jpg");
            zip.AddFile(imagePath, string.Empty);
            zip.AddFile(imagePath, "My Images");

            zip.AddEntry("ZIPInfo.txt", "This ZIP file was created on " + DateTime.Now);
            
            var saveToFilePath = Server.MapPath("~/PictureOfSam2.zip");
            zip.Save(saveToFilePath);
        }
    }
}