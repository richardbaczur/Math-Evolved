<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="admin.aspx.cs" Inherits="INfoEducatie.admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <style>
        body{
            background-color:black;
        }
    </style>
    <title>Admin Log In</title>
        <!-- Latest compiled and minified CSS -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" />

    <!-- jQuery library --> 
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>

    <!-- Latest compiled JavaScript -->
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
</head>
<body style="background-color:black;">
    <form id="form1" runat="server">
    <div class="row">
        <div class="col-md-5"></div>
        <div class="col-md-2 text-center" style="background-color:grey;">
            <br />
            <h1 style="color:blue;">ADMIN</h1>
            <label for="name">Admin Name</label>
            <asp:TextBox runat="server" id="aName" CssClass="form-control"></asp:TextBox>
            <label for="name">Admin Password</label>
            <asp:TextBox runat="server" type="password" id="pass" CssClass="form-control"></asp:TextBox><br />
            <asp:Button runat="server" Text="Log In" CssClass="btn btn-danger" OnClick="Unnamed1_Click" />
        </div>
        <div class="col-md-5"></div>
    </div>
    </form>
</body>
</html>
