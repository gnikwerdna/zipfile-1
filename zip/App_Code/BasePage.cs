using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class BasePage : System.Web.UI.Page
{
    protected virtual void DisplayAlert(string message)
    {
        ClientScript.RegisterStartupScript(
                        this.GetType(),
                        Guid.NewGuid().ToString(),
                        string.Format("alert('{0}');", message.Replace("'", @"\'")),
                        true
                    );
    }
}