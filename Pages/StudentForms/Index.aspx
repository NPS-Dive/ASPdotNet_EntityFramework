<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Session34_EntityFramework.Pages.StudentForms.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="../../Contents/css/StyleSheet1.css" rel="stylesheet" type="text/css" />
    <title>Index Page</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="mainDiv">
            <br />
            <a onclick="OpenLink(-1)" class="NewBTN">New Entry</a>
            <br />
            <br />
            <asp:GridView ID="MyGrid" HeaderStyle-CssClass="headerGrid" AutoGenerateColumns="false" runat="server" CellSpacing="4" CellPadding="4">
                <Columns>
                    <asp:BoundField DataField="VorName" HeaderText="Student's Name" />
                    <asp:BoundField DataField="Family" HeaderText="Student's LastName" />
                    <asp:TemplateField>
                        <ItemTemplate>
                            <a onclick='<%# Eval("ID", "OpenLink({0})") %>' class="mouseOver">
                                <img src="../../Contents/img/puzzle-48.png" width="25" height="25" /></a>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
    </form>
    <script src="../../Contents/js/JavaScript.js" type="text/javascript"></script>
</body>
</html>
