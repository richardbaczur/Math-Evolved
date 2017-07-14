<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterProfi.aspx.cs" Inherits="INfoEducatie.RegisterProfi" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <!-- Latest compiled and minified CSS -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" />

    <!-- jQuery library -->
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>

    <!-- Latest compiled JavaScript -->
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
    <style>
        body{
            background-image:url("back.jpg");
        }
        .wb{
            background-color:white;
            border-radius:10px;
        }
        .slideanim { 
            visibility: hidden;
        } 

        .slide {
            animation-name: slide;
            -webkit-animation-name: slide;
            animation-duration: 1s;
            -webkit-animation-duration: 1s;
            visibility: visible;
        }

        @keyframes slide {
            0% {
                opacity: 0;
                transform: translateY(70%);
            }

            100% {
                opacity: 1;
                transform: translateY(0%);
            }
        }

        @-webkit-keyframes slide {
            0% {
                opacity: 0;
                -webkit-transform: translateY(70%);
            }

            100% {
                opacity: 1;
                -webkit-transform: translateY(0%);
            }
        }
        .bold{
            font-weight:bold;
        }
        .center img{
            width:100%;
        }
        .form-control{
            border-bottom-right-radius:15px;
            border-top-right-radius:15px;
        }
        .input-group-addon {
            border-bottom-left-radius: 15px;
            border-top-left-radius: 15px;
        }
    </style>
    <title>Register</title>
</head>
<body>
    <br />
    <br />
    <br />
    <div class="center row slide slideanim">
        <div class="col-md-5"></div>
        <div class="col-md-3">
            <div class="wb container-fluid text-center">
                <img src="log.png" />
                <form id="form1" method="post" runat="server">
                    <div class="form-group">
                        <asp:Label runat="server" ID="elabel" for="email" Text="Enter your email" Class="bold" />
                        <div class="input-group">
                            <span class="input-group-addon"><i class="glyphicon glyphicon-envelope"></i></span>
                            <asp:TextBox runat="server" class="form-control" ID="email" placeholder="example@email.com" />
                        </div>
                        <label for="name">Enter your desired name</label><br />
                        <div class="input-group">
                            <span class="input-group-addon"><i class="glyphicon glyphicon-user"></i></span>
                            <asp:TextBox runat="server" placeholder="Name" class="form-control" ID="name" />
                        </div>
                        <label for="pass">Enter your desired password</label><br />
                        <div class="input-group">
                            <span class="input-group-addon"><i class="glyphicon glyphicon-lock"></i></span>
                            <asp:TextBox runat="server" type="password" placeholder="Password" class="form-control" ID="pass" />
                        </div>
                        <label for="pass">Please confirm your password</label><br />
                        <div class="input-group">
                            <span class="input-group-addon"><i class="glyphicon glyphicon-lock"></i></span>
                            <asp:TextBox type="password" runat="server" placeholder="Confirm Password" class="form-control" ID="cpass" />
                        </div>
                        <label for="inst">Va rugam introduceti numele scolii/liceului la care predati</label>
                        <div class="input-group">
                            <span class="input-group-addon"><i class="glyphicon glyphicon-briefcase"></i></span>
                            <asp:TextBox runat="server" type="text" placeholder="CN..." CssClass="form-control" ID="inst" ></asp:TextBox>
                        </div>
                    </div>
                    <asp:Button runat="server" type="submit" class="btn btn-danger" Text="Register" OnClick="Unnamed1_Click" />
                </form>
                <br />
                <form action="Log In.aspx" target="_self">
                    <button type="submit" class="btn btn-danger">Already have an account? Log In here</button>
                </form>
                <br />
            </div>
        </div>
        <div class="col-md-4"></div>
    </div>
</body>
</html>
