<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ManageClase.aspx.cs" Inherits="INfoEducatie.ManageClase" %>

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
    <link href="jquery-ui.css" rel="stylesheet" />
    <script src="jquery-ui.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="row">
            <div class="col-md-2">
                <label for="cls">Selecteaza clasa</label><br />
                <asp:DropDownList runat="server" CssClass="form-control" ID="cls"></asp:DropDownList><br />
                <asp:Button runat="server" Text="Selecteaza clasa" ID="select" CssClass="btn btn-primary" OnClick="select_Click" />
            </div>
            <div id="manage" class="col-md-10"><br />
                <h2 id="nCls" runat="server" class="text-center"></h2><br /><br />
                <label>Adaugati elev</label><br />
                <asp:TextBox ID="nume" CssClass="form-control" Enabled="false" runat="server"></asp:TextBox><br />
                <label>Stergeti elev</label><br />
                <asp:DropDownList runat="server" Enabled="false" CssClass="form-control" ID="del"></asp:DropDownList><br /><br />
                <asp:Button runat="server" ID="add" Enabled="false" Text="Adauga elev" CssClass="btn btn-success pull-left" OnClick="add_Click" />
                <asp:Button runat="server" ID="dele" Enabled="false" Text="Sterge elev" CssClass="btn btn-danger pull-right" OnClick="dele_Click" />
            </div>
        </div>
    </form>
</body>
</html>
