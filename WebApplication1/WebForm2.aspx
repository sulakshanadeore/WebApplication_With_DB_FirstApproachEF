


 <%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication1.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

        <asp:GridView ID="GridView1" runat="server"></asp:GridView>
            <asp:Label ID="Label1" runat="server" Text="Enter CatID"></asp:Label>
            <asp:TextBox ID="txtcatid" runat="server"></asp:TextBox>
        <br />
            <asp:Label ID="Label2" runat="server" Text="Enter CatName"></asp:Label>
            <asp:TextBox ID="txtcatname" runat="server"></asp:TextBox>
        <br />

         <asp:Label ID="Label3" runat="server" Text="Enter Description"></asp:Label>
          <asp:TextBox ID="txtdesc" runat="server"></asp:TextBox>
            <br />
        <asp:Button ID="btnadd" runat="server" Text="Insert" OnClick="btnadd_Click" />
        <asp:Button ID="btnedit" runat="server" Text="Update" OnClick="btnedit_Click" />
        <asp:Button ID="btndelete" runat="server" Text="Delete" OnClick="btndelete_Click" />
        <asp:Button ID="btnfind" runat="server" Text="Find" OnClick="btnfind_Click" />


     
        
    </form>
</body>
</html>
