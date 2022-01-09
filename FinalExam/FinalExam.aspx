<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FinalExam.aspx.cs" Inherits="FinalExam.FinalExam" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="ddl_Area" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddl_Area_SelectedIndexChanged">
            </asp:DropDownList>
            <br />
            <br />
            <asp:DropDownList ID="ddl_Place" runat="server">
            </asp:DropDownList>
            <br />
            <br />
            <asp:Button ID="Btn_Search" runat="server" Text="搜尋名產" OnClick="Btn_Search_Click" />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
