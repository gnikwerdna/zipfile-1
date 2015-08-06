<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CodeListing2.aspx.cs" Inherits="CodeListing2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    This page creates a ZIP file that contains the <a href="Images/Sam.jpg">
        ~/Images/Sam.jpg</a> file and saves it to the path <a href="PictureOfSam2.zip">
        ~/PictureOfSam2.zip</a>. 
        In this example, the Sam.jpg image is added <i>twice</i> to the ZIP file - once to the root and once in
        a folder named My Images.
    </div>
    </form>
</body>
</html>
