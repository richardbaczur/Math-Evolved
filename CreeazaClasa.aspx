<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreeazaClasa.aspx.cs" Inherits="INfoEducatie.CreeazaClasa" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        body{
            background-color:transparent;
        }
    </style>
     <!-- Latest compiled and minified CSS -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" />

    <!-- jQuery library -->
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>

    <!-- Latest compiled JavaScript --> 
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script> 
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1 class="text-center">Completeaza formularul pentru a creea o clasa</h1>
            <label for="name">&nbsp;&nbsp;&nbsp;Numele Clasei</label><br />
            <br />
            <asp:TextBox runat="server" type="Text" CssClass="form-control" ID="nume"></asp:TextBox><br />
            <br />
            <label for="nivel">&nbsp;&nbsp;&nbsp;Anul de studiu</label><br />
            <br />
            <asp:DropDownList CssClass="form-control" runat="server" ID="clasa">
                <asp:ListItem Text="IX" Value="9"></asp:ListItem>
                <asp:ListItem Text="X" Value="10"></asp:ListItem>
                <asp:ListItem Text="XI" Value="11"></asp:ListItem>
                <asp:ListItem Text="XII" Value="12"></asp:ListItem>
            </asp:DropDownList><br />
            <br />
            &nbsp;&nbsp;
            <asp:Button runat="server" CssClass="btn btn-success" Text="Creeaza" ID="done" OnClick="done_Click" /><br />
            <asp:Label runat="server" Font-Bold="true" Font-Size="Large" ID="success" Visible="false">Datele au fost introduse cu success</asp:Label>
            <br />
        </div>
    </form>
</body>
</html>
