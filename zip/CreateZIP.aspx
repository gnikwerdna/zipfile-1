<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="CreateZIP.aspx.cs" Inherits="CreateZIP" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h2>Create a ZIP File Demo</h2>
    <p>
        Select the forms you'd like to download and click "Download Forms." The selected forms will be combined into a single ZIP,
        which will be returned to your browser to open or save.
        You may optionally provide a password. If you do, the ZIP file will be encrypted 
        and password protected.</p>
    <asp:CheckBoxList ID="cblTaxForms" runat="server">
        <asp:ListItem Value="f1040.pdf">Form 1040</asp:ListItem>
        <asp:ListItem Value="f1040es.pdf">Form 1040-ES</asp:ListItem>
        <asp:ListItem Value="f1099msc.pdf">Form 1099-MISC</asp:ListItem>
        <asp:ListItem Value="fw2.pdf">Form W-2</asp:ListItem>
        <asp:ListItem Value="fw4.pdf">Form W-4</asp:ListItem>
        <asp:ListItem Value="fw9.pdf">Form W-9</asp:ListItem>
    </asp:CheckBoxList>
    <br />
    Enter a password for the ZIP file (optional):
    <asp:TextBox ID="txtZIPPassword" runat="server" TextMode="Password"></asp:TextBox>
    <p>
        <asp:Button ID="btnDownloadForms" runat="server" Text="Download Forms" 
            onclick="btnDownloadForms_Click" />
    </p>
</asp:Content>

