﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PropuneProb.aspx.cs" Inherits="INfoEducatie.PropuneProb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    
    <title>Selectie Probleme</title>
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
                        <h1 runat="server" id="quiztitle" class="text-center">Propune o problema</h1>
                        <br />
                        <br />
                        <div class="row" runat="server">
                            <form runat="server">
                                <div id="pprob" runat="server">
                                    <label for="name">Numele problemei</label><br/>
                                    <asp:TextBox runat="server" CssClass="form-control" ID="name"></asp:TextBox><br/>
                                    <label for="enunt">Enuntul problemei</label><br/>
                                    <asp:TextBox runat="server" ID="enunt" TextMode="MultiLine" CssClass="form-control" Columns="50" Rows="5"></asp:TextBox>
                                    <label for="Rezultat">Rezultatul problemei</label><br/>
                                    <asp:TextBox runat="server" CssClass="form-control" ID="rez"></asp:TextBox><br/>
                                    <asp:Button runat="server" Text="Propune problema" CssClass="btn btn-primary" ID="trim" OnClick="trim_Click" />
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
