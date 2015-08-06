using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Ionic.Zip;
using zip;


public partial class CreateZIP : BasePage
{
    protected void btnDownloadForms_Click(object sender, EventArgs e)
    {
        // Make sure at least one form has been selected...
        if (cblTaxForms.SelectedItem == null)
        {
            base.DisplayAlert("Please select one or more forms to download and try again.");
            return;
        }

        // The Content-Disposition header tells the browser to display the Save As dialog box for this response
        // The Content-Type header tells the browser the data being returned is a ZIP file
        var downloadFileName = string.Format("TaxForms-{0}.zip", DateTime.Now.ToString("yyyy-MM-dd-HH_mm_ss"));
        Response.AddHeader("Content-Disposition", "attachment; filename=" + downloadFileName);
        Response.ContentType = "application/zip";


        using (var zip = new ZipFile())
        {
            if (!string.IsNullOrEmpty(txtZIPPassword.Text))
            {
                zip.Password = txtZIPPassword.Text;
                zip.Encryption = EncryptionAlgorithm.PkzipWeak;
            }

            var readMeContent = string.Format("This ZIP file was created by DotNetZip at {0} and contains the following files:{1}{1}", DateTime.Now, Environment.NewLine);

            foreach (ListItem liForm in cblTaxForms.Items)
            {
                if (liForm.Selected)
                {
                    var fullTaxFormFilePath = Server.MapPath("~/TaxForms/" + liForm.Value);
                    
                    zip.AddFile(fullTaxFormFilePath, "Requested Forms");

                    readMeContent += string.Format("\t* {0} - {1}{2}", liForm.Text, liForm.Value, Environment.NewLine);
                }
            }

            // Do NOT protect this file
            zip.Password = null;
            zip.AddEntry("README.txt", readMeContent);
            
            zip.Save(Response.OutputStream);
        }
    }
}