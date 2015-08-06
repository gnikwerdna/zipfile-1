<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h2>Welcome</h2>
    <p>
        The following demos show how to use <a href="http://dotnetzip.codeplex.com/">DotNetZip</a> to create and extract ZIP files.
    </p>
    <ul>
        <li><a href="CreateZIP.aspx">Create a ZIP file</a> - users are asked to select one or more tax forms for download.
        The selected forms are added to a ZIP, which is then sent to the user.</li>
        <li><a href="ExtractZIP.aspx">Extract a ZIP file</a> - TODO</li>
    </ul>
</asp:Content>

