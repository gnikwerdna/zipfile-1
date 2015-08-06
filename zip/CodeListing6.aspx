<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CodeListing6.aspx.cs" Inherits="CodeListing6" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <p>
            This page extracts the <code>.cs</code> files in the ZIP file <a href="LINQDemos.zip">
            LINQDemos.zip</a> to the <code>~/LINQDemos</code> folder.
            If the <code>~/LINQDemos</code> folder already exists, delete it first so
            that you can better see that this page, when visited, only extracts the
            <code>.cs</code> files.
        </p>
    </div>
    </form>
</body>
</html>
