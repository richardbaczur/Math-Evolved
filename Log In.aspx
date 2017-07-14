<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Log In.aspx.cs" Inherits="INfoEducatie.Log_In" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Log In</title>
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
        .input-group-addon{
            border-bottom-left-radius:15px;
            border-top-left-radius:15px;
        }
    </style>
</head>
<body>
    <br /><br /><br />
     <div class="center row slide slideanim">
        <div class="col-md-5"></div>
        <div class="col-md-3">
            <div class="wb container-fluid text-center">
                <img src="log.png" />
                <form id="form1" method="post" runat="server">
                    <div class="form-group">
                        <label for="name">Enter your desired name</label><br />
                        <div class="input-group">
                            <span class="input-group-addon"><i class="glyphicon glyphicon-user"></i></span>
                            <asp:TextBox runat="server" placeholder="Name" class="form-control" ID="username" />
                        </div>
                        <asp:label runat="server" ID="elb" for="pass" Text="Enter your desired password" /><br />
                        <div class="input-group">
                            <span class="input-group-addon"><i class="glyphicon glyphicon-lock"></i></span>
                            <asp:TextBox runat="server" type="password" placeholder="Password" class="form-control" ID="password" />
                        </div>
                    </div>
                    <asp:Button runat="server" class="btn btn-danger" Text="Log In" OnClick="Unnamed1_Click"/><br />
                    <br />

                </form>
                <form action="Register.aspx" target="_self">
                    <button type="submit" class="btn btn-danger">Don't have an account? Register here</button>
                </form>
                <p style="color:grey;"><i>Dacă sunteți profesor, apăsați <a href="LogInProf.aspx">aici</a>!</i></p>
                <br />
            </div>
        </div>
        <div class="col-md-4"></div>
    </div>
</body>
</html>
