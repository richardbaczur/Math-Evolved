﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Quiz.aspx.cs" Inherits="INfoEducatie.Quiz" %>
<%@ PreviousPageType VirtualPath="~/QuizSelector.aspx" %> 
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title id="title"></title>
        <!-- Latest compiled and minified CSS -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" />

    <!-- jQuery library -->
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>

    <!-- Latest compiled JavaScript -->
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
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

        .im {
            width: 100%;
        }
        btn{
            width:50px;
        }
        .hov:hover {
            background-color:#66ffff;
        }
        .brd{
            border-bottom-right-radius:10px;
            border-bottom-left-radius:10px;
        }
    </style>
</head>
<body>
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
                        <a href="Profile.aspx">
                            Profile
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
    </nav><br /><br />
    <div class="row" style="padding-top:50px;padding-bottom:50px;">
        <div class="col-md-1"></div>
        <div class="col-md-10 wb">
            <div class="row">
                <div style="padding: 5px;" class="col-sm-2">
                    <img class="im" src="log.png" />
                </div>
                <div style="padding: 50px;" class="col-sm-8">
                    <div class="row">
                        <h1 runat="server" id="quiztitle" class="text-center">Quiz Selection</h1>
                        <br />
                        <br />
                        <div class="row" runat="server">
                            <form runat="server">
                                <div id="quiz" runat="server">
                                    <asp:Label runat="server" ID="e1" /><br />
                                    <asp:RadioButtonList ID="Intrebare1" runat="server">
                                    </asp:RadioButtonList><br />
                                    <asp:Label runat="server" ID="e2" /><br />
                                    <asp:RadioButtonList ID="Intrebare2" runat="server">
                                    </asp:RadioButtonList><br />
                                    <asp:Label runat="server" ID="e3" /><br />
                                    <asp:RadioButtonList ID="Intrebare3" runat="server">
                                    </asp:RadioButtonList><br />
                                    <asp:Label runat="server" ID="e4" /><br />
                                    <asp:RadioButtonList ID="Intrebare4" runat="server">
                                    </asp:RadioButtonList><br />
                                    <asp:Label runat="server" ID="e5" /><br />
                                    <asp:RadioButtonList ID="Intrebare5" runat="server">
                                    </asp:RadioButtonList><br />
                                    <asp:Label runat="server" ID="rez"></asp:Label>
                                    <asp:button runat="server" CssClass="btn btn-success" ID="trim" Text="Trimite" OnClick="trim_Click"/>
                                </div>
                            </form>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class ="col-sm-2"></div>
    </div>
</body>
</html>
