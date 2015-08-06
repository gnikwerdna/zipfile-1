<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ExtractZIP.aspx.cs" Inherits="ExtractZIP" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h2>Extract a ZIP File Demo</h2>
    <p>
        Select a ZIP file from your computer and upload it to the website.
        The ZIP's contents will be extracted and saved to the
        <code>~/UserUploads</code> folder. If you protected entries with a password,
        enter it in the textbox below.
    </p>
    <p>
        ZIP file: <asp:FileUpload ID="fuZIP" runat="server" />
    </p>
    <p>
        Password (if ZIP contents are protected):
        <asp:TextBox ID="txtZIPPassword" TextMode="Password" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="btnUploadZIP" runat="server" Text="Upload ZIP File" 
            onclick="btnUploadZIP_Click" />
    </p>
    <p>
        <asp:Label ID="lblZIPInfo" runat="server" EnableViewState="False"></asp:Label>
    </p>
    <p>
        <asp:GridView ID="gvZIPContents" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="FileName" HeaderText="Name" />
                <asp:BoundField DataField="UncompressedSize" DataFormatString="{0:N0}" 
                    HeaderText="Size">
                <ItemStyle HorizontalAlign="Right" />
                </asp:BoundField>
                <asp:BoundField DataField="CompressedSize" DataFormatString="{0:N0}" 
                    HeaderText="Packed Size">
                <ItemStyle HorizontalAlign="Right" />
                </asp:BoundField>
            </Columns>
        </asp:GridView>
    </p>
</asp:Content>

