<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FileUpload.aspx.cs" Inherits="FileUpload" %>

<!DOCTYPE html>
<!-- 
  Author:Jorge Sirias
  COP 4813 Website Application Programming
  
  -->

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Jorge Sirias Lab 1</title>
    <link href="CSS/StyleSheet.css" rel="stylesheet" type="text/css"/>
</head>
<body>
    <form id="form1" runat="server">
        <div id="Main">
            <br />
            <br />
            Lab 1
        </div>
        <br />
        <br />
        <div>
            <span style="color:white; font-size: 20px">File Upload<br />
            </span>
        &nbsp;<asp:FileUpload ID="FileUploadControl" runat="server" BackColor="White"/>
            <br />
            <asp:Button ID="UploadButton" text="Upload" runat="server" OnClick="UploadButton_Click"/>
            <asp:Button ID="CancelButton" Text="Cancel" runat="server"/>
            <br />
            <br />
            <div id="Grid" runat="server" visible="true"><asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false">
               <Columns>
                   <asp:BoundField DataField="Text" HeaderText="File Name" />
                   <asp:BoundField DataField="Text" HeaderText="File Size" />
                   <asp:BoundField DataField="Text" HeaderText="Date Modified" />
            </Columns>
            </asp:GridView></div>
            <div id="Outer" runat="server" visible="true">
                <div id="MessageBox" runat="server" visible="true">
                    <asp:Label ID="Label1" runat="server"></asp:Label>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
