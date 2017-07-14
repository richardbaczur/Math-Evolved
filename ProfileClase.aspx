<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProfileClase.aspx.cs" Inherits="INfoEducatie.ProfileClase" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta charset="utf-8" />
    <!-- Latest compiled and minified CSS -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" />

    <!-- jQuery library -->
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>

    <!-- Latest compiled JavaScript -->
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
    <title>Home</title>
    <style>
        body {
            background-image: url("back.jpg");
        }
         
        .wb {
            background-color: white;
            border-radius: 10px;
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
        .im{
            width:100%;
        }
        .btn-custom{
            border-color:blue;
            background-color:white;
            color:blue;
            border-bottom-right-radius:10px;
            border-bottom-left-radius:10px;
            border-top-left-radius:0px;
            border-top-right-radius:0px;
        }
    </style>
</head>
<body>
    <form runat="server">
    <nav class="navbar navbar-default navbar-fixed-top">
        <div class="container">
            <div class="navbar-header">
                <button type="button" class="navbar-toggle" data-toggle="collapse" data-target="#navb">
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>
                <a class="navbar-brand" href="index.aspx">Math for everyone</a>
            </div>
            <div class="collapse navbar-collapse" id="navb">
                <ul class="nav navbar-nav navbar-left">
                    <li><a href="Calculator.aspx">Calculator</a></li>
                    <li><a href="Desen.aspx">Desen</a></li>
                    <li><a href="QuizSelector.aspx">Quiz</a></li>
                    <li><a href="ProblemeSel.aspx">Probleme</a></li>
                    <li><a href="Propuneri.aspx">Propuneri</a></li>
                </ul>
                <ul class="nav navbar-nav navbar-right">
                    <li>
                        <!-- De schimbat in numele utilizatorului conectat -->
                        <a href="Profile.aspx">Profile
                        </a>
                    </li>
                    <li>
                        <a href="Log In.aspx">
                            <span class="glyphicon glyphicon-log-out"></span>Log Out
                        </a>
                    </li>
                </ul>
            </div>
        </div>
    </nav>
    <br />
    <br />
    <div style="padding-top: 50px; padding-bottom: 50px;" class="row">
        <div class="col-md-1"></div>
        <div class="col-md-10 wb slide slideanim">
            <div class="row">
                <div style="padding: 5px;" class="col-md-2 text-center">
                    <h4 class="text-center" id="name" runat="server"></h4>
                    <br />
                    <br />
                    <img id="profilePic" class="im" src="#" runat="server" /><br />
                    
                        <asp:FileUpload runat="server" ID="picFile" /><br />
                        <asp:Button runat="server" CssClass="btn btn-primary" ID="picSave" Text="Salvare imagine profil" OnClick="picSave_Click" /><br />
                        <br />
                    
                    <table class="table table-bordered text-center">
                        <tr>
                            <td runat="server" id="mail"></td>
                        </tr>
                        <tr>
                            <td runat="server" id="probleme"></td>
                        </tr>
                        <tr>
                            <td runat="server" id="quiz"></td>
                        </tr>
                        <tr>
                            <td runat="server" id="accType"></td>
                        </tr>
                    </table>
                </div>
                <div style="padding: 5px;" class="col-md-10">
                    <h1 class="text-center">Profile</h1>
                    <br />
                        <asp:Button runat="server" ID="pq" CssClass="btn  btn-info" Text="Probleme/Quiz-uri" />
                        <asp:Button runat="server" ID="cls" CssClass="btn  btn-info" Text="Clasa" />
                    <div class="row">
                        <br />
                        <br />
                        <asp:DropDownList runat="server" ID="clasa" CssClass="form-control"></asp:DropDownList><br />
                        <asp:Button runat="server" ID="sel" Text="Selecteaza clasa" CssClass="btn btn-success" OnClick="sel_Click" /><br />
                        <h3 runat="server" id="teme"></h3><br />
                        <p runat="server" id="lista"></p><br />
                        <h3 runat="server" id="test"></h3><br />
                    </div>
                </div>
            </div>
        </div>
        <div class="col-md-1"></div>
    </div>
    </form>
</body>
</html>
