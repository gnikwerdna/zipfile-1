using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Ionic.Zip;

public partial class CodeListing6 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        var zipFileToRead = Server.MapPath("~/LINQDemos.zip");
        var extractToFolder = Server.MapPath("~/LINQDemos");

        using (var zip = ZipFile.Read(zipFileToRead))
        {
            zip.ExtractSelectedEntries("name=*.cs", null, extractToFolder, ExtractExistingFileAction.OverwriteSilently);
        }
    }
}