<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CodeListing3.aspx.cs" Inherits="CodeListing3" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    This page creates a ZIP file that contains the <a href="Images/Sam.jpg">
        ~/Images/Sam.jpg</a> file and saves it to the path <a href="PictureOfSam3.zip">
        ~/PictureOfSam3.zip</a>. 
        In this example, the Sam.jpg image is encrypted and protected with the password <b>password</b>.
        However, the ZIPInfo.txt file is <i>not</i> protected.
    </div>
    </form>
</body>
</html>
