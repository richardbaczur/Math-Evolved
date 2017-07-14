<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ControlPanel.aspx.cs" Inherits="INfoEducatie.ControlPanel" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Approve</title>

        <!-- Latest compiled and minified CSS -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" />

    <!-- jQuery library -->
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>

    <!-- Latest compiled JavaScript --> 
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script> 
</head>
<body style="background-color:black;">
    <form id="form1" runat="server"> 
    <div class="container text-center">
        <asp:Button runat="server" CssClass="btn btn-primary" ID="prob" Text="Probleme" OnClick="prob_Click" />
        <asp:Button runat="server" CssClass="btn btn-primary" ID="quiz" Text="Quiz-uri" OnClick="quiz_Click" />
        <asp:Button runat="server" CssClass="btn btn-primary" ID="prof" Text="Profesori" OnClick="prof_Click" />
        <hr />
        <br />
        <asp:DropDownList ID="sel" CssClass="form-control" runat="server"></asp:DropDownList>
        <asp:Button ID="app" CssClass="btn btn-success" runat="server" Text="Approve" OnClick="app_Click" />
        <asp:Button ID="try" CssClass="btn btn-warning" runat="server" Text="Try" /> 
    </div>
    </form>
</body>
</html>
