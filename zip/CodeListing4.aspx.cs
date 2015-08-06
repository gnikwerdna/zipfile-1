using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using Ionic.Zip;

public partial class CodeListing4 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        var output = new StringBuilder();

        var zipFileToRead = Server.MapPath("~/LINQDemos.zip");
        using (var zip = ZipFile.Read(zipFileToRead))
        {
            output.Append("<ul>");

            foreach (var entry in zip.Entries)
            {
                if (!entry.IsDirectory)
                {
                    output.AppendFormat("<li><b>{0}</b> - Packed Size / Original Size: {1:N0} / {2:N0}</li>",
                        entry.FileName, entry.UncompressedSize, entry.CompressedSize);
                }
            }

            output.Append("</ul>");
        }

        lblZIPContents.Text = output.ToString();
    }
}