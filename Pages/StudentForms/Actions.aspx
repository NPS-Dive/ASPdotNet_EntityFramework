<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Actions.aspx.cs" Inherits="Session34_EntityFramework.Pages.StudentForms.Actions" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="../../Contents/css/StyleSheet1.css" rel="stylesheet" type="text/css" />
    <title>Actions</title>
</head>
<body class="bodyAction">
    <form id="form1" runat="server">
        <div>
            Name:
            <br />
            <input type="text" id="txtName" runat="server" maxlength="50" placeholder="Name"/>
            <br />
            Last Name:
            <br />
            <input type="text" id="txtFamily" runat="server" maxlength="50" placeholder="Last Name"/>
            <br />
            <hr />
            <asp:Button id="btnInsert" runat="server" Text="Add" OnClick="btnInsert_Click"/>
            <asp:Button id="btnUpdate" runat="server" Text="Edit" OnClick="btnUpdate_Click"/>
            <asp:Button id="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click"/>
            <a onclick="CloseWindow()" class="mouseOver">Return</a>
        </div>
    </form>
    <script src="../../Contents/js/JavaScript.js" type="text/javascript"></script>
</body>
</html>
