<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TemeClase.aspx.cs" Inherits="INfoEducatie.TemeClase" %>

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
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
    <link href="jquery-ui.css" rel="stylesheet" />
    <script src="jquery-ui.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <h2 runat="server" id="selected"></h2>
        <br />
        <label>Selectectati clasa</label><br />
        <asp:DropDownList runat="server" ID="cls" CssClass="form-control"></asp:DropDownList><asp:Button runat="server" ID="sel" Text="Selecteaza clasa" CssClass="btn btn-primary" OnClick="sel_Click" />
        <br />
        <label>Selecteaza problema</label><br />
        <asp:DropDownList runat="server" ID="prob" CssClass="form-control"></asp:DropDownList><br />
        <asp:Button runat="server" ID="add" Text="Adauga problema" CssClass="btn btn-success pull-left" OnClick="add_Click" /><br />
        <textarea runat="server" id="probleme" class="form-control" rows="5"></textarea>
        <br />
        <asp:Button runat="server" ID="set" Text="Posteaza tema" CssClass="btn btn-success" OnClick="set_Click" />
    </form>
</body>
</html>
