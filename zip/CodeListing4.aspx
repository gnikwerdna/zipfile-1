<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CodeListing4.aspx.cs" Inherits="CodeListing4" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <p>
            This page reads and displays the contents of the ZIP file <a href="LINQDemos.zip">
            LINQDemos.zip</a>.
        </p>

        <h2>Contents of LINQDemos.zip:</h2>
        <p>
            <asp:Label ID="lblZIPContents" runat="server"></asp:Label>
        </p>
        </div>
    </form>
</body>
</html>
