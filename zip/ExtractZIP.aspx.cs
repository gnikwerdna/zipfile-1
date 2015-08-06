using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using Ionic.Zip;
using zip;

public partial class ExtractZIP : BasePage
{
    protected void btnUploadZIP_Click(object sender, EventArgs e)
    {
        // Make sure file has been uploaded and has a ZIP extension...
        if (!fuZIP.HasFile || string.Compare(".zip", Path.GetExtension(fuZIP.FileName), true) != 0)
        {
            base.DisplayAlert("Please select a ZIP file to upload and try again.");
            return;
        }

        var extractToFolder = Server.MapPath("~/UserUploads");

        using (var zip = ZipFile.Read(fuZIP.FileBytes))
        {
            if (!string.IsNullOrEmpty(txtZIPPassword.Text))
                zip.Password = txtZIPPassword.Text;

            zip.ExtractAll(extractToFolder, ExtractExistingFileAction.DoNotOverwrite);

            gvZIPContents.DataSource = zip.Entries;
            gvZIPContents.DataBind();
        }


        lblZIPInfo.Text = "Your ZIP file was successfully extracted. It contained the following entries...";
    }
}